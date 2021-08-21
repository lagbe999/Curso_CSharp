using System;
using System.Collections.Generic;

namespace Taller_63_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 63 - Colecciones ---------------------\n");

            List<int> numeros = new List<int>();    // Declarar una Lista (Coleeccion de Tipo Lista).

            numeros.Add(5);

            numeros.Add(7);

            numeros.Add(9);

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Valor del Elemento [{0}] = {1}", i, numeros[i]);
            }

            Console.WriteLine("--------------------- Lista con Arreglos  ---------------------\n");

            int[] listanumeros = new int[] { 3, 6, 8, 10, 50 };

            for(int i = 0; i < 5; i++)
            {

                numeros.Add(listanumeros[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del Arreglo [{0}] = {1}", i, numeros[i]);
            }


            Console.WriteLine("--------------------- Lista de Arreglos con Número Elementos Variable  ---------------------\n");

            Console.WriteLine("Ingresa el Número de Elementos del Array : ");

            int elem = int.Parse(Console.ReadLine());

            List<int> numerosArray = new List<int>();    // Declarar una Lista (Coleeccion de Tipo Lista).
           
            for (int i = 0; i < elem; i++)
            {

                Console.WriteLine("Ingresa el Valor del Arreglo Para el Elemento {0} = ", i);              
                
                numerosArray.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numerosArray.Count; i++)
            {
                Console.WriteLine("Valor del Arreglo [{0}] = {1}", i, numerosArray[i]);
            }

            Console.WriteLine("--------------------- Lista de Arreglos con Foreach  ---------------------\n");

            Console.WriteLine("Ingresa Elementos en La Coleecion (Cero Para Salir) ");

            int indice = 1;

            List<int> elementosColeeccion = new List<int>();    // Declarar una Lista (Coleeccion de Tipo Lista).

            while (indice != 0)
            {
                Console.WriteLine("Ingrese el Valor del Elemento : ");

                indice = int.Parse(Console.ReadLine());

                elementosColeeccion.Add(indice);

            }

            elementosColeeccion.RemoveAt(elementosColeeccion.Count - 1);

            foreach(int x in elementosColeeccion)
            {
                Console.WriteLine("El Valor del Elemento de La Colección = {0}", x);
            }


            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }
}
