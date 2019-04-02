using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ana Clara Sampaio Pires - 18201 Isabela Paulino de Souza 18189

namespace apMatrizEsparsa
{
    /**
    A classe Celula representa uma célula implemementada que guarda um valor double e tendo dois atributos da classe
    Celula um que aponta para a celula a direita dela e outro que aponta para a célula abaixo. 
    Nela encontramos propriedades para cada atributo presente.
    @author  Ana Clara Sampaio Pires e Isabela Paulino de Souza 
    */
    class Celula
    {
        /* Atributos do tipo Celula que apontam para a Celula abaixo e a direita do this */

        protected Celula direita, abaixo;

        /* Atributos do tipo int linha e coluna, que indicam qual linha e coluna a célula pertence*/

        protected int linha, coluna;

        /* Atributo double que indica o valor da célula*/

        protected double valor;

        /*Construtor da classe celula que recebe como parâmetros os valores da linha, coluna e valor e inicia como null
         as celulas direita e abaixo
         @param double valor o valor da célula que será instanciada, int linha qual linha a célula está, int colunas qual 
         coluna a célula está*/
        public Celula(double valor, int linha, int coluna)
        {
            Valor = valor;
            this.linha = linha;
            this.coluna = coluna;
            direita = abaixo = null;
        }

        /*
          Propriedade que altera e retorna o valor da célula
        */
        public double Valor
        {
            get => valor;
            set => valor = value;
        }

        /*
          Propriedade que  retorna a linha em que a célula está localizada
        */
        public int Linha
        {
            get => linha;
        }

        /*
          Propriedade que retorna a coluna em que a célula está localizada
        */
        public int Coluna
        {
            get => coluna;
        }

        /*
         Propriedade que altera e retorna a célula a direita do this
        */
        public Celula Direita
        {
            get => direita;
            set => direita = value;
        }

        /*
          Propriedade que altera e retorna a célula abaixo do this
        */
        public Celula Abaixo
        {
            get => abaixo;
            set => abaixo = value;
        }


        /**
        Gera uma representação textual do conteúdo da célula e indica em que posição(linha e coluna) ela está.
        @return uma string contendo o valor, linha e coluna da célula.
       */
        public override string ToString()
        {
            return Valor + "  [" + Linha + ", " + Coluna + "]";
        }
    }
}
