using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizEsparsa
{
    class ListaCircular
    {
        protected Celula cabeca;
        protected int qtd;
        protected int tamanhoLinhas, tamanhoColunas;

        public ListaCircular(int l, int c)
        {
            cabeca = new Celula(0, -1, -1);

            cabeca.Direita = cabeca;

            this.tamanhoLinhas = l;
            this.tamanhoColunas = c;

            qtd = 0;

            Celula p = cabeca;
            
            for(int i =0; i< tamanhoLinhas; i++)
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
            if (linha < 0 || coluna < 0 || linha > tamanhoLinhas-1 || coluna > tamanhoColunas-1)
                throw new Exception("Local de inserção não disponível");

            if (valor == 0)
                throw new Exception("Valor de inserção inválido");

            return new Celula(valor, linha, coluna);
        }

        public void InserirElemento(double valor, int linha, int coluna)
        {
             Celula nova = CriarCelula(valor, linha, coluna), cima = cabeca, esquerda = cabeca;

            //existe

            while (esquerda.Linha < nova.Linha && esquerda.Abaixo != esquerda)
                esquerda = esquerda.Abaixo;

            while (esquerda.Direita.Coluna < nova.Coluna && esquerda.Direita != esquerda && esquerda.Direita.Coluna != -1)
                esquerda = esquerda.Direita;

            while (cima.Coluna < nova.Coluna && cima.Direita != cima)
                cima = cima.Direita;

            while(cima.Abaixo.Linha < nova.Linha  && cima.Abaixo != cima && cima.Abaixo.Linha != -1 )
                 cima = cima.Abaixo;

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
