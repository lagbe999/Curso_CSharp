using System;
using System.IO;


namespace Taller_59_Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Taller C# 59 - Destructores ------------------ \n");

            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.Mensaje();
            
            
            
            
            Console.WriteLine("----------------------------------------------------------------- \n");
        }
    }


    class ManejoArchivos
    {
        StreamReader archivo = null;

        int Contador = 0;

        string linea;

        public ManejoArchivos()
        {
           archivo = new StreamReader(@"D:\LAGBE\Herramientas\Desarrollo\Lenguajes de Programacion\Plataforma .Net\C#\Taller_59_Destructores.txt");
        
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                Contador ++;
            }
        }

        public void Mensaje()
        {

            Console.WriteLine("Hay {0} Lineas", Contador);

        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
