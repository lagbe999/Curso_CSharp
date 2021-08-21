using System;
using System.Collections.Generic;

namespace Taller_69_Expresiones_lambda_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 69 - Expresiones Lambda Clases ---------------------\n");

            Console.WriteLine("--------------- Ejercicio - Busqueda Nombre Persona en Lista con Predicados -----------\n");

            List<Personas> gente = new List<Personas>();

            Personas P1 = new Personas();

            P1.Nombre = "Jose";

            P1.Edad = 18;

            Personas P2 = new Personas();

            P2.Nombre = "Virgelina";

            P2.Edad = 36;

            Personas P3 = new Personas();

            P3.Nombre = "Juan";

            P3.Edad = 22;

            Personas P4 = new Personas();

            P4.Nombre = "Antonella";

            P4.Edad = 12;

            Personas P5 = new Personas();

            P5.Nombre = "Manuel";

            P5.Edad = 45;

            Personas P6 = new Personas();

            P6.Nombre = "Maria";

            P6.Edad = 48;

            Personas P7 = new Personas();

            P7.Nombre = "Juan";

            P7.Edad = 34;

            Personas P8 = new Personas();

            P8.Nombre = "Martha";

            P8.Edad = 78;

            Personas P9 = new Personas();

            P9.Nombre = "Camilo";

            P9.Edad = 34;

            Personas P10 = new Personas();

            P10.Nombre = "Petronia";

            P10.Edad = 27;

            gente.AddRange(new Personas[] { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10 });


            ComparaEdad igualEdad = new ComparaEdad((persona1, persona2) => persona1 == persona2);

            Console.WriteLine("La Edad de {0} es Igual a La Edadde {1} ?", P7.Nombre, P9.Nombre);

            Console.WriteLine(igualEdad(P7.Edad, P9.Edad));

            Console.WriteLine("La Edad de {0} es Diferente a La Edadde {1} ?", P3.Nombre, P8.Nombre);

            ComparaEdad difrenteEdad = new ComparaEdad((persona1, persona2) => persona1 != persona2);

            Console.WriteLine(difrenteEdad(P3.Edad, P8.Edad));

            ComparaNombre igualNombre = new ComparaNombre((nomb1, nomb2) => nomb1 == nomb2);

            Console.WriteLine("El nombre de {0} es Igual a {1} ?", P7.Nombre, P9.Nombre);

            Console.WriteLine(igualNombre(P7.Nombre, P9.Nombre));


            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }

        public delegate bool ComparaEdad(int edad1, int edad2);

        public delegate bool ComparaNombre(string nombre1, string nombre2);


        class Personas
        {

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }

            private string nombre;

            private int edad;

        }
    }

}
