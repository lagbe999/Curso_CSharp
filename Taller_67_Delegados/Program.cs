using System;
using System.Collections.Generic;

namespace Taller_67_Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 67 - Delegados, Predicados y Lambdas ---------------------\n");

            //Creacion del Objeto Delegdo Apuntando a MensajeBienvenida
            ObjDelegado ElDelegado = new ObjDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilizacion del Objeto Delegado Para llamar al Metodo Saludo Bienvenida.
            ElDelegado("Hola Acabo de Llegar. Que tal Estais?");

            ElDelegado = new ObjDelegado(MensajeBienvenida.SaludoDespedida);

            ElDelegado("Hola, Ya Me voy. Hasta Nunca");

            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }

        // Definicion del Objeto Delegado
        delegate void ObjDelegado(string msg);
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msg)
        {
            Console.WriteLine("Mensaje Bienvenida: {0}",msg);
        }

        public static void SaludoDespedida(string msg)
        {
            Console.WriteLine("Mensaje de Despedida: {0}",msg);
        }

    }
}
