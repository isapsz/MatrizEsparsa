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
            matriz = new ListaCircular(4, 3);
            matriz.InserirElemento(3, 2, 1);
            matriz.InserirElemento(4, 1, 1);
            matriz.InserirElemento(3, 3, 1);
            matriz.InserirElemento(15, 2, 0);
            textBox2.Text = matriz.ValorDe(2,0).ToString();
            matriz.Exibir(dgvExibicao1);
        }
    }
}
