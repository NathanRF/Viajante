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
            Console.WriteLine("Calculando...");

            ForcaBruta a3 = new ForcaBruta(3);
            Console.WriteLine("Força bruta 3 calculado");
            ForcaBruta a4 = new ForcaBruta(4);
            Console.WriteLine("Força bruta 4 calculado");
            ForcaBruta a5 = new ForcaBruta(5);
            Console.WriteLine("Força bruta 5 calculado");
            ForcaBruta a6 = new ForcaBruta(6);
            Console.WriteLine("Força bruta 6 calculado");
            ForcaBruta a7 = new ForcaBruta(7);
            Console.WriteLine("Força bruta 7 calculado");
            ForcaBruta a8 = new ForcaBruta(8);
            Console.WriteLine("Força bruta 8 calculado");
            ForcaBruta a9 = new ForcaBruta(9);
            Console.WriteLine("Força bruta 9 calculado");
            ForcaBruta a10 = new ForcaBruta(10);
            Console.WriteLine("Força bruta 10 calculado");
            //ForcaBruta a15 = new ForcaBruta(15);
            //ForcaBruta a20 = new ForcaBruta(20);
            //ForcaBruta a25 = new ForcaBruta(25);
            //ForcaBruta a30 = new ForcaBruta(30);

            ForcaBrutaOtimizacao b3 = new ForcaBrutaOtimizacao(3);
            ForcaBrutaOtimizacao b4 = new ForcaBrutaOtimizacao(4);
            ForcaBrutaOtimizacao b5 = new ForcaBrutaOtimizacao(5);
            ForcaBrutaOtimizacao b6 = new ForcaBrutaOtimizacao(6);
            ForcaBrutaOtimizacao b7 = new ForcaBrutaOtimizacao(7);
            ForcaBrutaOtimizacao b8 = new ForcaBrutaOtimizacao(8);
            ForcaBrutaOtimizacao b9 = new ForcaBrutaOtimizacao(9);
            ForcaBrutaOtimizacao b10 = new ForcaBrutaOtimizacao(10);
            ForcaBrutaOtimizacao b15 = new ForcaBrutaOtimizacao(15);
            ForcaBrutaOtimizacao b20 = new ForcaBrutaOtimizacao(20);
            ForcaBrutaOtimizacao b25 = new ForcaBrutaOtimizacao(25);
            ForcaBrutaOtimizacao b30 = new ForcaBrutaOtimizacao(30);

            AlgoritmoOn2 c3 = new AlgoritmoOn2(3);
            AlgoritmoOn2 c4 = new AlgoritmoOn2(4);
            AlgoritmoOn2 c5 = new AlgoritmoOn2(5);
            AlgoritmoOn2 c6 = new AlgoritmoOn2(6);
            AlgoritmoOn2 c7 = new AlgoritmoOn2(7);
            AlgoritmoOn2 c8 = new AlgoritmoOn2(8);
            AlgoritmoOn2 c9 = new AlgoritmoOn2(9);
            AlgoritmoOn2 c10 = new AlgoritmoOn2(10);
            AlgoritmoOn2 c15 = new AlgoritmoOn2(15);
            AlgoritmoOn2 c20 = new AlgoritmoOn2(20);
            AlgoritmoOn2 c25 = new AlgoritmoOn2(25);
            AlgoritmoOn2 c30 = new AlgoritmoOn2(30);

            using (StreamWriter csv = new StreamWriter("Resultados.csv"))
            {
                csv.WriteLine("Quantidade de cidades;Forca Bruta (ms);O(1,26^n) (ms);O(n^2)");

                csv.WriteLine(string.Format("3;{0};{1};{2}", a3.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("4;{0};{1};{2}", a4.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("5;{0};{1};{2}", a5.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("6;{0};{1};{2}", a6.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("7;{0};{1};{2}", a7.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("8;{0};{1};{2}", a8.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("9;{0};{1};{2}", a9.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("10;{0};{1};{2}", a10.tempoGasto, b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("15;{0};{1};{2}", /*a15.tempoGasto,*/"Não testado", b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("20;{0};{1};{2}",/* a20.tempoGasto,*/"Não testado", b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("25;{0};{1};{2}",/* a25.tempoGasto,*/"Não Testado", b3.tempoGasto, c3.tempoGasto));
                csv.WriteLine(string.Format("30;{0};{1};{2}",/* a30.tempoGasto,*/"Não testado", b3.tempoGasto, c3.tempoGasto));

            }

            ForcaBrutaOtimizacao test = new ForcaBrutaOtimizacao(4);
            Console.WriteLine(test);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nResultados salvos no arquivo \"Resultados.csv\"");
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
