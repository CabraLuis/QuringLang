namespace QuringLang
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            dtgLexer = new DataGridView();
            btnCompile = new Button();
            dtgGrammars = new DataGridView();
            dtgErrors = new DataGridView();
            lineaError = new DataGridViewTextBoxColumn();
            tipoError = new DataGridViewTextBoxColumn();
            mensajeError = new DataGridViewTextBoxColumn();
            lblLexer = new Label();
            lblSyntax = new Label();
            lblErrors = new Label();
            dtgSymbols = new DataGridView();
            lineSimbolo = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            nombreToken = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            lblSymbols = new Label();
            txtSourceCode = new RichTextBox();
            txtLexer = new RichTextBox();
            txtSyntax = new RichTextBox();
            txtLines = new RichTextBox();
            lblSourceCode = new Label();
            lblLexerOutput = new Label();
            lblSyntaxOutput = new Label();
            picLogoQuring = new PictureBox();
            label1 = new Label();
            dtgTriplets = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            txtEnsamblador = new RichTextBox();
            txtPostOrden = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgLexer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGrammars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgErrors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogoQuring).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTriplets).BeginInit();
            SuspendLayout();
            // 
            // dtgLexer
            // 
            dtgLexer.AllowUserToAddRows = false;
            dtgLexer.AllowUserToDeleteRows = false;
            dtgLexer.AllowUserToResizeColumns = false;
            dtgLexer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgLexer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgLexer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLexer.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgLexer.DefaultCellStyle = dataGridViewCellStyle2;
            dtgLexer.Location = new Point(12, 103);
            dtgLexer.Name = "dtgLexer";
            dtgLexer.ReadOnly = true;
            dtgLexer.RowHeadersVisible = false;
            dtgLexer.RowTemplate.Height = 25;
            dtgLexer.Size = new Size(336, 190);
            dtgLexer.TabIndex = 1;
            // 
            // btnCompile
            // 
            btnCompile.BackColor = Color.FromArgb(173, 247, 182);
            btnCompile.Cursor = Cursors.Hand;
            btnCompile.FlatAppearance.BorderColor = Color.FromArgb(45, 137, 139);
            btnCompile.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 137, 139);
            btnCompile.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 137, 139);
            btnCompile.FlatStyle = FlatStyle.Flat;
            btnCompile.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompile.Image = Properties.Resources.play;
            btnCompile.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompile.Location = new Point(12, 12);
            btnCompile.Name = "btnCompile";
            btnCompile.Size = new Size(336, 49);
            btnCompile.TabIndex = 2;
            btnCompile.Text = "Compilar";
            btnCompile.TextAlign = ContentAlignment.MiddleRight;
            btnCompile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCompile.UseVisualStyleBackColor = false;
            btnCompile.Click += btnCompile_Click;
            // 
            // dtgGrammars
            // 
            dtgGrammars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGrammars.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgGrammars.DefaultCellStyle = dataGridViewCellStyle3;
            dtgGrammars.Location = new Point(12, 318);
            dtgGrammars.Name = "dtgGrammars";
            dtgGrammars.ReadOnly = true;
            dtgGrammars.RowHeadersVisible = false;
            dtgGrammars.RowTemplate.Height = 25;
            dtgGrammars.Size = new Size(336, 172);
            dtgGrammars.TabIndex = 5;
            // 
            // dtgErrors
            // 
            dtgErrors.AllowUserToAddRows = false;
            dtgErrors.AllowUserToDeleteRows = false;
            dtgErrors.AllowUserToResizeColumns = false;
            dtgErrors.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgErrors.Columns.AddRange(new DataGridViewColumn[] { lineaError, tipoError, mensajeError });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgErrors.DefaultCellStyle = dataGridViewCellStyle5;
            dtgErrors.Location = new Point(12, 515);
            dtgErrors.Name = "dtgErrors";
            dtgErrors.ReadOnly = true;
            dtgErrors.RowHeadersVisible = false;
            dtgErrors.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgErrors.RowTemplate.Height = 25;
            dtgErrors.Size = new Size(543, 150);
            dtgErrors.TabIndex = 8;
            // 
            // lineaError
            // 
            lineaError.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lineaError.HeaderText = "Linea";
            lineaError.Name = "lineaError";
            lineaError.ReadOnly = true;
            lineaError.Width = 67;
            // 
            // tipoError
            // 
            tipoError.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoError.HeaderText = "Tipo";
            tipoError.Name = "tipoError";
            tipoError.ReadOnly = true;
            // 
            // mensajeError
            // 
            mensajeError.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mensajeError.HeaderText = "Mensaje";
            mensajeError.Name = "mensajeError";
            mensajeError.ReadOnly = true;
            // 
            // lblLexer
            // 
            lblLexer.AutoSize = true;
            lblLexer.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLexer.Location = new Point(12, 81);
            lblLexer.Name = "lblLexer";
            lblLexer.Size = new Size(144, 19);
            lblLexer.TabIndex = 9;
            lblLexer.Text = "Matriz de Lexer";
            // 
            // lblSyntax
            // 
            lblSyntax.AutoSize = true;
            lblSyntax.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSyntax.Location = new Point(12, 296);
            lblSyntax.Name = "lblSyntax";
            lblSyntax.Size = new Size(189, 19);
            lblSyntax.TabIndex = 10;
            lblSyntax.Text = "Matriz de Grámaticas";
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrors.Location = new Point(12, 493);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(153, 19);
            lblErrors.TabIndex = 11;
            lblErrors.Text = "Lista de Errores";
            // 
            // dtgSymbols
            // 
            dtgSymbols.AllowUserToAddRows = false;
            dtgSymbols.AllowUserToDeleteRows = false;
            dtgSymbols.AllowUserToOrderColumns = true;
            dtgSymbols.AllowUserToResizeColumns = false;
            dtgSymbols.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgSymbols.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgSymbols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSymbols.Columns.AddRange(new DataGridViewColumn[] { lineSimbolo, tipo, nombreToken, valor });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtgSymbols.DefaultCellStyle = dataGridViewCellStyle7;
            dtgSymbols.Location = new Point(561, 515);
            dtgSymbols.Name = "dtgSymbols";
            dtgSymbols.ReadOnly = true;
            dtgSymbols.RowHeadersVisible = false;
            dtgSymbols.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgSymbols.RowTemplate.Height = 25;
            dtgSymbols.Size = new Size(283, 150);
            dtgSymbols.TabIndex = 13;
            // 
            // lineSimbolo
            // 
            lineSimbolo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            lineSimbolo.HeaderText = "Linea";
            lineSimbolo.Name = "lineSimbolo";
            lineSimbolo.ReadOnly = true;
            lineSimbolo.Width = 67;
            // 
            // tipo
            // 
            tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // nombreToken
            // 
            nombreToken.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreToken.HeaderText = "Nombre";
            nombreToken.Name = "nombreToken";
            nombreToken.ReadOnly = true;
            // 
            // valor
            // 
            valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // lblSymbols
            // 
            lblSymbols.AutoSize = true;
            lblSymbols.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSymbols.Location = new Point(561, 493);
            lblSymbols.Name = "lblSymbols";
            lblSymbols.Size = new Size(162, 19);
            lblSymbols.TabIndex = 14;
            lblSymbols.Text = "Tabla de Símbolos";
            // 
            // txtSourceCode
            // 
            txtSourceCode.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceCode.Location = new Point(399, 103);
            txtSourceCode.Name = "txtSourceCode";
            txtSourceCode.Size = new Size(200, 387);
            txtSourceCode.TabIndex = 16;
            txtSourceCode.Text = "";
            txtSourceCode.WordWrap = false;
            txtSourceCode.SelectionChanged += txtSourceCode_SelectionChanged;
            txtSourceCode.VScroll += txtSourceCode_VScroll;
            txtSourceCode.FontChanged += txtSourceCode_FontChanged;
            txtSourceCode.TextChanged += txtSourceCode_TextChanged;
            // 
            // txtLexer
            // 
            txtLexer.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLexer.Location = new Point(605, 103);
            txtLexer.Name = "txtLexer";
            txtLexer.ReadOnly = true;
            txtLexer.Size = new Size(200, 181);
            txtLexer.TabIndex = 17;
            txtLexer.Text = "";
            txtLexer.WordWrap = false;
            // 
            // txtSyntax
            // 
            txtSyntax.BackColor = SystemColors.Control;
            txtSyntax.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSyntax.Location = new Point(605, 309);
            txtSyntax.Name = "txtSyntax";
            txtSyntax.ReadOnly = true;
            txtSyntax.Size = new Size(200, 181);
            txtSyntax.TabIndex = 18;
            txtSyntax.Text = "";
            txtSyntax.WordWrap = false;
            // 
            // txtLines
            // 
            txtLines.BorderStyle = BorderStyle.None;
            txtLines.Cursor = Cursors.NoMoveHoriz;
            txtLines.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLines.Location = new Point(354, 103);
            txtLines.Name = "txtLines";
            txtLines.ReadOnly = true;
            txtLines.ScrollBars = RichTextBoxScrollBars.None;
            txtLines.Size = new Size(47, 387);
            txtLines.TabIndex = 19;
            txtLines.Text = "";
            txtLines.WordWrap = false;
            txtLines.MouseDown += txtLines_MouseDown;
            // 
            // lblSourceCode
            // 
            lblSourceCode.AutoSize = true;
            lblSourceCode.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSourceCode.Location = new Point(399, 81);
            lblSourceCode.Name = "lblSourceCode";
            lblSourceCode.Size = new Size(126, 19);
            lblSourceCode.TabIndex = 20;
            lblSourceCode.Text = "Código Fuente";
            // 
            // lblLexerOutput
            // 
            lblLexerOutput.AutoSize = true;
            lblLexerOutput.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLexerOutput.Location = new Point(605, 81);
            lblLexerOutput.Name = "lblLexerOutput";
            lblLexerOutput.Size = new Size(162, 19);
            lblLexerOutput.TabIndex = 21;
            lblLexerOutput.Text = "Analizador Léxico";
            // 
            // lblSyntaxOutput
            // 
            lblSyntaxOutput.AutoSize = true;
            lblSyntaxOutput.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSyntaxOutput.Location = new Point(605, 287);
            lblSyntaxOutput.Name = "lblSyntaxOutput";
            lblSyntaxOutput.Size = new Size(198, 19);
            lblSyntaxOutput.TabIndex = 22;
            lblSyntaxOutput.Text = "Analizador Sintáctico";
            // 
            // picLogoQuring
            // 
            picLogoQuring.Image = Properties.Resources.quring;
            picLogoQuring.Location = new Point(591, 12);
            picLogoQuring.Name = "picLogoQuring";
            picLogoQuring.Size = new Size(233, 49);
            picLogoQuring.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoQuring.TabIndex = 23;
            picLogoQuring.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 87);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 24;
            label1.Text = "Líneas";
            // 
            // dtgTriplets
            // 
            dtgTriplets.AllowUserToAddRows = false;
            dtgTriplets.AllowUserToDeleteRows = false;
            dtgTriplets.AllowUserToOrderColumns = true;
            dtgTriplets.AllowUserToResizeColumns = false;
            dtgTriplets.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgTriplets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgTriplets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTriplets.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dtgTriplets.DefaultCellStyle = dataGridViewCellStyle9;
            dtgTriplets.Location = new Point(850, 515);
            dtgTriplets.Name = "dtgTriplets";
            dtgTriplets.ReadOnly = true;
            dtgTriplets.RowHeadersVisible = false;
            dtgTriplets.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgTriplets.RowTemplate.Height = 25;
            dtgTriplets.Size = new Size(363, 150);
            dtgTriplets.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn1.HeaderText = "Dato Objeto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Dato Fuente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Operador";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // txtEnsamblador
            // 
            txtEnsamblador.BackColor = SystemColors.Control;
            txtEnsamblador.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnsamblador.Location = new Point(1017, 103);
            txtEnsamblador.Name = "txtEnsamblador";
            txtEnsamblador.ReadOnly = true;
            txtEnsamblador.Size = new Size(200, 387);
            txtEnsamblador.TabIndex = 26;
            txtEnsamblador.Text = "";
            txtEnsamblador.WordWrap = false;
            // 
            // txtPostOrden
            // 
            txtPostOrden.BackColor = SystemColors.Control;
            txtPostOrden.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostOrden.Location = new Point(811, 103);
            txtPostOrden.Name = "txtPostOrden";
            txtPostOrden.ReadOnly = true;
            txtPostOrden.Size = new Size(200, 387);
            txtPostOrden.TabIndex = 27;
            txtPostOrden.Text = "";
            txtPostOrden.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(811, 81);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 28;
            label2.Text = "Postorden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1017, 81);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 29;
            label3.Text = "Ensamblador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(849, 493);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 30;
            label4.Text = "Triplos";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1225, 673);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPostOrden);
            Controls.Add(txtEnsamblador);
            Controls.Add(dtgTriplets);
            Controls.Add(label1);
            Controls.Add(picLogoQuring);
            Controls.Add(lblSyntaxOutput);
            Controls.Add(lblLexerOutput);
            Controls.Add(lblSourceCode);
            Controls.Add(txtLines);
            Controls.Add(txtSyntax);
            Controls.Add(txtLexer);
            Controls.Add(txtSourceCode);
            Controls.Add(lblSymbols);
            Controls.Add(dtgSymbols);
            Controls.Add(lblErrors);
            Controls.Add(lblSyntax);
            Controls.Add(lblLexer);
            Controls.Add(dtgErrors);
            Controls.Add(dtgGrammars);
            Controls.Add(btnCompile);
            Controls.Add(dtgLexer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quring Compiler";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLexer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGrammars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgErrors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbols).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogoQuring).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTriplets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgLexer;
        private Button btnCompile;
        private DataGridView dtgGrammars;
        private DataGridView dtgErrors;
        private Label lblLexer;
        private Label lblSyntax;
        private Label lblErrors;
        private DataGridView dtgSymbols;
        private Label lblSymbols;
        private RichTextBox txtSourceCode;
        private RichTextBox txtLexer;
        private RichTextBox txtSyntax;
        private RichTextBox txtLines;
        private Label lblSourceCode;
        private Label lblLexerOutput;
        private Label lblSyntaxOutput;
        private PictureBox picLogoQuring;
        private Label label1;
        private DataGridViewTextBoxColumn lineaError;
        private DataGridViewTextBoxColumn tipoError;
        private DataGridViewTextBoxColumn mensajeError;
        private DataGridViewTextBoxColumn lineSimbolo;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn nombreToken;
        private DataGridViewTextBoxColumn valor;
        private DataGridView dtgTriplets;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private RichTextBox txtEnsamblador;
        private RichTextBox txtPostOrden;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}