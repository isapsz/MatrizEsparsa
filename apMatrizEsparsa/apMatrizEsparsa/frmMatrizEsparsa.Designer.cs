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
            this.dvgExibicao2 = new System.Windows.Forms.DataGridView();
            this.btnLerMatriz2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExibirInfo = new System.Windows.Forms.Button();
            this.grbAcesso = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.dlgArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgExibicao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.grbAcesso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExibicao1
            // 
            this.dgvExibicao1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao1.Location = new System.Drawing.Point(12, 53);
            this.dgvExibicao1.Name = "dgvExibicao1";
            this.dgvExibicao1.Size = new System.Drawing.Size(240, 150);
            this.dgvExibicao1.TabIndex = 0;
            // 
            // btnLerMatriz1
            // 
            this.btnLerMatriz1.Location = new System.Drawing.Point(87, 12);
            this.btnLerMatriz1.Name = "btnLerMatriz1";
            this.btnLerMatriz1.Size = new System.Drawing.Size(75, 23);
            this.btnLerMatriz1.TabIndex = 1;
            this.btnLerMatriz1.Text = "Ler Matriz 1";
            this.btnLerMatriz1.UseVisualStyleBackColor = true;
            // 
            // dvgExibicao2
            // 
            this.dvgExibicao2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgExibicao2.Location = new System.Drawing.Point(297, 53);
            this.dvgExibicao2.Name = "dvgExibicao2";
            this.dvgExibicao2.Size = new System.Drawing.Size(240, 150);
            this.dvgExibicao2.TabIndex = 2;
            // 
            // btnLerMatriz2
            // 
            this.btnLerMatriz2.Location = new System.Drawing.Point(381, 12);
            this.btnLerMatriz2.Name = "btnLerMatriz2";
            this.btnLerMatriz2.Size = new System.Drawing.Size(75, 23);
            this.btnLerMatriz2.TabIndex = 3;
            this.btnLerMatriz2.Text = "Ler Matriz 2";
            this.btnLerMatriz2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Linha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coluna: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(82, 66);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informação:";
            // 
            // btnExibirInfo
            // 
            this.btnExibirInfo.Location = new System.Drawing.Point(16, 157);
            this.btnExibirInfo.Name = "btnExibirInfo";
            this.btnExibirInfo.Size = new System.Drawing.Size(75, 23);
            this.btnExibirInfo.TabIndex = 10;
            this.btnExibirInfo.Text = "Exibir Info";
            this.btnExibirInfo.UseVisualStyleBackColor = true;
            // 
            // grbAcesso
            // 
            this.grbAcesso.Controls.Add(this.btnExibirInfo);
            this.grbAcesso.Controls.Add(this.label3);
            this.grbAcesso.Controls.Add(this.label1);
            this.grbAcesso.Controls.Add(this.numericUpDown1);
            this.grbAcesso.Controls.Add(this.label2);
            this.grbAcesso.Controls.Add(this.textBox1);
            this.grbAcesso.Controls.Add(this.numericUpDown2);
            this.grbAcesso.Location = new System.Drawing.Point(616, 12);
            this.grbAcesso.Name = "grbAcesso";
            this.grbAcesso.Size = new System.Drawing.Size(200, 203);
            this.grbAcesso.TabIndex = 11;
            this.grbAcesso.TabStop = false;
            this.grbAcesso.Text = "Acesso";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 203);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Multiplicar pela constante";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Constante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Linha: ";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(82, 29);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coluna: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(82, 66);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown4.TabIndex = 7;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAcesso);
            this.Controls.Add(this.btnLerMatriz2);
            this.Controls.Add(this.dvgExibicao2);
            this.Controls.Add(this.btnLerMatriz1);
            this.Controls.Add(this.dgvExibicao1);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMatrizEsparsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgExibicao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.grbAcesso.ResumeLayout(false);
            this.grbAcesso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExibicao1;
        private System.Windows.Forms.Button btnLerMatriz1;
        private System.Windows.Forms.DataGridView dvgExibicao2;
        private System.Windows.Forms.Button btnLerMatriz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExibirInfo;
        private System.Windows.Forms.GroupBox grbAcesso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.OpenFileDialog dlgArquivo;
    }
}

