using System;
using System.Collections.Generic;

namespace Viajante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o numero de cidades: ");
            int cidades = int.Parse(Console.ReadLine());
            //Caminho c = new Caminho(cidades);
                                   

            Caminho a = new Caminho(cidades);
            Console.WriteLine("TESTE: "+a);

            //foreach (var item in allPaths)
            //{                
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }        
    }
}
