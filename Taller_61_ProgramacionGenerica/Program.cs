using System;

namespace Taller_61_ProgramacionGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 61 - Programación Generica ---------------------\n");

            Console.WriteLine("--------------------- Instanciando Objetos de Tipo String ----------------------\n");
            /*
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);
            
            archivos.Agregar("Juan");

            archivos.Agregar("Pepito");

            archivos.Agregar("Jose");

            archivos.Agregar("Maruja");

            string nombrePersona = (string)archivos.getElemento(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", nombrePersona);
            */
            /*
            
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);
            
            archivos.Agregar(new DateTime());

            archivos.Agregar(new DateTime());

            archivos.Agregar(new DateTime());

            archivos.Agregar(new DateTime());

            DateTime Fecha = archivos.getElemento(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", Fecha);
            //*/


            Console.WriteLine("--------------------- Instanciando Objetos de Tipo Empleado ----------------------\n");

            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

            archivos.Agregar(new Empleado(1500));

            archivos.Agregar(new Empleado(1400));

            archivos.Agregar(new Empleado(1100));

            archivos.Agregar(new Empleado(500));

            Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", salarioEmpleado.getSalario());
            //*/

            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {

            datosElemento = new T[z];


        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;

            i++;

        }

        public  T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

}
