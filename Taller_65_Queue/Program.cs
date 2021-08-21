using System;
using System.Collections.Generic;

namespace Taller_65_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 65 - Colecciones - Queues ---------------------\n");

            Queue<int> numeros = new Queue<int>();    // Declarar una Lista (Coleeccion de Tipo Queue).

            // Rellenando o Agregando Elementos a la Cola

            Console.WriteLine("--------------- Ciclo foreach - Agregando Elementos a La Coleccion - Queues ---------------\n");

            foreach (int num in new int[6] { 10, 8, 6, 4, 2, 0 })
            {

                numeros.Enqueue(num);

            }

            Console.WriteLine("--------------- Ciclo foreach - Recorriendo Elementos de La Coleccion - Queues ---------------\n");

            foreach (int x in numeros)
            {
                Console.WriteLine("El Elemento de La LikedList = {0}", x);
            }
 
            Console.WriteLine("--------------- Removiendo Elementos de La Cola - Queue ---------------\n");

            numeros.Dequeue();

            foreach (int x in numeros)
            {
                Console.WriteLine("El Elemento de La LikedList = {0}", x);
            }

            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }
}
