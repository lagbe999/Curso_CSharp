using System;

namespace Taller_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller C# / 40 - Arrays como Parametros de Metodos");

            int[] numeros = new int[4];

            numeros[0] = 12;

            numeros[1] = 34;
            
            numeros[2] = 67;
            
            numeros[3] = 65;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }


            int[] arrayElemntos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el Main - Array Obtenido " );

            foreach(int d in arrayElemntos)
            {
                Console.WriteLine(d);
            }



        }

        static void ProcesaDatos(int[] datos)
        {
            foreach(int i in datos)
            {
                Console.WriteLine("Datos del Array= "+i);
            }

        
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos Elementos Tebdrá el Array?");
            
            int numElementos = int.Parse(Console.ReadLine());

            int[] datosArray = new int[numElementos];

            for(int i = 0; i<numElementos; i++)
            {
                Console.WriteLine($"Ingresa el Valor del Elemento {i+1} =");

                datosArray[i] = int.Parse(Console.ReadLine());
            }
            
            return datosArray;
        }
    }
}
