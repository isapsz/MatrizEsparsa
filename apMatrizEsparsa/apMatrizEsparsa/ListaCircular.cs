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

        public ListaCircular(int linhas, int colunas)
        {
            cabeca = new Celula(0, -1, -1, null, null);
            qtd = 0;

            Celula p = cabeca;
            for(int i =0; i< linhas; i++)
            {
                Celula linhaCabeca = new Celula(0, i, -1, null, null);

                p.Abaixo = linhaCabeca;
                p.Direita = p;
                p = p.Abaixo;
            }
            p.Abaixo = cabeca;
            p.Direita = p;
        }

        public void InserirElemento(double valor, int linha,  int coluna)
        {
            if (linha < 0 || coluna < 0)
                throw new Exception("Local de inserção não disponível");

            if (valor == 0)
                throw new Exception("Valor de inserção inválido");

            Celula linhaCabeca = cabeca;
            Celula colunaCabeca = cabeca;

            qtd++;
        }

        public void RemoverElemento()
        {

        }
    }
}
