using System;

namespace Taller_58_ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------- Taller C# 58 - ENUMERADOS ----------------- ");

            Estaciones Alergia = Estaciones.Primavera;

            Console.WriteLine(Alergia);

            string La_Alergia = Alergia.ToString();

            Console.WriteLine(La_Alergia);

            Console.WriteLine("-------------------------------------------------------------- ");

            Bonus Antonio = Bonus.Bueno;

            double BonusAntonio = (double)Antonio;

            Console.WriteLine(Antonio+" = "+BonusAntonio);

            double salarioAntonio = 1500 + BonusAntonio;

            Console.WriteLine("Salario Antonio = "+salarioAntonio);

            Empleado Juan = new Empleado(Bonus.Extra, 1900.50);

            Console.WriteLine("El Salario del Empleado es "+Juan.getSalario());


        }

    }
    class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonusEmpleado = bonusEmpleado;

            this.salario = salario; 
        }

        public double getSalario()
        {
            return salario + (double)bonusEmpleado;
        }
        private double salario;
        
        private Bonus bonusEmpleado;

    }
    enum Estaciones {Primavera, Otoño, Verano,Invierno };

    enum Bonus {Bajo=500, Normal=1000, Bueno=1500, Extra=3000};


}
