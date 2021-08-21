using System;
using System.Collections.Generic;

namespace Taller_66_Dictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 66 - Colecciones - Dictionary ---------------------\n");

            Dictionary<string , int > edades = new Dictionary<string, int>();    // Declarar una Lista (Coleeccion de Tipo Dictionary).

            // Rellenando o Agregando Elementos a la Dictionary 

            Console.WriteLine("--------------- Agregando Elementos a La Coleccion - Dictionary ---------------\n");

            edades.Add("Manuel", 34);

            edades.Add("Alberto", 25);

            edades.Add("Jose", 56);

            edades.Add("Genoveva", 90);

            edades.Add("Anselmo", 12);

            edades.Add("Virgelina", 62);

            edades.Add("Ermenegildo", 22);

            edades.Add("Petronia", 17);

            edades.Add("Maria", 48);

            edades["Victoria"] = 29;

            edades["Antonella"]= 8;

            Console.WriteLine("--------------- Ciclo foreach - Recorriendo Elementos de La Coleccion - Dictionary ---------------\n");

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre = {0} Edad = {1} ", persona.Key, persona.Value);
            }

            Console.WriteLine("--------------- Removiendo Elementos de - Dictionary ---------------\n");
            
            edades.Remove("Maria");

            foreach (KeyValuePair<string, int> persona in edades)
            {
                Console.WriteLine("Nombre = {0} Edad = {1} ", persona.Key, persona.Value);
            }

            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }
}
