using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apMatrizEsparsa
{
    class ListaCircular
    {
        protected Celula cabeca, esquerda, cima;
        protected int qtd;
        protected int tamanhoColunas, tamanhoLinhas;

        public int TamanhoLinhas { get => tamanhoLinhas; }
        public int TamanhoColunas { get => tamanhoColunas; }

        public ListaCircular(int l, int c)
        {
            cabeca = new Celula(0, -1, -1);

            cabeca.Direita = cabeca;

            this.tamanhoLinhas = l;
            this.tamanhoColunas = c;

            this.cima = null;
            this.esquerda = null;

            qtd = 0;

            Celula p = cabeca;

            for (int i = 0; i < tamanhoLinhas; i++)
            {
                Celula linhaCabeca = new Celula(0, i, -1);

                p.Abaixo = linhaCabeca;
                p = p.Abaixo;
                p.Direita = p;
            }
            p.Abaixo = cabeca;

            p = cabeca;

            for (int i = 0; i < tamanhoColunas; i++)
            {
                Celula colunaCabeca = new Celula(0, -1, i);

                p.Direita = colunaCabeca;
                p = p.Direita;
                p.Abaixo = p;
            }
            p.Direita = cabeca;

        }
        protected Celula CriarCelula(double valor, int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > tamanhoLinhas - 1 || coluna > tamanhoColunas - 1)
                throw new Exception("Local de inserção não disponível");

            if (valor == 0)
                throw new Exception("Valor de inserção inválido");

            return new Celula(valor, linha, coluna);
        }

        public void InserirElemento(double valor, int linha, int coluna)
        {
            if (ValorDe(linha, coluna) != 0)
                throw new Exception("Essa célula já existe");

            Celula nova = CriarCelula(valor, linha, coluna);

            nova.Abaixo = cima.Abaixo;
            nova.Direita = esquerda.Direita;
            esquerda.Direita = nova;
            cima.Abaixo = nova;

            qtd++;
        }

        public double ValorDe(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > tamanhoLinhas || coluna > tamanhoColunas)
                throw new Exception("Local procurado inválido!!!");

            esquerda = cabeca;
            cima = cabeca;

            while (esquerda.Linha < linha && esquerda.Abaixo != esquerda)
                esquerda = esquerda.Abaixo;

            while (esquerda.Direita.Coluna < coluna && esquerda.Direita != esquerda && esquerda.Direita.Coluna != -1)
                esquerda = esquerda.Direita;

            while (cima.Coluna < coluna && cima.Direita != cima)
                cima = cima.Direita;

            while (cima.Abaixo.Linha < linha && cima.Abaixo != cima && cima.Abaixo.Linha != -1)
                cima = cima.Abaixo;

            Celula procura = esquerda.Direita;

            if (procura.Coluna != coluna)
                return 0;

            return procura.Valor;
        }

        public void RemoverElemento(int linha, int coluna)
        {
            if (ValorDe(linha, coluna) == 0)
                throw new Exception("Essa célula não existe");

            Celula remover = esquerda.Direita;

            cima.Abaixo = remover.Abaixo;
            esquerda.Direita = remover.Direita;
        }

        public void Zerar()
        {
            cabeca = null;
            tamanhoLinhas = 0;
            tamanhoColunas = 0;
        }

        public void Exibir(DataGridView dgv)
        {
            Celula p = cabeca;
            dgv.RowCount = tamanhoLinhas;
            dgv.ColumnCount = tamanhoColunas;

            for (int i = 0; i < tamanhoLinhas; i++)
                for (int x = 0; x < tamanhoColunas; x++)
                    dgv.Rows[i].Cells[x].Value = ValorDe(i, x);
        }

        public void SomarK(int coluna, double k)
        {
            if (coluna < 0 || coluna > tamanhoColunas)
                throw new Exception("Coluna inválida");
            for (int l = 0; l < tamanhoLinhas; l++)
                if (ValorDe(l, coluna) == 0)
                    InserirElemento(k, l, coluna);
                else
                    SomarElemento(k, l, coluna);
        }

        public void SomarElemento(double k, int linha, int coluna)
        {
            if (ValorDe(linha, coluna) == 0)
                throw new Exception("Célula vazia");

            Celula altera = esquerda.Direita;
            altera.Valor += k;
        }

        public ListaCircular SomarMatrizes(ListaCircular soma)
        {
            ListaCircular resultado;

            for (int l = 0; l < tamanhoLinhas && l < soma.tamanhoLinhas; l++)
                for (int c = 0; c < tamanhoColunas && c < soma.tamanhoColunas; c++)
                {

                }
            return resultado;
        }
    }
}
