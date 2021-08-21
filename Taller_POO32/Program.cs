using System;

using static System.Math;

namespace Taller_POO32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller POO - Modularizacion de Clases ");

            //realizarTarea();

            double raiz = Math.Sqrt(9);

            double potencia = Math.Pow(3, 4);

            Console.WriteLine($"Raiz Cuadrada de 9 = {raiz}");

            Console.WriteLine($"Potencia 4 de 3 = {potencia}");

            var miVariable = new {Nombre="Juan", Apellido="De La Cosa", Edad=18};

            Console.WriteLine("Nombre: " + miVariable.Nombre + " Apellido: " + miVariable.Apellido + " Edad: " + miVariable.Edad);

            var miOtraVariable = new {Nombre= "Genoveba", Apellido = "Castillo", Edad = 38};

            Console.WriteLine("Nombre: " + miOtraVariable.Nombre + " Apellido: " + miOtraVariable.Apellido + " Edad: " + miOtraVariable.Edad);

            miVariable = miOtraVariable;

            Console.WriteLine("Nombre: " + miVariable.Nombre + " Apellido: " + miVariable.Apellido + " Edad: " + miVariable.Edad);

        }



        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.Distancia(destino);

            Console.WriteLine($"La Distancia entre los puntos es de {distancia}");

            Console.WriteLine($"Número de Objetos Creados: {Punto.ObtenerContadorObj()}");








        }

    }
}
