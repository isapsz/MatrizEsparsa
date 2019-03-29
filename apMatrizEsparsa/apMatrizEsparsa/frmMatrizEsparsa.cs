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
        ListaCircular matrizSoma;

        private void frmMatrizEsparsa_Load(object sender, EventArgs e)
        {
            try
            {
                LerArquivo(ref matriz);
                LerArquivo(ref matrizSoma);
                textBox2.Text = matriz.ValorDe(2, 0).ToString();
                matriz.Exibir(dgvExibicao1);
                // matriz.SomarK(2, 2);
                matrizSoma.Exibir(dgvExibicao2);
                matriz.SomarMatrizes(matrizSoma).Exibir(dgvResultado);
                /*matriz.RemoverElemento(1, 1);
                matriz.RemoverElemento(2, 1);
                matriz.Exibir(dgvExibicao1);*/
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void LerArquivo(ref ListaCircular lista)
        {
            if (dlgArquivo.ShowDialog() == DialogResult.OK)
            {
                StreamReader arq = new StreamReader(dlgArquivo.FileName);

                string linha;

                if (!arq.EndOfStream)
                    lista = new ListaCircular(int.Parse(arq.ReadLine()), int.Parse(arq.ReadLine()));

                while (!arq.EndOfStream)
                {
                    linha = arq.ReadLine();
                    string[] vetorValores = linha.Split(',');

                    for (int i = 0; i < vetorValores.Length; i++)
                    {
                        lista.InserirElemento(int.Parse(vetorValores[i]),
                                              int.Parse(vetorValores[++i]),
                                              int.Parse(vetorValores[++i]));
                    }
                }


            }

        }
    }
}
