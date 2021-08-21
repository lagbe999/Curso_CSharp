using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Taller_108_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________ Taller C# - 108 Threads _______________________ ");

            Console.WriteLine();

            Thread t1 = new Thread(MetodoSaludo);

            t1.Start();

            Thread t2 = new Thread(MetodoSaludo);

            t2.Start();

            Console.WriteLine("_______________________ Ejercicio 1 _______________________ ");

            Console.WriteLine();

            Console.WriteLine(" Ejemplo Tareas 1 - Threads 1");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 2 - Threads 1");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 3 - Threads 1");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 4 - Threads 1");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 5 - Threads 1");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 6 - Threads 1");

            Thread.Sleep(500);

            //MetodoSaludo();

        }

        static void MetodoSaludo()
        {

            Console.WriteLine();

            Console.WriteLine("_______________________ Ejercicio 2 _______________________ ");

            Console.WriteLine();

            Console.WriteLine(" Ejemplo Tareas 1 - Threads 2");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 2 - Threads 2");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 3 - Threads 2");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 4 - Threads 2");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 5 - Threads 2");

            Thread.Sleep(500);

            Console.WriteLine(" Ejemplo Tareas 6 - Threads 2");

            Thread.Sleep(500);

        }




    }
}
