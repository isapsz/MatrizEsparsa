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
            this.btnExibirInfo = new System.Windows.Forms.Button();
            this.grbAcesso = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.ndColunaSoma = new System.Windows.Forms.NumericUpDown();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExibirInfo2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ndLinhaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.ndColunaMatriz2 = new System.Windows.Forms.NumericUpDown();
            this.btnSomarK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSomaMatriz2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.ndColunaSomaMatriz2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColuna)).BeginInit();
            this.grbAcesso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinhaMatriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaMatriz2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaSomaMatriz2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExibicao1
            // 
            this.dgvExibicao1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao1.ColumnHeadersVisible = false;
            this.dgvExibicao1.Location = new System.Drawing.Point(20, 86);
            this.dgvExibicao1.Margin = new System.Windows.Forms.Padding(5);
            this.dgvExibicao1.Name = "dgvExibicao1";
            this.dgvExibicao1.RowHeadersVisible = false;
            this.dgvExibicao1.Size = new System.Drawing.Size(400, 242);
            this.dgvExibicao1.TabIndex = 0;
            // 
            // btnLerMatriz1
            // 
            this.btnLerMatriz1.Location = new System.Drawing.Point(157, 19);
            this.btnLerMatriz1.Margin = new System.Windows.Forms.Padding(5);
            this.btnLerMatriz1.Name = "btnLerMatriz1";
            this.btnLerMatriz1.Size = new System.Drawing.Size(125, 37);
            this.btnLerMatriz1.TabIndex = 1;
            this.btnLerMatriz1.Text = "Ler Matriz 1";
            this.btnLerMatriz1.UseVisualStyleBackColor = true;
            this.btnLerMatriz1.Click += new System.EventHandler(this.btnLerMatriz1_Click);
            // 
            // dgvExibicao2
            // 
            this.dgvExibicao2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao2.ColumnHeadersVisible = false;
            this.dgvExibicao2.Location = new System.Drawing.Point(495, 86);
            this.dgvExibicao2.Margin = new System.Windows.Forms.Padding(5);
            this.dgvExibicao2.Name = "dgvExibicao2";
            this.dgvExibicao2.RowHeadersVisible = false;
            this.dgvExibicao2.Size = new System.Drawing.Size(400, 242);
            this.dgvExibicao2.TabIndex = 2;
            this.dgvExibicao2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExibicao2_CellContentClick);
            // 
            // btnLerMatriz2
            // 
            this.btnLerMatriz2.Location = new System.Drawing.Point(635, 19);
            this.btnLerMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.btnLerMatriz2.Name = "btnLerMatriz2";
            this.btnLerMatriz2.Size = new System.Drawing.Size(125, 37);
            this.btnLerMatriz2.TabIndex = 3;
            this.btnLerMatriz2.Text = "Ler Matriz 2";
            this.btnLerMatriz2.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(22, 67);
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
            this.txtValor1.ReadOnly = true;
            this.txtValor1.Size = new System.Drawing.Size(164, 27);
            this.txtValor1.TabIndex = 8;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(22, 102);
            this.lbValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(54, 21);
            this.lbValor.TabIndex = 9;
            this.lbValor.Text = "Valor:";
            // 
            // btnExibirInfo
            // 
            this.btnExibirInfo.Location = new System.Drawing.Point(26, 143);
            this.btnExibirInfo.Margin = new System.Windows.Forms.Padding(5);
            this.btnExibirInfo.Name = "btnExibirInfo";
            this.btnExibirInfo.Size = new System.Drawing.Size(275, 37);
            this.btnExibirInfo.TabIndex = 10;
            this.btnExibirInfo.Text = "Procurar valor";
            this.btnExibirInfo.UseVisualStyleBackColor = true;
            this.btnExibirInfo.Click += new System.EventHandler(this.btnExibirInfo_Click);
            // 
            // grbAcesso
            // 
            this.grbAcesso.Controls.Add(this.btnExibirInfo);
            this.grbAcesso.Controls.Add(this.lbValor);
            this.grbAcesso.Controls.Add(this.label1);
            this.grbAcesso.Controls.Add(this.ndLinha);
            this.grbAcesso.Controls.Add(this.label2);
            this.grbAcesso.Controls.Add(this.txtValor1);
            this.grbAcesso.Controls.Add(this.ndColuna);
            this.grbAcesso.Location = new System.Drawing.Point(1027, 19);
            this.grbAcesso.Margin = new System.Windows.Forms.Padding(5);
            this.grbAcesso.Name = "grbAcesso";
            this.grbAcesso.Padding = new System.Windows.Forms.Padding(5);
            this.grbAcesso.Size = new System.Drawing.Size(333, 199);
            this.grbAcesso.TabIndex = 11;
            this.grbAcesso.TabStop = false;
            this.grbAcesso.Text = "Procurar Valor na Matriz 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSomarK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.ndColunaSoma);
            this.groupBox1.Location = new System.Drawing.Point(20, 373);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Somar Constante na Matriz 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Constante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coluna: ";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(137, 109);
            this.txtK.Margin = new System.Windows.Forms.Padding(5);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(164, 27);
            this.txtK.TabIndex = 8;
            // 
            // ndColunaSoma
            // 
            this.ndColunaSoma.Location = new System.Drawing.Point(137, 54);
            this.ndColunaSoma.Margin = new System.Windows.Forms.Padding(5);
            this.ndColunaSoma.Name = "ndColunaSoma";
            this.ndColunaSoma.Size = new System.Drawing.Size(133, 27);
            this.ndColunaSoma.TabIndex = 7;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(495, 373);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(5);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(400, 242);
            this.dgvResultado.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExibirInfo2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ndLinhaMatriz2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValor2);
            this.groupBox2.Controls.Add(this.ndColunaMatriz2);
            this.groupBox2.Location = new System.Drawing.Point(1027, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(333, 199);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procurar Valor na Matriz 1:";
            // 
            // btnExibirInfo2
            // 
            this.btnExibirInfo2.Location = new System.Drawing.Point(26, 143);
            this.btnExibirInfo2.Margin = new System.Windows.Forms.Padding(5);
            this.btnExibirInfo2.Name = "btnExibirInfo2";
            this.btnExibirInfo2.Size = new System.Drawing.Size(275, 37);
            this.btnExibirInfo2.TabIndex = 10;
            this.btnExibirInfo2.Text = "Procurar valor";
            this.btnExibirInfo2.UseVisualStyleBackColor = true;
            this.btnExibirInfo2.Click += new System.EventHandler(this.btnExibirInfo2_Click);
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
            this.label8.Location = new System.Drawing.Point(22, 67);
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
            this.txtValor2.ReadOnly = true;
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
            // btnSomarK
            // 
            this.btnSomarK.Location = new System.Drawing.Point(27, 166);
            this.btnSomarK.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomarK.Name = "btnSomarK";
            this.btnSomarK.Size = new System.Drawing.Size(274, 37);
            this.btnSomarK.TabIndex = 10;
            this.btnSomarK.Text = "Somar Constante";
            this.btnSomarK.UseVisualStyleBackColor = true;
            this.btnSomarK.Click += new System.EventHandler(this.btnSomarK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSomaMatriz2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtK2);
            this.groupBox3.Controls.Add(this.ndColunaSomaMatriz2);
            this.groupBox3.Location = new System.Drawing.Point(20, 626);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(333, 216);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Somar Constante na Matriz 2";
            // 
            // btnSomaMatriz2
            // 
            this.btnSomaMatriz2.Location = new System.Drawing.Point(27, 166);
            this.btnSomaMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSomaMatriz2.Name = "btnSomaMatriz2";
            this.btnSomaMatriz2.Size = new System.Drawing.Size(274, 37);
            this.btnSomaMatriz2.TabIndex = 10;
            this.btnSomaMatriz2.Text = "Somar Constante";
            this.btnSomaMatriz2.UseVisualStyleBackColor = true;
            this.btnSomaMatriz2.Click += new System.EventHandler(this.btnSomaMatriz2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Coluna: ";
            // 
            // txtK2
            // 
            this.txtK2.Location = new System.Drawing.Point(137, 109);
            this.txtK2.Margin = new System.Windows.Forms.Padding(5);
            this.txtK2.Name = "txtK2";
            this.txtK2.Size = new System.Drawing.Size(164, 27);
            this.txtK2.TabIndex = 8;
            // 
            // ndColunaSomaMatriz2
            // 
            this.ndColunaSomaMatriz2.Location = new System.Drawing.Point(137, 54);
            this.ndColunaSomaMatriz2.Margin = new System.Windows.Forms.Padding(5);
            this.ndColunaSomaMatriz2.Name = "ndColunaSomaMatriz2";
            this.ndColunaSomaMatriz2.Size = new System.Drawing.Size(133, 27);
            this.ndColunaSomaMatriz2.TabIndex = 7;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 856);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAcesso);
            this.Controls.Add(this.btnLerMatriz2);
            this.Controls.Add(this.dgvExibicao2);
            this.Controls.Add(this.btnLerMatriz1);
            this.Controls.Add(this.dgvExibicao1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMatrizEsparsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColuna)).EndInit();
            this.grbAcesso.ResumeLayout(false);
            this.grbAcesso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndLinhaMatriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaMatriz2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndColunaSomaMatriz2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExibicao1;
        private System.Windows.Forms.Button btnLerMatriz1;
        private System.Windows.Forms.DataGridView dgvExibicao2;
        private System.Windows.Forms.Button btnLerMatriz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ndLinha;
        private System.Windows.Forms.NumericUpDown ndColuna;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btnExibirInfo;
        private System.Windows.Forms.GroupBox grbAcesso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.NumericUpDown ndColunaSoma;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExibirInfo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ndLinhaMatriz2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.NumericUpDown ndColunaMatriz2;
        private System.Windows.Forms.Button btnSomarK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSomaMatriz2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtK2;
        private System.Windows.Forms.NumericUpDown ndColunaSomaMatriz2;
    }
}

