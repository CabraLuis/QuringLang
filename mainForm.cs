using System.Data;
using System.Data.OleDb;

namespace QuringLang
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            txtLines.Font = txtSourceCode.Font;
            txtSourceCode.Select();
            AddLineNumbers();

            ConnectLexer();
            ConnectGrammar();
        }

        private void ConnectLexer()
        {
            // Se debe colocar el archivo de la matriz para léxico llamado Lexer.xlsx en una carpeta llamada QurinLang en la ruta raiz C:/
            string filePath = @"C:/QuringLang/Lexer.xlsx";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}'";
            connection = string.Format(connection, filePath, "no", "1");
            OleDbConnection excelConnection = new OleDbConnection(connection);
            excelConnection.Open();
            DataTable? dtLexer = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string? excelSheet = dtLexer.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + excelSheet + "]", excelConnection);
            OleDbDataAdapter oda = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelConnection.Close();
            dtgLexer.DataSource = dt;
        }

        private void ConnectGrammar()
        {
            // Se debe colocar el archivo de la matriz para grámaticas llamado Grammar.xlsx en una carpeta llamada QurinLang en la ruta raiz C:/
            string filePath = @"C:/QuringLang/Grammar.xlsx";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}'";
            connection = string.Format(connection, filePath, "no", "1");
            OleDbConnection excelConnection = new OleDbConnection(connection);
            excelConnection.Open();
            DataTable? dtGrammar = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string? excelSheet = dtGrammar.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + excelSheet + "]", excelConnection);
            OleDbDataAdapter oda = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelConnection.Close();
            dtgGrammars.DataSource = dt;
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            // Limpiar salida de analizador léxico
            txtLexer.Clear();
            // Limpiar salida de analizador sintáctico
            txtSyntax.Clear();
            // Limpiar tabla de símbolos
            dtgSymbols.Rows.Clear();
            // Limpiar tabla de errores
            dtgErrors.Rows.Clear();

            // Ejecutar analizador léxico
            Lexer();
            // Ejecutar analizador sintáctico
            Syntax();
            // Ejecutar analizador semántico
            Semantic();
        }

        private void Lexer()
        {
            // Se recorre cada linea del código fuente
            for (int i = 0; i < txtSourceCode.Lines.Length; i++)
            {
                // Separar lineas de codigo fuente para analizar simbolos
                string[] src = txtSourceCode.Lines[i].Split(" ");
                // El símbolo "°" no se utiliza en ningún momento, entonces lo asignamos como fin de línea, esto para hacer las salidas más legibles
                string line = txtSourceCode.Lines[i] + " " + "°";
                char[] chars = line.ToCharArray();
                // El estado inicia en 1 debido a que la fila 0 la ocupan los símbolos de la tabla
                int state = 1;
                // Variable para guardar el tipo de simbolo encontrado
                string type;
                foreach (char c in chars)
                {
                    // Se utiliza dtgLexer.ColumnCount - 2 porque las ultimas 2 columnas de nuestra matriz están designadas para FDC y CAT
                    // Se utilizada j = 1 porque la columna 0 es ocupada por el indicador del estado actual
                    for (int j = 1; j < dtgLexer.ColumnCount - 2; j++)
                    {
                        // Se obtiene el símbolo a comparar con el carácter actual
                        if (c.ToString().ToUpper() == dtgLexer.Rows[0].Cells[j].Value.ToString())
                        {
                            // Se obtiene el estado siguiente al que se moverá el apuntador, se le suma 1 debido a que la fila de símbolos ocupa lo que sería el estado 0
                            state = int.Parse(dtgLexer.Rows[state].Cells[j].Value.ToString()) + 1;
                            break;
                        }
                        else if (c == ' ')
                        {
                            // Se agrega el token obtenido con un espacio en blanco a la salida del lexer
                            string token = dtgLexer.Rows[state].Cells[dtgLexer.ColumnCount - 1].Value.ToString();
                            txtLexer.AppendText(token + " ");

                            // Agregar tokens a tabla de simbolos
                            switch (token)
                            {
                                case "PR-12": type = "INT"; break;
                                case "PR-13": type = "DBL"; break;
                                case "PR-14": type = "STR"; break;
                                default: type = "N/A"; break;
                            }

                            if (type == "INT" || type == "DBL" || type == "STR")
                            {
                                // Se recorre cada linea del codigo fuente
                                for (int k = 0; k < src.Length; k++)
                                {
                                    // Si se encuentra un operado de asignación se agrega a la tabla de simbolos
                                    // i + 1 es la linea de codigo donde se encontró el simbolo
                                    // src[k - 1] es el nombre del simbolo
                                    // src[k + 1] es el valor del simbolo
                                    if (src[k] == "=")
                                    {
                                        AddSymbol(i + 1, type, src[k - 1], src[k + 1]);
                                    }
                                }
                            }

                            // Se reinicia el estado para analizar el siguiente token
                            state = 1;
                            break;
                        }
                        else if (c == '°')
                        {
                            txtLexer.AppendText(Environment.NewLine);
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < txtLexer.Lines.Length - 1; i++)
            {
                // Si se encuentra un error léxico se agrega a la tabla de errores
                if (txtLexer.Lines[i].Contains("ERLEX"))
                {
                    int line = i + 1;
                    AddError(line.ToString(), "ERLEX", "ERROR LÉXICO");
                }
            }
        }

        // Se recorren las gramáticas de forma similar al léxico, explicar la función sería redundante
        private void Syntax()
        {
            for (int i = 0; i < txtLexer.Lines.Length - 1; i++)
            {
                string tokenLine = txtLexer.Lines[i] + " " + "°";
                string[] tokens = tokenLine.Split(" ");
                int state = 1;
                foreach (string s in tokens)
                {
                    for (int j = 1; j < dtgGrammars.ColumnCount - 2; j++)
                    {
                        if (s == dtgGrammars.Rows[0].Cells[j].Value.ToString())
                        {
                            state = int.Parse(dtgGrammars.Rows[state].Cells[j].Value.ToString()) + 1;
                            break;
                        }
                        else if (s == "")
                        {
                            string instruction = dtgGrammars.Rows[state].Cells[dtgGrammars.ColumnCount - 1].Value.ToString();
                            txtSyntax.AppendText(instruction + " ");

                            state = 1;
                            break;
                        }
                        else if (s == "°")
                        {
                            txtSyntax.AppendText(Environment.NewLine);
                            break;
                        }
                    }
                }
            }
        }

        // Analizador semantico básico, revisa parentesis y simbolos con tipos de datos validos
        private void Semantic()
        {
            // Revisar paréntesis
            CheckParentheses();
            // Revisar símbolos
            CheckSymbols();
        }

        private void CheckParentheses()
        {
            for (int i = 0; i < txtLexer.Lines.Length - 1; i++)
            {
                // Pila para hacer el analisis de parentesis
                Stack<string> parentheses = new Stack<string>();
                // Separar los tokens CA-E( CA-E) de cada linea
                string[] tokensByLine = txtLexer.Lines[i].Split(" ");
                int line = i + 1;
                // Recorrer lista de tokens en la linea
                foreach (string token in tokensByLine)
                {
                    // Si encuentra apertura
                    if (token == "CA-E(")
                    {
                        // Meter a la pila
                        parentheses.Push(token);
                    }
                    // Si encuentra cierre
                    else if (token == "CA-E)")
                    {
                        // Si no hay nada en la pila
                        if (parentheses.Count <= 0)
                        {
                            // ( ) )
                            AddError(line.ToString(), "BALANCE DE PARENTÉSIS", "EXCESO DE PARÉNTESIS DE CIERRE");
                            break;
                        }
                        // Sacar ultimo token en la pila
                        parentheses.Pop();
                    }
                }
                // Si queda algo en la pila, no se encontro un parentesis de cierre
                if (parentheses.Count > 0)
                {
                    // ( ( )
                    AddError(line.ToString(), "BALANCE DE PARENTÉSIS", "EXCESO DE PARÉNTESIS DE APERTURA");
                    continue;
                }
            }
        }

        private void CheckSymbols()
        {
            // Recorrer filas de la tabla de símbolos
            foreach (DataGridViewRow row in dtgSymbols.Rows)
            {
                // Guardar lineas, tipos, nombres y valores
                string line = row.Cells[0].Value.ToString();
                string type = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string value = row.Cells[3].Value.ToString();

                // Si encuentra el tipo INT
                if (type == "INT")
                {
                    // int.TryParse(value, out int esEntero) devuelve TRUE si el valor es entero
                    if (int.TryParse(value, out int esEntero))
                    {
                        // Pasar a siguiente fila
                        continue;
                    }
                    else
                    {
                        // int var = 2.2 || int var = 'cadena'
                        AddError(line, "TIPO INCOMPATIBLE", $"{name} ESPERABA VALOR ENTERO");
                    }
                }
                else if (type == "DBL")
                {
                    // double.TryParse(value, out double esDecimal) devuelve TRUE si el valor es decimal
                    if (int.TryParse(value, out int esEntero) || !double.TryParse(value, out double esDecimal))
                    {
                        // dbl var = 2 || dbl var = 'cadena'
                        AddError(line, "TIPO INCOMPATIBLE", $"{name} ESPERABA VALOR DECIMAL");
                    }
                    else
                    {
                        // Pasar a siguiente fila
                        continue;
                    }
                }
                else if (type == "STR")
                {
                    // Si es entero o es decimal, entonces no es una cadena
                    if (int.TryParse(value, out int esEntero) || double.TryParse(value, out double esDecimal))
                    {
                        // str var = 2.2 || str var = 2
                        AddError(line, "TIPO INCOMPATIBLE", $"{name} ESPERABA UNA CADENA");
                    }
                    else
                    {
                        // Pasar a siguiente fila
                        continue;

                    }
                }
            }
        }

        private void AddSymbol(int line, string type, string name, string value)
        {

            dtgSymbols.Rows.Add(line, type, name, value);
        }

        private void AddError(string line, string type, string message)
        {
            dtgErrors.Rows.Add(line, type, message);
        }

        // Controlar display de numero en las lineas de codigo
        // Este método no lo hice yo, utilicé y modifiqué:
        // https://www.c-sharpcorner.com/blogs/creating-line-numbers-for-richtextbox-in-c-sharp
        private void AddLineNumbers()
        {
            // Crear y establece punto pt a (0, 0)    
            Point pt = new Point(0, 0);
            // Obtiene el primer indice y primera linea de txtSourceCode
            int firstIndex = txtSourceCode.GetCharIndexFromPosition(pt);
            int firstLine = txtSourceCode.GetLineFromCharIndex(firstIndex);
            // Establece coordenadas X y Y del punto pt al ancho y alto de ClientRectangle respectivamente
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // Obtiene el ultimo indice y ultima linea de txtSourceCode    
            int lastIndex = txtSourceCode.GetCharIndexFromPosition(pt);
            int lastLine = txtSourceCode.GetLineFromCharIndex(lastIndex);
            // Establece alineación central a txtLines
            txtLines.SelectionAlignment = HorizontalAlignment.Center;
            // Establece el texto de txtLines a null y su ancho al valor retornado por getWidth()
            txtLines.Text = "";
            txtLines.Width = getWidth();
            // Agrega cada numero de linea a txtLines hasta llegar a la ultima linea
            for (int i = firstLine; i <= lastLine; i++)
            {
                txtLines.Text += i + 1 + "\n";
            }
        }

        public int getWidth()
        {
            int w = 25;
            // Conseguir total de lineas de txtSourceCode
            int line = txtSourceCode.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)txtSourceCode.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)txtSourceCode.Font.Size;
            }
            else
            {
                w = 50 + (int)txtSourceCode.Font.Size;
            }

            return w;
        }

        private void txtSourceCode_TextChanged(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void txtSourceCode_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = txtSourceCode.GetPositionFromCharIndex(txtSourceCode.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void txtSourceCode_VScroll(object sender, EventArgs e)
        {
            txtLines.Text = "";
            AddLineNumbers();
            txtLines.Invalidate();
        }

        private void txtSourceCode_FontChanged(object sender, EventArgs e)
        {
            txtLines.Font = txtSourceCode.Font;
            txtSourceCode.Select();
            AddLineNumbers();
        }

        private void txtLines_MouseDown(object sender, MouseEventArgs e)
        {
            txtSourceCode.Select();
            txtLines.DeselectAll();
        }
    }
}
