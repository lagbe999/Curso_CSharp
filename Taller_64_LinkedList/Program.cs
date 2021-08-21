using System;
using System.Collections.Generic;

namespace Taller_64_LinkedList  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 64 - Colecciones - LikedList ---------------------\n");

            LinkedList<int> numeros = new LinkedList<int>();    // Declarar una Lista (Coleeccion de Tipo LikedList).

            Console.WriteLine("--------------- Ciclo foreach - recorriendo Colecciones - LikedList ---------------\n");

            foreach (int num in new int[] {10, 8, 6, 4, 2, 0 })
            {
                //numeros.AddFirst(num);    // Agrega a la Lista en Orden Ascendente

                numeros.AddLast(num);    // Agrega a la Lista en Orden Descendente

            }

            foreach (int x in numeros)
            {
                Console.WriteLine("El Elemento de La LikedList = {0}", x);
            }

            Console.WriteLine("--------------- Ciclo for - recorriendo Colecciones con Nodo - LikedList ---------------\n");

            for (LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo=nodo.Next)
            {
                int num = nodo.Value;

                Console.WriteLine(num);

            }

            Console.WriteLine("--------------- Removiendo Elementos de Colecciones con Nodo - LikedList ---------------\n");

            numeros.Remove(6);

            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int num = nodo.Value;

                Console.WriteLine(num);

            }

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numeros.AddFirst(nodoImportante);

            for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {
                int num = nodo.Value;

                Console.WriteLine(num);

            }



            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }
}
