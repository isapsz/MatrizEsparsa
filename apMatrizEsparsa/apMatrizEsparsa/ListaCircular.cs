﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Ana Clara Sampaio Pires - 18201 Isabela Paulino de Souza 18189
namespace apMatrizEsparsa
{

    /**
    A classe ListaCircularCruzada representa uma listaCircularCruzada tendo como base Celulas que apontam para baixo
    e para direita, contendo um atributo qtd que guarda a quantidade de itens da lista e possui também o tamanho máximo
    de linhas e colunas que a lista  pode ter.
    Nela encontramos métodos para alterar, remover, incluir, buscar o valor de uma célula, para criar uma célula, 
    exibir a lista em um dataGridView, somar uma constante em uma coluna, somar e multiplicar duas matrizes, somar 
    um número em uma celula e zerar a lista.
    @author Ana Clara Sampaio Pires e Isabela Paulino de Souza 
    */
    class ListaCircularCruzada
    {  
        /* Celula cabeça que vai ter posição -1,-1 e aponta para as células cabeça da direita e células cabeça da 
         esquerda, possui duas células esquerda e cima que serão utilizadas para auxiliar os métodos.*/
        protected Celula cabeca, esquerda, cima;

        /* Atributo int qtd que guarda a quantidade de células que a lista possui. */
        protected int qtd;

        /* Atributos int que guardam o tamanho máximo de linhas e colunas da lista. */
        protected int tamanhoColunas, tamanhoLinhas;

        /* Propriedade que retorna o tamanho máximo de linhas que a lista pode ter. */
        public int TamanhoLinhas { get => tamanhoLinhas; }

        /* Propriedade que retorna o tamanho máximo de colunas que a lista pode ter. */
        public int TamanhoColunas { get => tamanhoColunas; }

        /*Construtor da classe ListaCircularCruzada que inicia os atributos esquerda e cima como null e o qtd como 0,
         inicia tamanhoLinha e tamanhoColuna com os valores passados como parâmetro pelo programa, a celula cabeca passa
         a apontar para linhas cabeça(a quantidade linhas cabeça vai ser a mesma do tamanhoLinha) e aponta também para as 
         colunas cabeçaa quantidade linhas cabeça vai ser a mesma do tamanhoColuna)
         @params int l que será usado como tamanhoLinha e int c que será usado como tamanhoColuna  
       */
        public ListaCircularCruzada(int l, int c)
        {
            cabeca = new Celula(0, -1, -1);

            cabeca.Direita = cabeca;

            this.tamanhoLinhas = l;
            this.tamanhoColunas = c;

            this.cima = this.esquerda = null;

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

        /*Retorna uma célula com valor e posição passada como  parâmetros
         @return Celula nova célula criada
         @params double valor que irá ser o valor da nova célula, int linha e coluna que serão a posição da célula*/
        protected Celula CriarCelula(double valor, int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > tamanhoLinhas - 1 || coluna > tamanhoColunas - 1)
                throw new Exception("Impossível inserir, local de inserção não disponível");

            if (valor == 0)
                throw new Exception("Valor de inserção inválido");

            return new Celula(valor, linha, coluna);
        }

        /* Método que retorn o valor de uma célula com base na linha e coluna passadas, caso a céula esteja vazia
         retorna 0;
         @return o valor da célula procurada
         @params a linha e coluna onde está localizada a célula que se quer encontrar
         @throws se a linha passada como parâmetro  for menor que 0 ou maior que o tamanho máximo de linhas ou 
         se a coluna passada for maior que o tamanho máximo de colunas ou menor que 0*/
        public double ValorDe(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 || linha > tamanhoLinhas || coluna > tamanhoColunas)
                throw new Exception("Local procurado fora dos limites da matriz!!!");

            esquerda = cima = cabeca;

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


      
        /**/
        public void InserirElemento(double valor, int linha, int coluna)
        {
            if (ValorDe(linha, coluna) != 0)
                AlterarValor(valor, esquerda.Direita);
            else
            {
                Celula nova = CriarCelula(valor, linha, coluna);

                nova.Abaixo = cima.Abaixo;
                nova.Direita = esquerda.Direita;
                esquerda.Direita = nova;
                cima.Abaixo = nova;

                qtd++;
            }
        }


       
        /**/
        protected void AlterarValor(double valor, Celula alterar)
        {
            alterar.Valor = valor;
        }

        /**/
        public void RemoverElemento(int linha, int coluna)
        {
            if (ValorDe(linha, coluna) == 0)
                throw new Exception("Impossível remover, essa célula não existe");

            Celula remover = esquerda.Direita;

            cima.Abaixo = remover.Abaixo;
            esquerda.Direita = remover.Direita;
        }

        /**/
        public void Zerar()
        {
            cabeca = null;
            tamanhoLinhas = 0;
            tamanhoColunas = 0;
        }


        /**/
        public void Exibir(DataGridView dgv)
        {
            Celula p = cabeca;
            dgv.RowCount = tamanhoLinhas;
            dgv.ColumnCount = tamanhoColunas;

            for (int i = 0; i < tamanhoLinhas; i++)
                for (int x = 0; x < tamanhoColunas; x++)
                    dgv.Rows[i].Cells[x].Value = ValorDe(i, x);
        }


        /**/
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


        /**/
        public void SomarElemento(double k, int linha, int coluna)
        {
            if (ValorDe(linha, coluna) == 0)
                throw new Exception("Célula vazia");

            Celula altera = esquerda.Direita;

            if ((altera.Valor + k) == 0)
                RemoverElemento(linha, coluna);
            else
                altera.Valor += k;
        }

        /**/
        public ListaCircularCruzada SomarMatrizes(ListaCircularCruzada soma)
        {
            if (soma.tamanhoColunas != tamanhoColunas || soma.tamanhoLinhas != tamanhoLinhas)
                throw new Exception("As matrizes tem que ter a mesma dimensão");

            ListaCircularCruzada resultado;

            resultado = new ListaCircularCruzada(tamanhoLinhas, tamanhoColunas);

            for (int l = 0; l < resultado.tamanhoLinhas; l++)
                for (int c = 0; c < resultado.tamanhoColunas; c++)
                    if (ValorDe(l, c) + soma.ValorDe(l, c) != 0)
                        resultado.InserirElemento(ValorDe(l, c) + soma.ValorDe(l, c), l, c);

            return resultado;
        }


        /**/
        public ListaCircularCruzada MultiplicarMatrizes(ListaCircularCruzada outra)
        {
            if (outra.tamanhoColunas != tamanhoLinhas)
                throw new Exception("A quantidade de linhas da matriz tem que ser igual a quantidade de colunas da outra");

            ListaCircularCruzada resultado;
            double valor = 0;

            resultado = new ListaCircularCruzada(tamanhoLinhas, outra.tamanhoColunas);

            for (int l = 0; l < resultado.tamanhoLinhas; l++)
            {
                for (int c = 0; c < resultado.tamanhoColunas; c++)
                {
                    for (int coluna = 0; coluna < tamanhoColunas; coluna++)
                        valor += ValorDe(l, coluna) * outra.ValorDe(coluna, c);

                    if (valor != 0)
                        resultado.InserirElemento(valor, l, c);
                    valor = 0;
                }

            }

            return resultado;
        }
    }
}
