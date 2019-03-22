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

            List<int[]> caminhos;
            string[] vetor = GeradorDeCaminho((distancias.GetLength(0) - 1), out caminhos);

            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("New method");

            foreach (int[] item in caminhos)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i]+"\t");
                }
                Console.WriteLine();
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

        static List<int[]> GeradorDeCaminho(int pontos)
        {
            int[] caminho = new int[pontos];
            int[] temp = new int[pontos];
            int[] caminhoGerado;
            int permutacoesPossiveis = 0;
            //int y = pontos;
            //int index = 0;
            List<int[]>paths = new List<int[]>();

            for (int i = 0; i < caminho.Length; i++) //Insere no vetor de caminhos os identificadores de cada cidade
            {
                caminho[i] = i + 1;
            }
            
            permutacoesPossiveis = Fat(pontos); //Número de combinaçãoes possíveis de cidades (Fatorial do número de cidades - 1)
            //int[,] lista = new int[pontos, permutacoesPossiveis]; //Matriz para salvar os caminhos possíveis

            //string[] caminhos = new string[permutacoesPossiveis];

            while (permutacoesPossiveis > 0)
            {
                for(int j = 0; j < pontos - 1; j++)
                {
                    temp[j] = caminho[j + 1];
                    caminho[j + 1] = caminho[j];
                    caminho[j] = temp[j];

                    //for (int i = 0; i < caminho.Length; i++)
                    //{
                    //    caminhos[index] += Convert.ToString(caminho[i]) + ' ';
                    //}

                    caminhoGerado = new int[caminho.Length+2];

                    for (int i = 1; i < caminho.Length+1; i++)
                    {
                        caminhoGerado[i] = caminho[i-1];
                    }

                    //caminhoGerado[0] = 0;
                    //caminhoGerado[caminho.Length - 1] = 0;

                    paths.Add(caminhoGerado);
                    //index++;
                }
                permutacoesPossiveis -= pontos - 1;
            }

            return paths;
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
