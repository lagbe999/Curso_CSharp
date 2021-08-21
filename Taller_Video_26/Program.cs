using System;

namespace Taller_Video_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manejo de Excepciones con Finally - Apertura de Ficheros");

            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"D:\LAGBE\Herramientas\Desarrollo\Lenguajes de Programacion\Plataforma .Net\C#\Prueb_Apertura_ficheros.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error cpn La Lectura del Archivo"+e.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexión con el Fichero Cerrada");
            }

        }
    }
}
