using System;
using System.Collections.Generic;

namespace Taller_66_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 66 - Colecciones - Stacks And Dictionary ---------------------\n");

            Stack<int> numeros = new Stack<int>();    // Declarar una Lista (Coleeccion de Tipo Stack).

            // Rellenando o Agregando Elementos a la Stack

            Console.WriteLine("--------------- Ciclo foreach - Agregando Elementos a La Coleccion - Stacks ---------------\n");

            foreach (int num in new int[6] { 10, 8, 6, 4, 2, 0 })
            {

                numeros.Push(num);

            }

            Console.WriteLine("--------------- Ciclo foreach - Recorriendo Elementos de La Coleccion - Stacks ---------------\n");

            foreach (int x in numeros)
            {
                Console.WriteLine("El Elemento de La LikedList = {0}", x);
            }

            Console.WriteLine("--------------- Removiendo Elementos de - Stacks ---------------\n");

            numeros.Pop();

            foreach (int x in numeros)
            {
                Console.WriteLine("El Elemento de La Stacks = {0}", x);
            }

            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }
}
