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

        }

        static bool PreencheMatriz(int[,] matriz)
        {


            return false;
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
                    caminhoatual.caminho[j] = distancias[];
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
