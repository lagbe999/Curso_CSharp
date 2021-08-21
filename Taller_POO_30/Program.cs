using System;

namespace Taller_POO_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller POO - Constructores ");

            Coche objcoche1 = new Coche(); // Crear Objeto o Instancia de Tipo Coche. Dar un estado Inicial  a nuestro coche

            Coche objcoche2 = new Coche();

            Coche objCoche3 = new Coche(4500.23, 2456.12);


            Console.WriteLine("Cantidad Ruedas ObjCoche1 = " + objcoche1.getInfoCoche());

            Console.WriteLine("Cantidad Ruedas ObjCoche2 = " + objcoche2.getInfoCoche());

            Console.WriteLine(objCoche3.getInfoCoche());

            objCoche3.setAccesorios(true, "Tela" );

            Console.WriteLine(objCoche3.getAccesorios());

        }

        partial class Coche
        {
            public Coche()
            {
                ruedas = 4;

                largo = 500.23;

                ancho = 013453.80;

                tapiceria = "Tela";
            }

            public Coche(double largoCoche, double anchoCoche)
            {
                ruedas = 4;

                largo = largoCoche;

                ancho = anchoCoche;

                tapiceria = "Tela";
            }
        }
        //-------------------------Ejemplo de Clase Partial ----------------------------------------------
        partial class Coche
            {

            public string getInfoCoche()
            {
                return "Información del Coche :\n " + "Ruedas: "+ruedas + " Largo: " + largo + " Ancho: " + ancho + " Tapiceria: "+tapiceria;
            } 

            public void setAccesorios(bool climatizador, string tapiceria)
            {
                this.climatizador = climatizador;

                this.tapiceria = tapiceria;
            }

            public string getAccesorios()
            {
                return "Accesorios del Coche \n" + " Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
            }

            private int ruedas;

            private double largo;

            private double ancho;

            private bool climatizador;

            private string tapiceria;

         }

}



    }
