using System;

namespace Taller_62_GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Taller C# 62 - Programación Generica / Restricciones ---------------------\n");

            Console.WriteLine("--------------------- Instanciando Objetos de Tipo String --------------------------------------\n");

            ///*
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(4);
            
            empleados.Agregar(new Director(4500));

            empleados.Agregar(new Director(1500));

            empleados.Agregar(new Director(2700));

            empleados.Agregar(new Director(3200));

            Director nombrePersona = empleados.getEmpleado(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", nombrePersona);
            //*/

            /*
            AlmacenEmpleados<Estudiante> empleados = new AlmacenEmpleados<Estudiante>(4);
            
            empleados.Agregar(new Estudiante(4500));

            empleados.Agregar(new Estudiante(1500));

            empleados.Agregar(new Estudiante(2700));

            empleados.Agregar(new Estudiante(3200));

            Director nombrePersona = empleados.getEmpleado(2);

            Console.WriteLine("El Objeto de La Posicion 2 es {0}", nombrePersona);
            */


            Console.WriteLine("---------------------------------------------------------------------------------\n");
        }
    }


    class AlmacenEmpleados<T> where T:IParaEmpleados
    {
        
        public AlmacenEmpleados(int z)
        {

            datosEmpleado=new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;
         
        private T[] datosEmpleado;




    }
    class Director:IParaEmpleados
    {

        public Director(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Secretaria : IParaEmpleados
    {

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Electricista:IParaEmpleados
    {

        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }


    class Estudiante
    {

        public Estudiante(int edad)
        {
            this.edad = edad;
        }

        public int getEdad()
        {
            return edad;
        }

        private int edad;


    }


    interface IParaEmpleados
    {

        double getSalario();

    }

 



}
