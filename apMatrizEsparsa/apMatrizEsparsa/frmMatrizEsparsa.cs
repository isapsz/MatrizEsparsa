using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apMatrizEsparsa
{
    public partial class frmMatrizEsparsa : Form
    {
        public frmMatrizEsparsa()
        {
            InitializeComponent();
        }

        ListaCircular matriz;

        private void frmMatrizEsparsa_Load(object sender, EventArgs e)
        {
            matriz = new ListaCircular(3, 3);
            matriz.InserirElemento(3, 1, 1);
            matriz.InserirElemento(4, 0, 2);
            matriz.InserirElemento(5, 2, 1);
            matriz.InserirElemento(6, 1, 0);
            for (int i = 0; i <= 3; i++)
                for (int c = 0; c <= 3; c++)
                    dgvExibicao.Rows[i].Cells[c].Value = matriz.ValorDe(i, c);
        }
    }
}
