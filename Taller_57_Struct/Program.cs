using System;

namespace Taller_57_Structuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("             Taller 57 C# - Struct");
            Console.WriteLine("----------------------------------------------------------------\n");

            Empleado ObjEmpleado = new Empleado(1200, 500);

            Console.WriteLine("El Salario es " + ObjEmpleado.salarioBase);

            Console.WriteLine("La Comisión es " + ObjEmpleado.comision);

            Console.WriteLine("El Salario con Comisión es " + (ObjEmpleado.salarioBase+ObjEmpleado.comision));

            Empleado ObjEmpleado1 = new Empleado(1400, 120);

            ObjEmpleado1.CambiaSalario(ObjEmpleado1, 250);

            Console.WriteLine("===>"+ObjEmpleado1);

            Console.WriteLine("El Salario es " + ObjEmpleado1.salarioBase);

            Console.WriteLine("La Comisión es " + ObjEmpleado1.comision);

            Console.WriteLine("El Salario con Comisión es " + (ObjEmpleado1.salarioBase + ObjEmpleado1.comision));


        }
    }


    public struct  Empleado
    //class Empleado
    {
        public double salarioBase, comision;
        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision;
        }

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            emp.comision += incremento;

        }
    }
}