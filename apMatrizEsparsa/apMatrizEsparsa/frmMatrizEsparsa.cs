using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            LerArquivo(ref matriz);
            matriz = new ListaCircular(4, 3);
            matriz.InserirElemento(3, 2, 1);
            matriz.InserirElemento(4, 1, 1);
            matriz.InserirElemento(3, 3, 1);
            matriz.InserirElemento(15, 2, 0);
            textBox2.Text = matriz.ValorDe(2, 0).ToString();
            matriz.Exibir(dgvExibicao1);
            matriz.RemoverElemento(1, 1);
            matriz.RemoverElemento(2, 1);
            matriz.Exibir(dgvExibicao1);
        }

        private void LerArquivo(ref ListaCircular lista)
        {
            if (dlgArquivo.ShowDialog() == DialogResult.OK)
            {
                StreamReader arq = new StreamReader(dlgArquivo.FileName);
                while (!arq.EndOfStream)
                {
                    string linha;
                    lista = new ListaCircular(int.Parse(arq.ReadLine()), int.Parse(arq.ReadLine()));

                    for (int l = 0; l < lista.TamanhoLinhas; l++)
                    {
                        linha = arq.ReadLine();
                        string[] vetorValores = linha.Split(',');

                        for (int c = 0; c < lista.TamanhoColunas; c++)
                        {
                            lista.InserirElemento(int.Parse(vetorValores[c]), 
                                                  int.Parse(vetorValores[c + 1]), 
                                                  int.Parse(vetorValores[c + 2]));
                        }
                    }
                        
                }
            }

        }
    }
}
