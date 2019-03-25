using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Viajante
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForcaBruta a3 = new ForcaBruta(3);
            //ForcaBruta a4 = new ForcaBruta(4);
            //ForcaBruta a5 = new ForcaBruta(5);
            //ForcaBruta a6 = new ForcaBruta(6);
            //ForcaBruta a7 = new ForcaBruta(7);
            //ForcaBruta a8 = new ForcaBruta(8);
            //ForcaBruta a9 = new ForcaBruta(9);
            //ForcaBruta a10 = new ForcaBruta(10);
            //ForcaBruta a15 = new ForcaBruta(15);
            //ForcaBruta a20 = new ForcaBruta(20);
            //ForcaBruta a25 = new ForcaBruta(25);
            //ForcaBruta a30 = new ForcaBruta(30);

            //ForcaBrutaOtimizacao b3 = new ForcaBrutaOtimizacao(3);
            //ForcaBrutaOtimizacao b4 = new ForcaBrutaOtimizacao(4);
            //ForcaBrutaOtimizacao b5 = new ForcaBrutaOtimizacao(5);
            //ForcaBrutaOtimizacao b6 = new ForcaBrutaOtimizacao(6);
            //ForcaBrutaOtimizacao b7 = new ForcaBrutaOtimizacao(7);
            //ForcaBrutaOtimizacao b8 = new ForcaBrutaOtimizacao(8);
            //ForcaBrutaOtimizacao b9 = new ForcaBrutaOtimizacao(9);
            //ForcaBrutaOtimizacao b10 = new ForcaBrutaOtimizacao(10);
            //ForcaBrutaOtimizacao b15 = new ForcaBrutaOtimizacao(15);
            //ForcaBrutaOtimizacao b20 = new ForcaBrutaOtimizacao(20);
            //ForcaBrutaOtimizacao b25 = new ForcaBrutaOtimizacao(25);
            //ForcaBrutaOtimizacao b30 = new ForcaBrutaOtimizacao(30);



            //using (StreamWriter w = new StreamWriter("ForcaBruta_Resultados.csv"))
            //{
            //    w.WriteLine("Quantidade de cidades;Tempo Gasto (ms)");
            //    //w.WriteLine(string.Format("{0};{1}", cidades, a.tempoGasto));
            //}

            //ForcaBrutaOtimizacao test = new ForcaBrutaOtimizacao(4);
            //Console.WriteLine(test);

            AlgoritmoOn2 cv = new AlgoritmoOn2(3);
            Console.WriteLine(cv);


            Console.WriteLine("\nResultados salvos no arquivo \"ForcaBruta_Resultados.csv\"");
            Console.ReadKey();
        }
    }
}
