using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Viajante
{
    class AlgoritmoOn2
    {
        int[,] mapa; // matriz com a distancia entre as cidades
        int custo_Total; // custo do caminho percorrido
        List<int> rota; // lista com a rota calculada pelo algoritmo
        Stopwatch stopwatch;

        public long tempoGasto { get; private set; }

        public AlgoritmoOn2(int num)
        {
            stopwatch = Stopwatch.StartNew();            
            
            mapa = new int[num, num];
            PreencheMatriz(mapa);
            Calc_Rota();

            stopwatch.Stop();
            tempoGasto = stopwatch.ElapsedMilliseconds;
        }

        public override string ToString()
        {
            string caminho = null;

            foreach (int item in rota)
            {
                caminho += (Convert.ToString(item + "-->"));
            }
            caminho = caminho.Remove(caminho.Length - 3);

            string result = string.Format("Caminho: {0} \nDistância: {1} \nTempo de processamento: {2:00}:{3:00}:{4:00}.{5:00}", caminho,
                             custo_Total, stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
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

        private void Calc_Rota()
        {
            int c_atual = 0, c_prox = 0, menor_Custo;
            custo_Total = 0;

            rota = new List<int>(mapa.GetLength(0)) // grava a rota do caixeiro
            {
                0 // primeira cidade
            };

            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                if (i == (mapa.GetLength(0) - 1)) // Quando a ultima cidade eh alcançada, retorna-se a primeira
                {
                    menor_Custo = mapa[c_atual, 0];
                    c_prox = 0;
                }                    
                else
                {
                    menor_Custo = int.MaxValue;

                    for (int j = 0; j < mapa.GetLength(0); j++)
                        if (j != c_atual && !rota.Contains(j) && mapa[c_atual, j] != 0) // descarta a cidade atual da comparaçao
                            if (mapa[c_atual, j] < menor_Custo) // testa se é o menor caminho disponivel
                            {
                                menor_Custo = mapa[c_atual, j];
                                c_prox = j;
                            }
                }
                
                rota.Add(c_prox); // adiciona a proxima cidade do mapa a rota
                custo_Total += menor_Custo; // soma o custo total do caminho
                c_atual = c_prox; // vai para a proxima cidade
            }
        }

    }
}
