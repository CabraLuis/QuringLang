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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            dtgLexer = new DataGridView();
            btnCompile = new Button();
            btnClean = new Button();
            dtgSymbolTable = new DataGridView();
            dtgErrors = new DataGridView();
            lblLexer = new Label();
            lblSyntax = new Label();
            lblErrors = new Label();
            dtgSymbols = new DataGridView();
            tipo = new DataGridViewTextBoxColumn();
            token = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dtgLexer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbolTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgErrors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogoQuring).BeginInit();
            SuspendLayout();
            // 
            // dtgLexer
            // 
            dtgLexer.AllowUserToAddRows = false;
            dtgLexer.AllowUserToDeleteRows = false;
            dtgLexer.AllowUserToResizeColumns = false;
            dtgLexer.AllowUserToResizeRows = false;
            dtgLexer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLexer.ColumnHeadersVisible = false;
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
            btnCompile.Cursor = Cursors.Hand;
            btnCompile.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompile.Location = new Point(498, 12);
            btnCompile.Name = "btnCompile";
            btnCompile.Size = new Size(336, 49);
            btnCompile.TabIndex = 2;
            btnCompile.Text = "Compilar";
            btnCompile.UseVisualStyleBackColor = true;
            btnCompile.Click += btnCompile_Click;
            // 
            // btnClean
            // 
            btnClean.Cursor = Cursors.Hand;
            btnClean.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClean.Location = new Point(991, 12);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(336, 49);
            btnClean.TabIndex = 3;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            // 
            // dtgSymbolTable
            // 
            dtgSymbolTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSymbolTable.Location = new Point(12, 318);
            dtgSymbolTable.Name = "dtgSymbolTable";
            dtgSymbolTable.ReadOnly = true;
            dtgSymbolTable.RowHeadersVisible = false;
            dtgSymbolTable.RowTemplate.Height = 25;
            dtgSymbolTable.Size = new Size(336, 172);
            dtgSymbolTable.TabIndex = 5;
            // 
            // dtgErrors
            // 
            dtgErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgErrors.Location = new Point(12, 515);
            dtgErrors.Name = "dtgErrors";
            dtgErrors.ReadOnly = true;
            dtgErrors.RowHeadersVisible = false;
            dtgErrors.RowTemplate.Height = 25;
            dtgErrors.Size = new Size(543, 150);
            dtgErrors.TabIndex = 8;
            // 
            // lblLexer
            // 
            lblLexer.AutoSize = true;
            lblLexer.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLexer.Location = new Point(12, 81);
            lblLexer.Name = "lblLexer";
            lblLexer.Size = new Size(162, 19);
            lblLexer.TabIndex = 9;
            lblLexer.Text = "Matriz Para Lexer";
            // 
            // lblSyntax
            // 
            lblSyntax.AutoSize = true;
            lblSyntax.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSyntax.Location = new Point(12, 296);
            lblSyntax.Name = "lblSyntax";
            lblSyntax.Size = new Size(198, 19);
            lblSyntax.TabIndex = 10;
            lblSyntax.Text = "Matriz Para Grámatica";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgSymbols.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgSymbols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSymbols.Columns.AddRange(new DataGridViewColumn[] { tipo, token, valor });
            dtgSymbols.Location = new Point(561, 515);
            dtgSymbols.Name = "dtgSymbols";
            dtgSymbols.ReadOnly = true;
            dtgSymbols.RowHeadersVisible = false;
            dtgSymbols.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgSymbols.RowTemplate.Height = 25;
            dtgSymbols.Size = new Size(766, 150);
            dtgSymbols.TabIndex = 13;
            // 
            // tipo
            // 
            tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // token
            // 
            token.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            token.HeaderText = "Token";
            token.Name = "token";
            token.ReadOnly = true;
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
            txtSourceCode.Size = new Size(322, 387);
            txtSourceCode.TabIndex = 16;
            txtSourceCode.Text = "";
            txtSourceCode.TextChanged += txtSourceCode_TextChanged;
            // 
            // txtLexer
            // 
            txtLexer.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLexer.Location = new Point(727, 103);
            txtLexer.Name = "txtLexer";
            txtLexer.ReadOnly = true;
            txtLexer.Size = new Size(297, 387);
            txtLexer.TabIndex = 17;
            txtLexer.Text = "";
            // 
            // txtSyntax
            // 
            txtSyntax.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSyntax.Location = new Point(1030, 103);
            txtSyntax.Name = "txtSyntax";
            txtSyntax.ReadOnly = true;
            txtSyntax.Size = new Size(297, 387);
            txtSyntax.TabIndex = 18;
            txtSyntax.Text = "";
            // 
            // txtLines
            // 
            txtLines.BorderStyle = BorderStyle.None;
            txtLines.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLines.Location = new Point(354, 103);
            txtLines.Name = "txtLines";
            txtLines.ReadOnly = true;
            txtLines.Size = new Size(47, 387);
            txtLines.TabIndex = 19;
            txtLines.Text = "";
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
            lblLexerOutput.Location = new Point(727, 81);
            lblLexerOutput.Name = "lblLexerOutput";
            lblLexerOutput.Size = new Size(162, 19);
            lblLexerOutput.TabIndex = 21;
            lblLexerOutput.Text = "Analizador Léxico";
            // 
            // lblSyntaxOutput
            // 
            lblSyntaxOutput.AutoSize = true;
            lblSyntaxOutput.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSyntaxOutput.Location = new Point(1030, 81);
            lblSyntaxOutput.Name = "lblSyntaxOutput";
            lblSyntaxOutput.Size = new Size(198, 19);
            lblSyntaxOutput.TabIndex = 22;
            lblSyntaxOutput.Text = "Analizador Sintáctico";
            // 
            // picLogoQuring
            // 
            picLogoQuring.Image = Properties.Resources.quring;
            picLogoQuring.Location = new Point(12, 12);
            picLogoQuring.Name = "picLogoQuring";
            picLogoQuring.Size = new Size(233, 49);
            picLogoQuring.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoQuring.TabIndex = 23;
            picLogoQuring.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 692);
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
            Controls.Add(dtgSymbolTable);
            Controls.Add(btnClean);
            Controls.Add(btnCompile);
            Controls.Add(dtgLexer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quring Compiler";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLexer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbolTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgErrors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSymbols).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogoQuring).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgLexer;
        private Button btnCompile;
        private Button btnClean;
        private DataGridView dtgSymbolTable;
        private DataGridView dtgErrors;
        private Label lblLexer;
        private Label lblSyntax;
        private Label lblErrors;
        private DataGridView dtgSymbols;
        private Label lblSymbols;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn token;
        private DataGridViewTextBoxColumn valor;
        private RichTextBox txtSourceCode;
        private RichTextBox txtLexer;
        private RichTextBox txtSyntax;
        private RichTextBox txtLines;
        private Label lblSourceCode;
        private Label lblLexerOutput;
        private Label lblSyntaxOutput;
        private PictureBox picLogoQuring;
    }
}