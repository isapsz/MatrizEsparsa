using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizEsparsa
{
    class ListaCircular
    {
        protected Celula cabeca, atual, anterior;
        protected int qtd;
        protected int linhas, colunas;

        public ListaCircular(int l, int c)
        {
            cabeca = new Celula(0, -1, -1, null, null);

            cabeca.Direita = cabeca;

            this.linhas = l;
            this.colunas = c;

            qtd = 0;

            Celula p = cabeca;
            
            for(int i =0; i< linhas; i++)
            {
                Celula linhaCabeca = new Celula(0, i, -1, null, null);

                p.Abaixo = linhaCabeca;
                p = p.Abaixo;
                p.Direita = p;
            }
            p.Abaixo = cabeca;

            p = cabeca;

            for (int i = 0; i < colunas; i++)
            {
                Celula colunaCabeca = new Celula(0, -1, i, null, null);

                p.Direita = colunaCabeca;
                p = p.Direita;
                p.Abaixo = p;
            }
            p.Direita = cabeca;

        }

        public void InserirElemento(double valor, int linha,  int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > linhas || coluna > colunas)
                throw new Exception("Local de inserção não disponível");

            if (valor == 0)
                throw new Exception("Valor de inserção inválido");

             Celula linhaCabeca = cabeca;
             Celula colunaCabeca = cabeca;

             for(int l = 0; l <= linha; l++)
                linhaCabeca = linhaCabeca.Abaixo;

             for (int c = 0; c <= coluna; c++)
             {
                colunaCabeca = colunaCabeca.Direita;
                if(c > 0)
                linhaCabeca = linhaCabeca.Direita;
             }

            for (int i = 0; i <= linha && colunaCabeca.Abaixo != colunaCabeca; i++)
                colunaCabeca = colunaCabeca.Abaixo;

            Celula insercao = new Celula(valor, linha, coluna, linhaCabeca.Direita, colunaCabeca.Abaixo);

            colunaCabeca.Abaixo = insercao;
            linhaCabeca.Direita = insercao;

            qtd++;
        }

        public double ValorDe(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > linhas || coluna > colunas)
                throw new Exception("Local procurado inválido!!!");

            Celula procura = cabeca;

            for (int i = 0; i < linha; i++)
                procura = procura.Abaixo;

            for (int i = 0; i < coluna; i++)
                procura = procura.Direita;

            return procura.Valor;
        }

        public void RemoverElemento()
        {

        }
    }
}
