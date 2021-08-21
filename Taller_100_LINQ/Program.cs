using System;
using System.Collections.Generic;
using System.Linq;

namespace Taller_100_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller C# - 100 - Manejo de LINQ");
            Console.WriteLine();
            Console.WriteLine("Ejercicio Numeros Pares SIN USAR LINQ");
            Console.WriteLine();

            int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10};

            Console.WriteLine("Números Pares ");

            List<int> numerosPares = new List<int>();

            foreach(int i in valoresNumericos)
            {
                if (i % 2 == 0)
                {
                    numerosPares.Add(i);
                }
            }

            foreach(int i in numerosPares)
            {
                Console.WriteLine("Numeros pares=" + i);
            }

            Console.WriteLine();
            Console.WriteLine("Ejercicio Numeros Pares USANDO LINQ");
            Console.WriteLine();

            IEnumerable<int> numerosPar = from numero in valoresNumericos where numero % 2 == 0 select numero; 



            foreach (int i in numerosPar)
            {
                Console.WriteLine("Numeros pares=" + i);
            }

        }
    }
}
