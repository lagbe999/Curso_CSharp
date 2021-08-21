using System;

namespace Taller_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller POO - Clases e Intancias");

            Circulo miCirculo;  // Creación de ojeto de tipo Cicrulo. Variable de objeto de tipo Circulo

            miCirculo = new Circulo();  // Iniciacion de variable/Objeto de tipo Circulo. Instanciar una Clase. Instanciación. Ejemplarizacion. Creación de ejemplar de clae.

            Console.WriteLine("El Area del Circulo = "+miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine("El Area del Circulo2 = " + miCirculo.CalculoArea(7));

            ConversorEuroDolar obj = new ConversorEuroDolar();

            Console.WriteLine("El Cambio de EURO a DOLAR = "+obj.Convierte(12));

            obj.CambiaEuro(1.678);

            Console.WriteLine("El Cambio de EURO a DOLAR = " + obj.Convierte(12));

        }

        class Circulo
        {
            private const double PI  = 3.1416; // Propiedad de la Calse Circulo. Campo de Clase.

            public double CalculoArea(int radio)   // Metodo de Clase. ¿Que pueden hacer los o jetos de tipo Circulo?
            {

                return PI * radio * radio;

            }


        }

        class ConversorEuroDolar
        {

            private double euro = 1.253;

            public double Convierte(double cantidad)
            {
                return cantidad * euro;
            }
            public void CambiaEuro(double nuevovalor)
            {
                if (nuevovalor < 0) nuevovalor = 1.253;
                else 
                    euro = nuevovalor;
            }


        }
    }
}
