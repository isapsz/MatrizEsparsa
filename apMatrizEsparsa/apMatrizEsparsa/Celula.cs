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

        public Celula(double valor, int linha, int coluna)
        {
            Valor = valor;
            Linha = linha;
            Coluna = coluna;
        }

        public double Valor
       {
            get => valor;
            set
            {
                if (value != null)
                    valor = value;
            }
       }

        public int Linha
        {
            get => linha;
            set
            {
                if (value != null)
                    linha = value;
            }
        }

        public int Coluna
        {
            get => coluna;
            set
            {
                if (value != null)
                    coluna = value;
            }
        }

        public Celula Direita
        {
            get => direita;
            set
            {
                if (value != null)
                    direita = value;
            }
        }

        public Celula Abaixo
        {
            get => abaixo;
            set
            {
                if (value != null)
                    abaixo = value;
            }
        }

        public override string ToString()
        {
            return Valor + ", " + Linha + ", " + Coluna;
        }

    }
}
