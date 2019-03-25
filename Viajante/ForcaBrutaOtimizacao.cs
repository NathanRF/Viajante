using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Viajante
{
    class ForcaBrutaOtimizacao
    {        
        private int[,] distancias; //matriz de distancias entre cidades
        private Stopwatch stopwatch;

        public long tempoGasto { get; private set; }
        public int[] menorCaminhoPercorrido { get; private set; }
        public int menorDistancia { get; private set; }

        public ForcaBrutaOtimizacao(int tamanho)
        {
            distancias = new int[tamanho, tamanho];
            stopwatch = Stopwatch.StartNew();
            PreencheMatriz(distancias);
            GeradorDeCaminho(distancias.GetLength(0) - 1);
            stopwatch.Stop();
            tempoGasto = stopwatch.ElapsedMilliseconds;
        }

        public override string ToString()
        {
            string result = ("Menor caminho: " + CaminhoToText(menorCaminhoPercorrido) +
                             "\nDistância: " + menorDistancia +
                             "\nTempo Decorrido: " + stopwatch.ElapsedMilliseconds + "ms");
            return (result);
        }

        /// <summary>
        /// Preenche a matriz de distancias entre as cidades com valores aleatórios
        /// </summary>
        /// <param name="matriz">Array bidimensional que conterá o valor de distancias</param>
        private void PreencheMatriz(int[,] matriz)
        {
            Random r = new Random();
            int distancia;

            for (int lin = 0; lin < matriz.GetLength(0); lin++)
            {
                matriz[lin, lin] = 0;

                for (int col = lin + 1; col < matriz.GetLength(1); col++)
                {
                    distancia = r.Next(1, 10);
                    matriz[lin, col] = distancia;
                    matriz[col, lin] = distancia;
                }
            }
        }

        /// <summary>
        /// Gera uma lista de votores de inteiros com permutações entre números de 1 até 
        /// </summary>
        /// <param name="pontos"> Quantidade de cidades -1</param>
        /// <returns>Lista de votores de inteiros com permutações</returns>
        private void GeradorDeCaminho(int pontos)
        {
            int[] caminho = new int[pontos];
            int[] temp = new int[pontos];
            int[] caminhoGerado;
            //int distanciaAtual;

            for (int i = 0; i < caminho.Length; i++) //Insere no vetor de caminhos os identificadores de cada cidade
            {
                caminho[i] = i + 1;
            }

            ulong permutacoesPossiveis = Fat(Convert.ToUInt64(pontos)); //Número de combinaçãoes possíveis de cidades (Fatorial do número de cidades - 1)

            menorDistancia = int.MaxValue;
            while (permutacoesPossiveis > 0) //Faz permutações e insere os resultados na lista de vetores
            {
                for (int j = 0; j < pontos - 1; j++)
                {
                    temp[j] = caminho[j + 1];
                    caminho[j + 1] = caminho[j];
                    caminho[j] = temp[j];

                    caminhoGerado = new int[caminho.Length + 2];

                    for (int i = 1; i < caminho.Length + 1; i++)
                    {
                        caminhoGerado[i] = caminho[i - 1];
                    }

                    //distanciaAtual = SomaDistancia(distancias, caminhoGerado);
                    ////if(distanciaAtual > menorDistancia && j>0)
                    ////{
                    ////    return;
                    ////}
                    //if(distanciaAtual < menorDistancia)
                    //{
                    //    menorDistancia = distanciaAtual;
                    //    menorCaminhoPercorrido = caminhoGerado;
                    //}
                }
                permutacoesPossiveis -= Convert.ToUInt64(pontos) - 1;
            }
        }

        /// <summary>
        /// Calcula distancias entre as cidades a partir dos caminhos e escolhe o menor
        /// </summary>
        /// <param name="distancias">Distancias entre cidades</param>
        /// <param name="paths">Caminhos possíveis</param>
        /// <returns>Lista com resultados</returns>
        private int SomaDistancia(int[,] distancias, int[] caminho)
        {
            int soma = 0;

            for (int i = 0; i < caminho.Length - 1; i++)
            {
                soma += distancias[caminho[i], caminho[i + 1]]; //Distancia

                if (soma > menorDistancia)
                    return soma;
            }

            menorDistancia = soma;
            return soma;
        }

        private string CaminhoToText(int[] caminho)
        {
            string caminhoUsado = "";

            for (int i = 0; i < caminho.Length - 1; i++)
            {
                if (i == 0) //Caminho atual por extenso
                    caminhoUsado += ("Cidade " + caminho[i] + " --> " + "Cidade " + caminho[i + 1]);
                else
                    caminhoUsado += (" --> " + "Cidade " + caminho[i + 1]);
            }

            return caminhoUsado;
        }

        private ulong Fat(ulong num) //Cálculo de fatorial
        {
            if (num <= 1)
                return 1;
            else
                return num * Fat(num - 1);
        }
    }
}
