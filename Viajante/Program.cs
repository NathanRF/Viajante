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

            PreencheMatriz(distancias);

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

        static void GeradorDeCaminho(int[,] pontos)
        {
            int size = pontos.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                }
            }
        }
    }
}
