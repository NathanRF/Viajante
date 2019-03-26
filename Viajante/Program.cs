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
            Console.WriteLine("\nForça bruta com 3 cidades calculado: "+a3);
            ForcaBruta a4 = new ForcaBruta(4);
            Console.WriteLine("\nForça bruta com 4 cidades calculado: "+a4);
            ForcaBruta a5 = new ForcaBruta(5);
            Console.WriteLine("\nForça bruta com 5 cidades calculado: "+a5);
            ForcaBruta a6 = new ForcaBruta(6);
            Console.WriteLine("\nForça bruta com 6 cidades calculado: "+a6);
            ForcaBruta a7 = new ForcaBruta(7);
            Console.WriteLine("\nForça bruta com 7 cidades calculado: "+a7);
            ForcaBruta a8 = new ForcaBruta(8);
            Console.WriteLine("\nForça bruta com 8 cidades calculado: "+a8);
            ForcaBruta a9 = new ForcaBruta(9);
            Console.WriteLine("\nForça bruta com 9 cidades calculado: " + a9);
            ForcaBruta a10 = new ForcaBruta(10);
            Console.WriteLine("\nForça bruta com 10 cidades calculado: " + a10);
            ForcaBruta a11 = new ForcaBruta(11);
            Console.WriteLine("\nForça bruta com 11 cidades calculado: " + a11);
            ForcaBruta a12 = new ForcaBruta(12);
            Console.WriteLine("\nForça bruta com 12 cidades calculado: " + a12);
            ForcaBruta a13 = new ForcaBruta(13);
            Console.WriteLine("\nForça bruta com 13 cidades calculado: " + a13);

            //ForcaBruta a15 = new ForcaBruta(15);
            //ForcaBruta a20 = new ForcaBruta(20);
            //ForcaBruta a25 = new ForcaBruta(25);
            //ForcaBruta a30 = new ForcaBruta(30);

            ForcaBrutaOtimizacao b3 = new ForcaBrutaOtimizacao(3);
            Console.WriteLine("\nForça bruta otimizada com 3 cidades calculado: " + b3);
            ForcaBrutaOtimizacao b4 = new ForcaBrutaOtimizacao(4);
            Console.WriteLine("\nForça bruta otimizada com 4 cidades calculado: " + b4);
            ForcaBrutaOtimizacao b5 = new ForcaBrutaOtimizacao(5);
            Console.WriteLine("\nForça bruta otimizada com 5 cidades calculado: " + b5);
            ForcaBrutaOtimizacao b6 = new ForcaBrutaOtimizacao(6);
            Console.WriteLine("\nForça bruta otimizada com 6 cidades calculado: " + b6);
            ForcaBrutaOtimizacao b7 = new ForcaBrutaOtimizacao(7);
            Console.WriteLine("\nForça bruta otimizada com 7 cidades calculado: " + b7);
            ForcaBrutaOtimizacao b8 = new ForcaBrutaOtimizacao(8);
            Console.WriteLine("\nForça bruta otimizada com 8 cidades calculado: " + b8);
            ForcaBrutaOtimizacao b9 = new ForcaBrutaOtimizacao(9);
            Console.WriteLine("\nForça bruta otimizada com 9 cidades calculado: " + b9);
            ForcaBrutaOtimizacao b10 = new ForcaBrutaOtimizacao(10);
            Console.WriteLine("\nForça bruta otimizada com 10 cidades calculado: " + b10);
            ForcaBrutaOtimizacao b11 = new ForcaBrutaOtimizacao(11);
            Console.WriteLine("\nForça bruta otimizada com 11 cidades calculado: " + b11);
            ForcaBrutaOtimizacao b12 = new ForcaBrutaOtimizacao(12);
            Console.WriteLine("\nForça bruta otimizada com 12 cidades calculado: " + b12);
            ForcaBrutaOtimizacao b13 = new ForcaBrutaOtimizacao(13);
            Console.WriteLine("\nForça bruta otimizada com 13 cidades calculado: " + b13);
            ForcaBrutaOtimizacao b14 = new ForcaBrutaOtimizacao(14);
            Console.WriteLine("\nForça bruta otimizada com 14 cidades calculado: " + b14);
            ForcaBruta a14 = new ForcaBruta(14);
            Console.WriteLine("\nForça bruta com 14 cidades calculado: " + a14);
            //ForcaBrutaOtimizacao b15 = new ForcaBrutaOtimizacao(15);
            //ForcaBrutaOtimizacao b20 = new ForcaBrutaOtimizacao(20);
            //ForcaBrutaOtimizacao b25 = new ForcaBrutaOtimizacao(25);
            //ForcaBrutaOtimizacao b30 = new ForcaBrutaOtimizacao(30);

            AlgoritmoOn2 c3 = new AlgoritmoOn2(3);
            Console.WriteLine("\nAlgoritmo O(n^2) com 3 cidades calculado: " + c3);
            AlgoritmoOn2 c4 = new AlgoritmoOn2(4);
            Console.WriteLine("\nAlgoritmo O(n^2) com 4 cidades calculado: " + c4);
            AlgoritmoOn2 c5 = new AlgoritmoOn2(5);
            Console.WriteLine("\nAlgoritmo O(n^2) com 5 cidades calculado: " + c5);
            AlgoritmoOn2 c6 = new AlgoritmoOn2(6);
            Console.WriteLine("\nAlgoritmo O(n^2) com 6 cidades calculado: " + c6);
            AlgoritmoOn2 c7 = new AlgoritmoOn2(7);
            Console.WriteLine("\nAlgoritmo O(n^2) com 7 cidades calculado: " + c7);
            AlgoritmoOn2 c8 = new AlgoritmoOn2(8);
            Console.WriteLine("\nAlgoritmo O(n^2) com 8 cidades calculado: " + c8);
            AlgoritmoOn2 c9 = new AlgoritmoOn2(9);
            Console.WriteLine("\nAlgoritmo O(n^2) com 9 cidades calculado: " + c9);
            AlgoritmoOn2 c10 = new AlgoritmoOn2(10);
            Console.WriteLine("\nAlgoritmo O(n^2) com 10 cidades calculado: " + c10);
            AlgoritmoOn2 c15 = new AlgoritmoOn2(15);
            Console.WriteLine("\nAlgoritmo O(n^2) com 15 cidades calculado: " + c15);
            AlgoritmoOn2 c20 = new AlgoritmoOn2(20);
            Console.WriteLine("\nAlgoritmo O(n^2) com 20 cidades calculado: " + c20);
            AlgoritmoOn2 c25 = new AlgoritmoOn2(25);
            Console.WriteLine("\nAlgoritmo O(n^2) com 25 cidades calculado: " + c25);
            AlgoritmoOn2 c30 = new AlgoritmoOn2(30);
            Console.WriteLine("\nAlgoritmo O(n^2) com 30 cidades calculado: " + c30);

            //using (StreamWriter csv = new StreamWriter("Resultados.csv"))
            //{
            //    csv.WriteLine("Quantidade de cidades;Forca Bruta (ms);O(1,26^n) (ms);O(n^2)");

            //    csv.WriteLine(string.Format("3;{0};{1};{2}", a3.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("4;{0};{1};{2}", a4.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("5;{0};{1};{2}", a5.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("6;{0};{1};{2}", a6.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("7;{0};{1};{2}", a7.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("8;{0};{1};{2}", a8.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("9;{0};{1};{2}", a9.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("10;{0};{1};{2}", a10.tempoGasto, b3.tempoGasto, c3.tempoGasto));
            //    csv.WriteLine(string.Format("15;{0};{1};{2}", /*a15.tempoGasto,*/"Nao testado", /*b3.tempoGasto,*/"Nao testado", c3.tempoGasto));
            //    csv.WriteLine(string.Format("20;{0};{1};{2}",/* a20.tempoGasto,*/"Nao testado", /*b3.tempoGasto,*/"Nao testado", c3.tempoGasto));
            //    csv.WriteLine(string.Format("25;{0};{1};{2}",/* a25.tempoGasto,*/"Nao testado", /*b3.tempoGasto,*/"Nao testado", c3.tempoGasto));
            //    csv.WriteLine(string.Format("30;{0};{1};{2}",/* a30.tempoGasto,*/"Nao testado", /*b3.tempoGasto,*/"Nao testado", c3.tempoGasto));
            //}            

            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("Resultados salvos no arquivo \"Resultados.csv\"");
            //Console.Write("Pressione qualquer tecla para continuar...");
            //Console.ReadKey();
        }
    }
}
