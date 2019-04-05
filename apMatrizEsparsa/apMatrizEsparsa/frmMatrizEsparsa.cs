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


// Ana Clara Sampaio Pires - 18201 Isabela Paulino de Souza 18189

/**
A classe frmMatrizEsparsa tem como obetivo fazer as operações
da classe ListaCircular e exibir de forma gráfico os resultados dos métodos,
mostrar as matrizes e ler arquivos.
@author Ana Clara Sampaio Pires e Isabela Paulino de Souza 
*/

namespace apMatrizEsparsa
{
    public partial class frmMatrizEsparsa : Form
    {
        public frmMatrizEsparsa()
        {
            InitializeComponent();
        }
        /*Criação de duas matrizes que serão utilizadas para 
          exibição no dataGridView e utilizadas para as operações desejadas
        */
        ListaCircularCruzada matriz;
        ListaCircularCruzada matrizDois;

        /* Método que ocorre quando o formulário for iniciado*/

        private void frmMatrizEsparsa_Load(object sender, EventArgs e)
        {
           // dgvExibicao1.Dock = DockStyle.Fill;
            lblInstrucoes.Text = "Para inserir um valor na matriz digite-o na tabela.\n" +
                                 "Para excluir substitua o valor que deseja apagar na tabela por 0.";
        }

        /* Método sem retorno que lê um arquivo texto escolhido pelo 
           usuário e os insere os dados presentes na matriz desejada
           @params a matriz na qual os dados do aquivo serão inseridos
         */

