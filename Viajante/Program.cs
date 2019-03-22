using System;
using System.Collections.Generic;

namespace Viajante
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Numero de cidades: ");
            int cidades = int.Parse(Console.ReadLine());

            int[,] distancias = new int[cidades, cidades];

            string[] vetor = GeradorDeCaminho(distancias.GetLength(0) - 1);

            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void PreencheMatriz(int[,] matriz)
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
                

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string ForcaBruta(int[,] distancias)
        {
            List<Caminho> caminhos = new List<Caminho>();
            int j = 0;
            int numCidades = distancias.GetLength(0);

            while (j < numCidades)
            {
                Caminho caminhoatual = new Caminho(numCidades + 1);

                for (int i = 1; i < numCidades; i++)
                {
                    caminhoatual.caminho[j] = distancias[j, 0];
                }

                caminhos.Add(caminhoatual);
                j++;
            }            
            
            

            return null;
        }

        static string[] GeradorDeCaminho(int pontos)
        {
            int[] caminho = new int[pontos];
            int[] temp = new int[pontos];
            int permutacoesPossiveis = 0;
            int y = pontos;
            int index = 0;

            for (int i = 0; i < caminho.Length; i++) //Insere no vetor de caminhos os identificadores de cada cidade
            {
                caminho[i] = i + 1;
            }

            permutacoesPossiveis = Fat(pontos); //Número de combinaçãoes possíveis de cidades (Fatorial do número de cidades - 1)
            //int[,] lista = new int[pontos, permutacoesPossiveis]; //Matriz para salvar os caminhos possíveis

            string[] caminhos = new string[permutacoesPossiveis];

            while (permutacoesPossiveis > 0)
            {
                for (int j = 0; j < y - 1; j++)
                {
                    temp[j] = caminho[j + 1];
                    caminho[j + 1] = caminho[j];
                    caminho[j] = temp[j];

                    for (int i = 0; i < caminho.Length; i++)
                    {
                        caminhos[index] += Convert.ToString(caminho[i]) + ' ';
                    }
                    index++;
                }
                permutacoesPossiveis -= y - 1;
            }

            return caminhos;
        }

        static int Fat(int num)
        {
            if (num <= 1)
                return 1;
            else
                return num * Fat(num - 1);
        }
    }
}
