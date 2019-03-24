using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajante
{
    class Caminho
    {                        
        private int[,] distancias; //matriz de distancias entre cidades
        private List<int[]> itinerarios; //caminhos a serem percorridos
        private List<int> allPaths; //Resultados de distancias de cada caminho percorrido
        private List<string> sequencia = new List<string>(); //Cidades que foram percorridas em sequencia por extenso

        public string menorCaminhoPercorrido {get; private set; }
        public int menorDistancia { get; private set; }

        public Caminho(int tamanho)
        {
            distancias = new int[tamanho, tamanho];
            PreencheMatriz(distancias);
            itinerarios = GeradorDeCaminho((distancias.GetLength(0) - 1));
            allPaths = ForcaBruta(distancias, itinerarios);

            //Substituir por um unico metodo que realiza as permutações e calculos de distancia mas não salva em uma lista, 
            //apenas atualiza a propriedade de menor distancia
        }

        public override string ToString(){
            string result = ("Menor caminho: " + menorCaminhoPercorrido + ", Distância: " + menorDistancia);
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
        private List<int[]> GeradorDeCaminho(int pontos)
        {
            int[] caminho = new int[pontos];
            int[] temp = new int[pontos];
            int[] caminhoGerado;
            int permutacoesPossiveis = 0;

            List<int[]> paths = new List<int[]>();

            for (int i = 0; i < caminho.Length; i++) //Insere no vetor de caminhos os identificadores de cada cidade
            {
                caminho[i] = i + 1;
            }

            permutacoesPossiveis = Fat(pontos); //Número de combinaçãoes possíveis de cidades (Fatorial do número de cidades - 1)

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

                    paths.Add(caminhoGerado);
                }
                permutacoesPossiveis -= pontos - 1;
            }

            return paths;
        }

        /// <summary>
        /// Calcula distancias entre as cidades a partir dos caminhos e escolhe o menor
        /// </summary>
        /// <param name="distancias">Distancias entre cidades</param>
        /// <param name="paths">Caminhos possíveis</param>
        /// <returns>Lista com resultados</returns>
        private List<int> ForcaBruta(int[,] distancias, List<int[]> paths)
        {
            List<int> caminhos = new List<int>();

            int soma = 0, index = 0;
            menorDistancia = int.MaxValue;
            string caminhoUsado = "";

            foreach (int[] caminho in paths)
            {
                for (int i = 0; i < caminho.Length - 1; i++)
                {
                    soma += distancias[caminho[i], caminho[i + 1]]; //Distancia

                    if (i == 0) //Caminho atual por extenso
                        caminhoUsado += ("Cidade " + caminho[i] + " --> " + "Cidade " + caminho[i + 1]);
                    else
                        caminhoUsado += (" --> " + "Cidade " + caminho[i + 1]);
                }

                sequencia.Add(caminhoUsado);
                caminhos.Add(soma);

                if (soma < menorDistancia) //Define o menor caminho e a distancia deste caminho
                {
                    menorDistancia = soma;
                    menorCaminhoPercorrido = caminhoUsado;
                }

                caminhoUsado = "";
                soma = 0;
                index++;
            }            

            return caminhos;
        }

        public string Resultados()
        {
            string resultados = null;



            return null;
        }

        private int Fat(int num) //Cálculo de fatorial
        {
            if (num <= 1)
                return 1;
            else
                return num * Fat(num - 1);
        }
    }
}