        private void LerArquivo(ref ListaCircularCruzada lista)
        {
            try
            {
                if (dlgArquivo.ShowDialog() == DialogResult.OK)
                {
                    StreamReader arq = new StreamReader(dlgArquivo.FileName);

                    string linha;

                    if (!arq.EndOfStream)
                        lista = new ListaCircularCruzada(int.Parse(arq.ReadLine()), int.Parse(arq.ReadLine()));

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
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message, "Erro ao ler arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Método que ocorre quando o usuário clicar no botão exibir1 e nele ocorre a 
           exibição do valor alocado na célula da matriz1 na coluna e linha presentes 
           nos campos indicados no form
        */

        private void btnExibirInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (matriz != null)
                    txtValor1.Text = matriz.ValorDe(int.Parse(ndLinha.Value + ""), int.Parse(ndColuna.Value + "")).ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao procurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Método que ocorre quando o usuário clicar no botão exibir2 e nele ocorre a 
           exibição do valor alocado na célula da matriz2 na coluna e linha presentes 
           nos campos indicados no form
        */

        private void btnExibirInfo2_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizDois != null)
                    txtValor2.Text = matrizDois.ValorDe(int.Parse(ndLinhaMatriz2.Value + ""), int.Parse(ndColunaMatriz2.Value + "")).ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao procurar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Método que ocorre quando o usuário clicar no botão ler matriz1 e nele ocorre a 
           exibição da matriz lida pelo arquivo texto indicado pelo usuário no devido DataGridView
        */

        private void btnLerMatriz1_Click(object sender, EventArgs e)
        {
            try
            {
                LerArquivo(ref matriz);
                matriz.Exibir(dgvExibicao1);
                ndLinha.Maximum = matriz.TamanhoLinhas - 1;
                ndColuna.Maximum = matriz.TamanhoColunas - 1;
                lbMatriz.Text = "Matriz 1: ";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao criar matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Método que ocorre quando o usuário clicar no botão ler matriz2 e nele ocorre a 
           exibição da matriz lida pelo arquivo texto indicado pelo usuário no devido DataGridView
        */
        private void btnLerMatriz2_Click(object sender, EventArgs e)
        {
            try
            {
                LerArquivo(ref matrizDois);
                matrizDois.Exibir(dgvExibicao2);
                ndLinhaMatriz2.Maximum = matrizDois.TamanhoLinhas - 1;
                ndColunaMatriz2.Maximum = matrizDois.TamanhoColunas - 1;
                lblMatriz2.Text = "Matriz 2: ";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao criar matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Método que ocorre quando o usuário clicar no botão somarK e nele ocorre a 
           exibição da matriz1 no DataGridView após ser somado um valor K a todas as 
           células de uma certa coluna
        */
        private void btnSomarK_Click(object sender, EventArgs e)
        {
            try
            {
                if (matriz != null)
                {
                    matriz.SomarK(int.Parse(ndColuna.Value + ""), int.Parse(txtValor1.Text));
                    matriz.Exibir(dgvExibicao1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "A coluna estava fora dos limites da matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Método que ocorre quando o usuário clicar no botão somarK2 e nele ocorre a 
           exibição da matriz2 no DataGridView após ser somado um valor K a todas as 
           células de uma certa coluna
        */

        private void btnSomaMatriz2_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizDois != null)
                {
                    matrizDois.SomarK(int.Parse(ndColunaMatriz2.Value + ""), int.Parse(txtValor2.Text));
                    matrizDois.Exibir(dgvExibicao2);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "A coluna estava fora dos limites da matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Método que ocorre quando uma célula do DataGridView é alterada e assim
            altera a matriz1 seja incluindo, excluindo ou alterando e exibe novamente no DataGridView
        */

        private void dgvExibicao1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (matriz != null)
                {
                    if (double.Parse(dgvExibicao1[e.ColumnIndex, e.RowIndex].Value + "") == 0)
                        matriz.RemoverElemento(e.RowIndex, e.ColumnIndex);
                    else
                        matriz.InserirElemento(double.Parse(dgvExibicao1[e.ColumnIndex, e.RowIndex].Value + ""),
                                                e.RowIndex, e.ColumnIndex);

                    matriz.Exibir(dgvExibicao1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao alterar matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Método que ocorre quando uma célula do DataGridView é alterada e assim
           altera a matriz2 seja incluindo, excluindo ou alterando e exibe novamente no DataGridView
       */

        private void dgvExibicao2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (matrizDois != null)
                {
                    if (double.Parse(dgvExibicao2[e.ColumnIndex, e.RowIndex].Value + "") == 0)
                        matrizDois.RemoverElemento(e.RowIndex, e.ColumnIndex);
                    else
                        matrizDois.InserirElemento(double.Parse(dgvExibicao2[e.ColumnIndex, e.RowIndex].Value + ""),
                                                e.RowIndex, e.ColumnIndex);

                    matrizDois.Exibir(dgvExibicao2);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro ao alterar matriz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* Método que ocorre quando o botão SomarMatrizes for clicado assim as
           matrizes 1 e 2 são somadas e o resultado é exibido em um DataGridView
        */

        private void btnSomarMatrizes_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizDois != null && matriz != null)
                    matriz.SomarMatrizes(matrizDois).Exibir(dgvResultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Soma inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* Método que ocorre quando o botão MultiplicarMatrizes for clicado assim as
           matrizes 1 e 2 são multiplicadas e o resultado é exibido em um DataGridView
        */

        private void btnMultiplicarMatrizes_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrizDois != null && matriz != null)
                    matriz.MultiplicarMatrizes(matrizDois).Exibir(dgvResultado);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Multiplicação inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /* Método que ocorre quando o botão Zerar1 for clicado assim a
           matriz 1 é zerada e exibida em um DataGridView
        */

        private void btnZerar1_Click(object sender, EventArgs e)
        {
            try
            {
                matriz.Zerar();
                matriz.Exibir(dgvExibicao1);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        /* Método que ocorre quando o botão Zerar1 for clicado assim a
           matriz 2 é zerada e exibida em um DataGridView
        */

        private void btnZerar2_Click(object sender, EventArgs e)
        {
            try
            {
                matrizDois.Zerar();
                matrizDois.Exibir(dgvExibicao2);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
        /* Método que ocorre quando o mouse entra no botão LerMatriz1 
           mudando a cor do botão
        */
        private void btnLerMatriz1_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }
        /* Método que ocorre quando o mouse sai no botão LerMatriz1 
           mudando a cor do botão
        */
        private void btnLerMatriz1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }
    }
}
