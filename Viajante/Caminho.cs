using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajante
{
    class Caminho
    {
        public int[] caminho;

        public Caminho(int tamanho)
        {
            caminho = new int[tamanho];
        }

        public int distancia()
        {
            int resposta = 0;

            for (int i = 0; i < caminho.Length; i++)
            {
                resposta += caminho[i];
            }
            return resposta;
        }

        public bool MenorQue(Caminho c)
        {
            if (distancia() < c.distancia())
                return true;
            return false;
        }
    }
}
