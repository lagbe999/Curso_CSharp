using System;

namespace Taller_Arrays_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller 36 - Arrays");

            int[] edades = new int[8] { 23, 45, 78, 41, 56, 21, 69, 34 };

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Elemnto [{i}] Edad = {edades[i]}");
            }

            // Array Implicto

            var datos = new[] { "Marc", "Anthony", "Puerto Rico", "Cantante" };

            var valores = new[] { 15, 28, 35, 45.63, 30.56 }; // Todos los Elementos son de Tipo Double


            // Array de Objetos


            Empleados[] arrayEmpleados = new Empleados[3];

            Empleados Ana = new Empleados("Ana", 45);

            arrayEmpleados[0] = new Empleados("Sara", 34);

            arrayEmpleados[1] = new Empleados("Jose", 13);

            arrayEmpleados[2] = Ana;


            // Arrays de Tipos o Clases Anonimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=23},
                new{Nombre="Maria", Edad= 49},
                new{Nombre="Pedro", Edad=27}

            };

            Console.WriteLine(personas[1]);

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Recorriendo Array Valores\n");

                Console.WriteLine($"Elemento [{i}] = {valores[i]}");

            }

            /* for (int j = 0; j < arrayEmpleados.Length; j++) 
             {
                 Console.WriteLine("Recorriendo Array arrayEmpleados\n");

                 Console.WriteLine($"Elemento [{j}] = {arrayEmpleados[j].getInfoArray()}");

             }*/

            foreach (Empleados variable in arrayEmpleados)
            {
                Console.WriteLine("Recorriendo Foreach ArrayEmpleado\n");

                Console.WriteLine(variable.getInfoArray());

            }

            foreach (double variable in valores)
            {
                Console.WriteLine("Recorriendo Foreach ArrayValores\n");

                Console.WriteLine(variable);

            }

            foreach (var variable in personas)
            {
                Console.WriteLine("Recorriendo Foreach ArrayPersonas\n");

                Console.WriteLine(variable);

            }



        }



        class Empleados
        {
            public Empleados(string nombre, int edad)
            {
                this.nombre = nombre;

                this.edad = edad;

            }

            public string getInfoArray()
            {
                return "Nombre del Emoleado: " + nombre + " Edad: " + edad;
            }

            private string nombre;

            private int edad;


        }
    }
}


