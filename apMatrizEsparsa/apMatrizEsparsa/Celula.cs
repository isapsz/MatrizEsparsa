using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizEsparsa
{
    class Celula
    {
        private Celula direita;
        private Celula abaixo;
        private int linha, coluna;
        private double valor;

        public Celula(double valor, int linha, int coluna, Celula d, Celula a)
        {
            Valor = valor;
            Linha = linha;
            Coluna = coluna;
            Direita = d;
            Abaixo = a;
        }

        public double Valor
       {
            get => valor;
            set => valor = value;
       }

        public int Linha
        {
            get => linha;
            set =>  linha = value;
        }

        public int Coluna
        {
            get => coluna;
            set => coluna = value;
        }

        public Celula Direita
        {
            get => direita;
            set => direita = value;
        }

        public Celula Abaixo
        {
            get => abaixo;
            set => abaixo = value;
        }

        public override string ToString()
        {
            return Valor + "  [" + Linha + ", " + Coluna + "]";
        }
    }
}
