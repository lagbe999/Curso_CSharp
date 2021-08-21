using System;

namespace Taller_55_PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("             Taller C# - Propiedades / Acceso");
            Console.WriteLine("----------------------------------------------------------------\n");

            Console.WriteLine("             Ejemplo sin Utilizar - Propiertys ");
            Empleado ObjEmpleado = new Empleado("Eugenio");

            ObjEmpleado.SALARIO = 1200;

            Console.WriteLine("El Salario es "+ ObjEmpleado.SALARIO);

            ObjEmpleado.SALARIO += 300;

            Console.WriteLine("El Salario con Bonificacion es " + ObjEmpleado.SALARIO);



        }
    }


    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        /*
        public void setSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El Salario No Puede Ser Negativo. Se Asignara Cero Como Salario.");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }

        }

        public double getSalario()
        {
            return salario;
        }
        */

        private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }


        // Creacion de Propiedades
        // 
        /*
        public double SALARIO
        {
            get { return this.salario; }

            set { this.salario= evaluaSalario(value); }
        }
        */
        // Creacion de Propiedades - Simplificar con Expressions Bodies - Lambda
        public double SALARIO
        {
            get => this.salario;

            set => this.salario = evaluaSalario(value);
        }

        private double salario;

        private string nombre;

    }
}