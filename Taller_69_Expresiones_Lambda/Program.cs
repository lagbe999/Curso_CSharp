using System;
using System.Collections.Generic;

namespace Taller_69_Expresiones_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 69 - Expresiones Lambda ---------------------\n");

            Console.WriteLine("--------------------- Ejercicio - Numeros Pares ---------------------\n");

            // Uso del Delegado
            operacionesMath operacion = new operacionesMath(Cuadrado);

            Console.WriteLine("Ingresa el Número Que Desea Elevar al cuadrado :");

            int num2 = (int.Parse(Console.ReadLine()));

            Console.WriteLine("El Cuadrado de {0} = {1}", num2, operacion(num2));

            //Simplificando este Metodo con Expresiones Lambda

            operacionesMath operaciones = new operacionesMath(num2 => num2 * num2);

            Console.WriteLine("--------------------- Ejercicio - Con Expresion Lambda ---------------------\n");

            Console.WriteLine("El Cuadrado de {0} = ", num2, operaciones(num2));

            Console.WriteLine("--------------------- Ejercicio - Delegado con 2 Parametros ---------------------\n");

            // Uso del Delegado
            DelegadoSumar  operacionSuma = new DelegadoSumar(Suma);

            Console.WriteLine("Ingrese Numero1 = ");

            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Numero2 = ");
 
            int numero2 = int.Parse(Console.ReadLine());

            operacionSuma(numero1, numero2);

            Console.WriteLine("{0} + {1} = {2}", numero1, numero2, operacionSuma(numero1, numero2));

            Console.WriteLine("--------------------- Ejercicio - Delegado con 2 Parametros con Expresion Lambda ---------------------\n");

            // Uso del Delegado

            Console.WriteLine("Ingrese Numero1 = ");

            int numera1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Numero2 = ");

            int numera2 = int.Parse(Console.ReadLine());

            DelegadoSumar operaSuma = new DelegadoSumar((num1, num2) => num1 + num2);

            operacionSuma(numero1, numero2);

            Console.WriteLine("{0} + {1} = {2}", numera1, numera2, operacionSuma(numera1, numera2));

            Console.WriteLine("--------------------- Ejercicio - Lista Array de numeros con Expresion Lambda ---------------------\n");

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14};

            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            Console.WriteLine("--------------------- Lista de Valores del Array ---------------------\n");

            foreach (int num in numeros)
            {
                Console.WriteLine("Valor = {0}", num);
            }

            //Con Expresiones lambda Seria asi:
            Console.WriteLine("--------------------- Simplificado con Lambda ---------------------\n");
            numeros.ForEach(numero => Console.WriteLine("Valor = {0}", numero));


            Console.WriteLine("--------------------- Lista de Valores Pares del Array ---------------------\n");

            foreach (int num in numerosPares)
            {
                Console.WriteLine("Valor = {0}", num);
            }
            //Con Expresiones lambda Seria asi:
            Console.WriteLine("--------------------- Simplificado con Lambda ---------------------\n");
            numerosPares.ForEach(numero => Console.WriteLine("Valor = {0}", numero));



            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }

        public delegate int operacionesMath(int num);

        public delegate int DelegadoSumar(int num1, int num2);

        public static int Cuadrado(int num)
        {
            return num * num;
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

   
        class Personas
        {

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }

            private string nombre;

            private int edad;

        }
    }

}
