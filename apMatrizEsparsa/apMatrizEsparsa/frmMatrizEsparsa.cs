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
                lblInstrucoes.Text = "Para inserir um valor na matriz digite-o na tabela. " +
                                      "Para excluir substitua o valor que deseja apagar na tabela por 0.";
                //LerArquivo(ref matriz);
                //LerArquivo(ref matrizSoma);
                //textBox2.Text = matriz.ValorDe(2, 0).ToString();
                //matriz.Exibir(dgvExibicao1);
                // matriz.SomarK(2, 2);
                //matrizSoma.Exibir(dgvExibicao2);
                //matriz.MultiplicarMatrizes(matrizSoma).Exibir(dgvResultado);
                /*matriz.RemoverElemento(1, 1);
                matriz.RemoverElemento(2, 1);
                matriz.Exibir(dgvExibicao1);*/
            }
            catch (Exception erro)
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

        private void dgvExibicao2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExibirInfo_Click(object sender, EventArgs e)
        {
            txtValor1.Text = matriz.ValorDe(int.Parse(ndLinha.Value + ""), int.Parse(ndColuna.Value + "")).ToString();
        }

        private void btnExibirInfo2_Click(object sender, EventArgs e)
        {
            txtValor2.Text = matrizSoma.ValorDe(int.Parse(ndLinhaMatriz2.Value + ""), int.Parse(ndColunaMatriz2.Value + "")).ToString();
        }

        private void btnLerMatriz1_Click(object sender, EventArgs e)
        {
            LerArquivo(ref matriz);
            matriz.Exibir(dgvExibicao1);
            ndLinha.Maximum = matriz.TamanhoLinhas - 1;
            ndColuna.Maximum = matriz.TamanhoColunas - 1;
            lbMatriz.Text = "Matriz 1: ";
        }

        private void btnLerMatriz2_Click(object sender, EventArgs e)
        {
            LerArquivo(ref matrizSoma);
            matrizSoma.Exibir(dgvExibicao2);
            ndLinhaMatriz2.Maximum = matrizSoma.TamanhoLinhas - 1;
            ndColunaMatriz2.Maximum = matrizSoma.TamanhoColunas - 1;
            lblMatriz2.Text = "Matriz 2: ";
        }

        private void btnSomarK_Click(object sender, EventArgs e)
        {
            matriz.SomarK(int.Parse(ndColuna.Value + ""), int.Parse(txtValor1.Text));
            matriz.Exibir(dgvExibicao1);
        }

        private void btnSomaMatriz2_Click(object sender, EventArgs e)
        {
            matrizSoma.SomarK(int.Parse(ndColunaMatriz2.Value + ""), int.Parse(txtValor2.Text));
            matrizSoma.Exibir(dgvExibicao2);
        }
    }
}
