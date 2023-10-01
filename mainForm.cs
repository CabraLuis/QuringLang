﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            ConnectLexer();
            AddLineNumbers();
        }

        private void ConnectLexer()
        {
            // Se debe colocar el archivo de la matriz para léxico llamado Lexer.xlsx en una carpeta llamada QurinLang en la ruta raiz C:/
            string filePath = @"C:/QuringLang/Lexer.xlsx";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1};IMEX={2}'";
            connection = string.Format(connection, filePath, "no", "1");
            OleDbConnection excelConnection = new OleDbConnection(connection);
            excelConnection.Open();
            DataTable dtLexer = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string excelSheet = dtLexer.Rows[0]["TABLE_NAME"].ToString();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + excelSheet + "]", excelConnection);
            OleDbDataAdapter oda = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            excelConnection.Close();
            dtgLexer.DataSource = dt;
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            txtLexer.Clear();
            txtSyntax.Clear();
            Lexer();
        }

        private void Lexer()
        {
            for (int i = 0; i < txtSourceCode.Lines.Length; i++)
            {
                // El símbolo "°" no se utiliza en ningún momento, entonces lo asignamos como fin de línea, esto para hacer las salidas más legibles
                string line = txtSourceCode.Lines[i] + " " + "°";
                char[] chars = line.ToCharArray();
                // El estado inicia en 1 debido a que la fila 0 la ocupan los símbolos de la tabla
                int state = 1;
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
                            txtLexer.AppendText(dtgLexer.Rows[state].Cells[dtgLexer.ColumnCount - 1].Value.ToString() + " ");
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
        }

        // Este método no lo hice yo, utilicé y modifiqué:
        // https://www.c-sharpcorner.com/blogs/creating-line-numbers-for-richtextbox-in-c-sharp
        private void AddLineNumbers()
        {
            // Crear y establece punto pt a (0, 0)    
            Point pt = new Point(0, 0);
            // Obtiene el primer indice y primera linea de txtSourceCode
            int First_Index = txtSourceCode.GetCharIndexFromPosition(pt);
            int First_Line = txtSourceCode.GetLineFromCharIndex(First_Index);
            // Establece coordenadas X y Y del punto pt al ancho y alto de ClientRectangle respectivamente
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // Obtiene el ultimo indice y ultima linea de txtSourceCode    
            int Last_Index = txtSourceCode.GetCharIndexFromPosition(pt);
            int Last_Line = txtSourceCode.GetLineFromCharIndex(Last_Index);
            // Establece alineación central a txtLines
            txtLines.SelectionAlignment = HorizontalAlignment.Center;
            // Establece el texto de txtLines a null y su ancho al valor retornado por getWidth()
            txtLines.Text = "";
            txtLines.Width = getWidth();
            // Agrega cada numero de linea a txtLines hasta llegar a la ultima linea
            for (int i = First_Line; i <= Last_Line; i++)
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
    }
}
