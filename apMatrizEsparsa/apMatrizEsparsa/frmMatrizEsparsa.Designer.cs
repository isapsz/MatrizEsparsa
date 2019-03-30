namespace apMatrizEsparsa
{
    partial class frmMatrizEsparsa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvExibicao1 = new System.Windows.Forms.DataGridView();
            this.btnLerMatriz1 = new System.Windows.Forms.Button();
            this.dgvExibicao2 = new System.Windows.Forms.DataGridView();
            this.btnLerMatriz2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ndLinha = new System.Windows.Forms.NumericUpDown();
            this.ndColuna = new System.Windows.Forms.NumericUpDown();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.grbAcesso = new System.Windows.Forms.GroupBox();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.btnZerar1 = new System.Windows.Forms.Button();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSomaMatriz2 = new System.Windows.Forms.Button();
            this.btnZerar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ndLinhaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.ndColunaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMultiplicarMatrizes = new System.Windows.Forms.Button();
            this.btnSomarMatrizes = new System.Windows.Forms.Button();
            this.btnExibirInfo2 = new System.Windows.Forms.Button();
            this.btnExibirInfo = new System.Windows.Forms.Button();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMatriz = new System.Windows.Forms.Label();
            this.lblMatriz2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColuna)).BeginInit();
            this.grbAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinhaMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaMatriz2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExibicao1
            // 
            this.dgvExibicao1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao1.ColumnHeadersVisible = false;
            this.dgvExibicao1.Location = new System.Drawing.Point(20, 77);
            this.dgvExibicao1.Margin = new System.Windows.Forms.Padding(5);
            this.dgvExibicao1.Name = "dgvExibicao1";
            this.dgvExibicao1.RowHeadersVisible = false;
            this.dgvExibicao1.Size = new System.Drawing.Size(400, 242);
            this.dgvExibicao1.TabIndex = 0;
            // 
            // btnLerMatriz1
            // 
            this.btnLerMatriz1.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLerMatriz1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerMatriz1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnLerMatriz1.FlatAppearance.BorderSize = 3;
            this.btnLerMatriz1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnLerMatriz1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLerMatriz1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnLerMatriz1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLerMatriz1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerMatriz1.ForeColor = System.Drawing.Color.White;
            this.btnLerMatriz1.Location = new System.Drawing.Point(430, 357);
            this.btnLerMatriz1.Margin = new System.Windows.Forms.Padding(5);
            this.btnLerMatriz1.Name = "btnLerMatriz1";
            this.btnLerMatriz1.Size = new System.Drawing.Size(188, 39);
            this.btnLerMatriz1.TabIndex = 1;
            this.btnLerMatriz1.Text = "Ler Matriz 1";
            this.btnLerMatriz1.UseVisualStyleBackColor = false;
            this.btnLerMatriz1.Click += new System.EventHandler(this.btnLerMatriz1_Click);
            // 
            // dgvExibicao2
            // 
            this.dgvExibicao2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao2.ColumnHeadersVisible = false;
            this.dgvExibicao2.Location = new System.Drawing.Point(430, 77);
            this.dgvExibicao2.Margin = new System.Windows.Forms.Padding(5);
            this.dgvExibicao2.Name = "dgvExibicao2";
            this.dgvExibicao2.RowHeadersVisible = false;
            this.dgvExibicao2.Size = new System.Drawing.Size(400, 242);
            this.dgvExibicao2.TabIndex = 2;
            this.dgvExibicao2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExibicao2_CellContentClick);
            // 
            // btnLerMatriz2
            // 
            this.btnLerMatriz2.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLerMatriz2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerMatriz2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnLerMatriz2.FlatAppearance.BorderSize = 3;
            this.btnLerMatriz2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnLerMatriz2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLerMatriz2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnLerMatriz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLerMatriz2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLerMatriz2.ForeColor = System.Drawing.Color.White;
            this.btnLerMatriz2.Location = new System.Drawing.Point(642, 357);
            this.btnLerMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.btnLerMatriz2.Name = "btnLerMatriz2";
            this.btnLerMatriz2.Size = new System.Drawing.Size(188, 39);
            this.btnLerMatriz2.TabIndex = 3;
            this.btnLerMatriz2.Text = "Ler Matriz 2";
            this.btnLerMatriz2.UseVisualStyleBackColor = false;
            this.btnLerMatriz2.Click += new System.EventHandler(this.btnLerMatriz2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Linha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coluna: ";
            // 
            // ndLinha
            // 
            this.ndLinha.Location = new System.Drawing.Point(137, 32);
            this.ndLinha.Margin = new System.Windows.Forms.Padding(5);
            this.ndLinha.Name = "ndLinha";
            this.ndLinha.Size = new System.Drawing.Size(133, 27);
            this.ndLinha.TabIndex = 6;
            // 
            // ndColuna
            // 
            this.ndColuna.Location = new System.Drawing.Point(137, 69);
            this.ndColuna.Margin = new System.Windows.Forms.Padding(5);
            this.ndColuna.Name = "ndColuna";
            this.ndColuna.Size = new System.Drawing.Size(133, 27);
            this.ndColuna.TabIndex = 7;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(137, 106);
            this.txtValor1.Margin = new System.Windows.Forms.Padding(5);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(164, 27);
            this.txtValor1.TabIndex = 8;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(22, 108);
            this.lbValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(54, 21);
            this.lbValor.TabIndex = 9;
            this.lbValor.Text = "Valor:";
            // 
            // grbAcesso
            // 
            this.grbAcesso.Controls.Add(this.btnSomarK);
            this.grbAcesso.Controls.Add(this.btnExibirInfo);
            this.grbAcesso.Controls.Add(this.btnZerar1);
            this.grbAcesso.Controls.Add(this.lbValor);
            this.grbAcesso.Controls.Add(this.label1);
            this.grbAcesso.Controls.Add(this.ndLinha);
            this.grbAcesso.Controls.Add(this.label2);
            this.grbAcesso.Controls.Add(this.txtValor1);
            this.grbAcesso.Controls.Add(this.ndColuna);
            this.grbAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAcesso.Location = new System.Drawing.Point(848, 66);
            this.grbAcesso.Margin = new System.Windows.Forms.Padding(5);
            this.grbAcesso.Name = "grbAcesso";
            this.grbAcesso.Padding = new System.Windows.Forms.Padding(5);
            this.grbAcesso.Size = new System.Drawing.Size(333, 242);
            this.grbAcesso.TabIndex = 11;
            this.grbAcesso.TabStop = false;
            this.grbAcesso.Text = "Matriz 1:";
            // 
            // btnSomarK
            // 
            this.btnSomarK.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSomarK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomarK.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSomarK.FlatAppearance.BorderSize = 3;
            this.btnSomarK.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSomarK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSomarK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnSomarK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomarK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomarK.ForeColor = System.Drawing.Color.White;
            this.btnSomarK.Location = new System.Drawing.Point(27, 193);
            this.btnSomarK.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomarK.Name = "btnSomarK";
            this.btnSomarK.Size = new System.Drawing.Size(284, 38);
            this.btnSomarK.TabIndex = 11;
            this.btnSomarK.Text = "Somar Valor na Coluna";
            this.btnSomarK.UseVisualStyleBackColor = false;
            this.btnSomarK.Click += new System.EventHandler(this.btnSomarK_Click);
            // 
            // btnZerar1
            // 
            this.btnZerar1.BackColor = System.Drawing.Color.SlateBlue;
            this.btnZerar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZerar1.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnZerar1.FlatAppearance.BorderSize = 3;
            this.btnZerar1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnZerar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnZerar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnZerar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar1.ForeColor = System.Drawing.Color.White;
            this.btnZerar1.Location = new System.Drawing.Point(173, 143);
            this.btnZerar1.Name = "btnZerar1";
            this.btnZerar1.Size = new System.Drawing.Size(138, 38);
            this.btnZerar1.TabIndex = 14;
            this.btnZerar1.Text = "Limpar Matriz";
            this.btnZerar1.UseVisualStyleBackColor = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(14, 357);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(5);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(400, 242);
            this.dgvResultado.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSomaMatriz2);
            this.groupBox2.Controls.Add(this.btnZerar2);
            this.groupBox2.Controls.Add(this.btnExibirInfo2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ndLinhaMatriz2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValor2);
            this.groupBox2.Controls.Add(this.ndColunaMatriz2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(848, 357);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(333, 242);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matriz 2:";
            // 
            // btnSomaMatriz2
            // 
            this.btnSomaMatriz2.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSomaMatriz2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomaMatriz2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSomaMatriz2.FlatAppearance.BorderSize = 3;
            this.btnSomaMatriz2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSomaMatriz2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSomaMatriz2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnSomaMatriz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomaMatriz2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomaMatriz2.ForeColor = System.Drawing.Color.White;
            this.btnSomaMatriz2.Location = new System.Drawing.Point(27, 189);
            this.btnSomaMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomaMatriz2.Name = "btnSomaMatriz2";
            this.btnSomaMatriz2.Size = new System.Drawing.Size(284, 38);
            this.btnSomaMatriz2.TabIndex = 13;
            this.btnSomaMatriz2.Text = "Somar Valor na Coluna";
            this.btnSomaMatriz2.UseVisualStyleBackColor = false;
            this.btnSomaMatriz2.Click += new System.EventHandler(this.btnSomaMatriz2_Click);
            // 
            // btnZerar2
            // 
            this.btnZerar2.BackColor = System.Drawing.Color.SlateBlue;
            this.btnZerar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZerar2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnZerar2.FlatAppearance.BorderSize = 3;
            this.btnZerar2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnZerar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnZerar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnZerar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar2.ForeColor = System.Drawing.Color.White;
            this.btnZerar2.Location = new System.Drawing.Point(173, 143);
            this.btnZerar2.Name = "btnZerar2";
            this.btnZerar2.Size = new System.Drawing.Size(138, 38);
            this.btnZerar2.TabIndex = 15;
            this.btnZerar2.Text = "Limpar Matriz";
            this.btnZerar2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Linha: ";
            // 
            // ndLinhaMatriz2
            // 
            this.ndLinhaMatriz2.Location = new System.Drawing.Point(137, 32);
            this.ndLinhaMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.ndLinhaMatriz2.Name = "ndLinhaMatriz2";
            this.ndLinhaMatriz2.Size = new System.Drawing.Size(133, 27);
            this.ndLinhaMatriz2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Coluna: ";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(137, 106);
            this.txtValor2.Margin = new System.Windows.Forms.Padding(5);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(164, 27);
            this.txtValor2.TabIndex = 8;
            // 
            // ndColunaMatriz2
            // 
            this.ndColunaMatriz2.Location = new System.Drawing.Point(137, 69);
            this.ndColunaMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.ndColunaMatriz2.Name = "ndColunaMatriz2";
            this.ndColunaMatriz2.Size = new System.Drawing.Size(133, 27);
            this.ndColunaMatriz2.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnMultiplicarMatrizes);
            this.groupBox5.Controls.Add(this.btnSomarMatrizes);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(430, 406);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(400, 188);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operações com Matrizes";
            // 
            // btnMultiplicarMatrizes
            // 
            this.btnMultiplicarMatrizes.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMultiplicarMatrizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicarMatrizes.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnMultiplicarMatrizes.FlatAppearance.BorderSize = 3;
            this.btnMultiplicarMatrizes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnMultiplicarMatrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMultiplicarMatrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnMultiplicarMatrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicarMatrizes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicarMatrizes.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicarMatrizes.Location = new System.Drawing.Point(52, 55);
            this.btnMultiplicarMatrizes.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultiplicarMatrizes.Name = "btnMultiplicarMatrizes";
            this.btnMultiplicarMatrizes.Size = new System.Drawing.Size(284, 37);
            this.btnMultiplicarMatrizes.TabIndex = 11;
            this.btnMultiplicarMatrizes.Text = "Multiplicar Matrizes";
            this.btnMultiplicarMatrizes.UseVisualStyleBackColor = false;
            // 
            // btnSomarMatrizes
            // 
            this.btnSomarMatrizes.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSomarMatrizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSomarMatrizes.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnSomarMatrizes.FlatAppearance.BorderSize = 3;
            this.btnSomarMatrizes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSomarMatrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSomarMatrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnSomarMatrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomarMatrizes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomarMatrizes.ForeColor = System.Drawing.Color.White;
            this.btnSomarMatrizes.Location = new System.Drawing.Point(52, 111);
            this.btnSomarMatrizes.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomarMatrizes.Name = "btnSomarMatrizes";
            this.btnSomarMatrizes.Size = new System.Drawing.Size(284, 37);
            this.btnSomarMatrizes.TabIndex = 10;
            this.btnSomarMatrizes.Text = "Somar Matrizes";
            this.btnSomarMatrizes.UseVisualStyleBackColor = false;
            // 
            // btnExibirInfo2
            // 
            this.btnExibirInfo2.BackColor = System.Drawing.Color.SlateBlue;
            this.btnExibirInfo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirInfo2.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnExibirInfo2.FlatAppearance.BorderSize = 3;
            this.btnExibirInfo2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnExibirInfo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExibirInfo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnExibirInfo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirInfo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirInfo2.ForeColor = System.Drawing.Color.White;
            this.btnExibirInfo2.Location = new System.Drawing.Point(26, 143);
            this.btnExibirInfo2.Margin = new System.Windows.Forms.Padding(5);
            this.btnExibirInfo2.Name = "btnExibirInfo2";
            this.btnExibirInfo2.Size = new System.Drawing.Size(138, 38);
            this.btnExibirInfo2.TabIndex = 10;
            this.btnExibirInfo2.Text = "Procurar valor";
            this.btnExibirInfo2.UseVisualStyleBackColor = false;
            this.btnExibirInfo2.Click += new System.EventHandler(this.btnExibirInfo2_Click);
            // 
            // btnExibirInfo
            // 
            this.btnExibirInfo.BackColor = System.Drawing.Color.SlateBlue;
            this.btnExibirInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirInfo.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnExibirInfo.FlatAppearance.BorderSize = 3;
            this.btnExibirInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnExibirInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExibirInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnExibirInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirInfo.ForeColor = System.Drawing.Color.White;
            this.btnExibirInfo.Location = new System.Drawing.Point(26, 143);
            this.btnExibirInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btnExibirInfo.Name = "btnExibirInfo";
            this.btnExibirInfo.Size = new System.Drawing.Size(138, 38);
            this.btnExibirInfo.TabIndex = 10;
            this.btnExibirInfo.Text = "Procurar valor";
            this.btnExibirInfo.UseVisualStyleBackColor = false;
            this.btnExibirInfo.Click += new System.EventHandler(this.btnExibirInfo_Click);
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucoes.Location = new System.Drawing.Point(16, 9);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(101, 23);
            this.lblInstrucoes.TabIndex = 14;
            this.lblInstrucoes.Text = "Instruções";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resultado:";
            // 
            // lbMatriz
            // 
            this.lbMatriz.AutoSize = true;
            this.lbMatriz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatriz.Location = new System.Drawing.Point(16, 51);
            this.lbMatriz.Name = "lbMatriz";
            this.lbMatriz.Size = new System.Drawing.Size(0, 19);
            this.lbMatriz.TabIndex = 16;
            // 
            // lblMatriz2
            // 
            this.lblMatriz2.AutoSize = true;
            this.lblMatriz2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz2.Location = new System.Drawing.Point(426, 51);
            this.lblMatriz2.Name = "lblMatriz2";
            this.lblMatriz2.Size = new System.Drawing.Size(0, 19);
            this.lblMatriz2.TabIndex = 17;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1219, 614);
            this.Controls.Add(this.lblMatriz2);
            this.Controls.Add(this.lbMatriz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.grbAcesso);
            this.Controls.Add(this.btnLerMatriz2);
            this.Controls.Add(this.dgvExibicao2);
            this.Controls.Add(this.btnLerMatriz1);
            this.Controls.Add(this.dgvExibicao1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Matrizes Esparsas";
            this.Load += new System.EventHandler(this.frmMatrizEsparsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColuna)).EndInit();
            this.grbAcesso.ResumeLayout(false);
            this.grbAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinhaMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaMatriz2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExibicao1;
        private System.Windows.Forms.DataGridView dgvExibicao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndLinha;
        private System.Windows.Forms.NumericUpDown ndColuna;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.GroupBox grbAcesso;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ndLinhaMatriz2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.NumericUpDown ndColunaMatriz2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblInstrucoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMatriz;
        private System.Windows.Forms.Label lblMatriz2;
        private System.Windows.Forms.Button btnLerMatriz1;
        private System.Windows.Forms.Button btnLerMatriz2;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.Button btnExibirInfo;
        private System.Windows.Forms.Button btnZerar1;
        private System.Windows.Forms.Button btnSomaMatriz2;
        private System.Windows.Forms.Button btnZerar2;
        private System.Windows.Forms.Button btnExibirInfo2;
        private System.Windows.Forms.Button btnMultiplicarMatrizes;
        private System.Windows.Forms.Button btnSomarMatrizes;
    }
}

