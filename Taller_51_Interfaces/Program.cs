using System;

namespace Taller_51_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- Taller 51 - Caso Práctico INTERFACES ----------------------- \n");

            AvisosTrafico Aviso1 = new AvisosTrafico();

            Aviso1.mostrarAviso();
            
            Console.WriteLine();

            AvisosTrafico Avisos2 = new AvisosTrafico("OJO: Ha Cometido La Infracción : CRUCE CON SEMAFORO EN ROJO", "AUTORIDAD DE TRANSITO Y TRANSPORTE DE COLOMBIA", "Jueves 29 Julio 2021");

            Console.WriteLine("Fecha Aviso: "+Avisos2.getFecha());

            Avisos2.mostrarAviso();





        }
    }
}
