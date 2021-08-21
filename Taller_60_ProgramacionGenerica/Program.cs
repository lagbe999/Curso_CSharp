using System;

namespace Taller_60_ProgramacionGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 60 - Programación Generica ---------------------\n");

            Console.WriteLine("--------------------- Instanciando Objetos de Tipo String ----------------------\n");

            AlmacenObjetos archivos = new AlmacenObjetos(4);
            /*
            archivos.Agregar("Juan");

            archivos.Agregar("Pepito");

            archivos.Agregar("Jose");

            archivos.Agregar("Maruja");

            string nombrePersona = (string)archivos.getElemento(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", nombrePersona);
            */
            Console.WriteLine("--------------------- Instanciando Objetos de Tipo Empleado ----------------------\n");

            archivos.Agregar(new Empleado(1500));
 
            archivos.Agregar(new Empleado(1400));
            
            archivos.Agregar(new Empleado(1100));
            
            archivos.Agregar(new Empleado(500));

            Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", salarioEmpleado.getSalario());





            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }

    class AlmacenObjetos
    {
        public AlmacenObjetos(int z)
        {

            datosElemento = new Object[z];


        }

        public void Agregar(Object obj)
        {
            datosElemento[i] = obj;

            i++;

        }

        public Object getElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;

        private int i = 0;

    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario= salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;

    }

}
