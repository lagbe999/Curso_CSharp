using System;
using System.Collections.Generic;

namespace Taller_68_Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 68 - Predicados ---------------------\n");

            Console.WriteLine("--------------------- Ejercicio - Numeros Pares ---------------------\n");

            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Declaramos Delegado Predicado
            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            foreach(int num in numPares)
            {
                Console.WriteLine(num); 
            }

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

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            Predicate<Personas> menoresEdad = new Predicate<Personas>(ExisteMenores);

            Predicate<Personas> mayoresEdad = new Predicate<Personas>(ExisteMayores);

            bool existe = gente.Exists(elPredicado);

            bool hayMenores = gente.Exists(menoresEdad);

            bool hayMayores = gente.Exists(mayoresEdad);

            if (existe == true) Console.WriteLine("SI Existe Juan en La Lista");
            else Console.WriteLine("NO Existe Juan en La Lista");

            if (hayMenores == true) Console.WriteLine("SI Hay Menores de Edad en La Lista");
            else Console.WriteLine("NO Hay Menores de Edad en La Lista");

            if (hayMayores== true) Console.WriteLine("SI Hay Mayores de Edad en La Lista");
            else Console.WriteLine("NO Hay Mayores de Edad en La Lista");



            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }

        public static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;

        }

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }

        static bool ExisteMenores(Personas persona)
        {
            if (persona.Edad <18) return true;
            else return false;
        }

        static bool ExisteMayores(Personas persona)
        {
            if (persona.Edad >= 18) return true;
            else return false;
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
