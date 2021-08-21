using System;

namespace Taller_46_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- Taller C# 46 - Herencia ----------------------- \n");

            Console.WriteLine("----------------------- Probando el Avion ----------------------- ");

            Avion miAvion = new Avion("Iberia");

            miAvion.ArrancarMotor("TrakkkkaaTrakakakakakakaka");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("UUffffffffZZzzzzzzz");

            Console.WriteLine("---------------------------------------------------------------------------- \n");

            Console.WriteLine("----------------------- Probando el Coche ----------------------- ");

            Coche miCoche = new Coche("Hyundai");

            miCoche.ArrancarMotor("GruuuuummmGruuuummmmm");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("ZZZZiiiiiiipppp");

            Console.WriteLine("---------------------------------------------------------------------------- \n");

            Console.WriteLine("----------------------- Polimorfismo en Acción---------------------------------------- \n");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();


        }
    }

    class Vehiculo
    {
        public Vehiculo(string nombre)
        {
            nombreVehiculo = nombre;
        }
        public void ArrancarMotor(string sonidoMotor)
        {
            Console.WriteLine("Soy de La Clase Vehiculo y Soy Capaz de Arrancar Motor "+sonidoMotor);
        }

        public virtual void Conducir()    // Virtual Indica que todas las SubClases deberan tener un metodo Conducir pero con alguna modificacion.
        {
            Console.WriteLine("Soy de La Clase Vehiculo y Puedo Ser Conducido ");
        }

        public void PararMotor(string sonidoMotor)
        {
            Console.WriteLine("Soy de La Clase Vehiculo y Soy Capaz de Parar Motor "+sonidoMotor);
        }

        public void getNombre()
        {
            Console.WriteLine("El Nombre del Vehiculo es " + nombreVehiculo);
        }
        private string nombreVehiculo;
    }

    class Avion : Vehiculo
    {
        public Avion(string nombreAvion) : base(nombreAvion)
        {
            Console.WriteLine("El Nombre del Avion es " + nombreAvion);
        }

        public void Aterrizar()
        {
            Console.WriteLine("Soy de Clase Avion y Estoy Aterrizando ");
        }


        public void Despegar()
        {
            Console.WriteLine("Soy de Clase Avion y Estoy Despegando ");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Soy un Avion y Estoy Surcando Los Cielos del Globo Terraqueo");
        }

    }



    class Coche : Vehiculo
    {

        public Coche(string nombreCoche) : base(nombreCoche)
        {
            Console.WriteLine("El Nombre del Coche es " + nombreCoche);
        }

        public void Acelerar()
        {
            Console.WriteLine("Soy de Clase Coche y Estoy Acelarando ");
        }

        public void Frenar()
        {
            Console.WriteLine("Soy de Clase Coche y Estoy Frenando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Soy Un Coche y Estoy Recorriendo La Carretera");
        }

    }
}
