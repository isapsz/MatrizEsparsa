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
            this.dgvExibicao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExibicao
            // 
            this.dgvExibicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao.Location = new System.Drawing.Point(12, 12);
            this.dgvExibicao.Name = "dgvExibicao";
            this.dgvExibicao.Size = new System.Drawing.Size(240, 150);
            this.dgvExibicao.TabIndex = 0;
            // 
            // frmMatrizEsparsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.Controls.Add(this.dgvExibicao);
            this.Name = "frmMatrizEsparsa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMatrizEsparsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExibicao;
    }
}

