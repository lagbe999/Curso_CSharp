using System;

namespace Taller_48_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller C# 48 - Herencia\n");

            Caballo ObjCaballo = new Caballo("Rocinante");

            Humano ObjHumano = new Humano("Juan");

            Gorila ObjGorila = new Gorila("Chita");

            ObjCaballo.Galopar();

            ObjHumano.Pensar();

            ObjGorila.Trepar();

            ObjCaballo.getNombre();

            ObjHumano.getNombre();

            ObjGorila.getNombre();



            // ------------------ Principio de Sustitucion / Herencia --------------------------

            Console.WriteLine("Taller C# 48 - Herencia - Interfaces\n");

            Mamiferos animal = new Caballo("Bucefalo");

            Mamiferos persona = new Humano("Manuel");

            Mamiferos ObjMamiferos = new Mamiferos("Engendro");

            Caballo ObjCebra = new Caballo("Juventus");

            ObjMamiferos = ObjCebra;   // AQUI Se Aplica el Principio de Sustitucion 

            Object miAnimal = new Caballo("Platinum");

            Object miPersona = new Humano("José");

            Object miGorila = new Gorila("Makacus");

            Mamiferos[] collecionAnimales = new Mamiferos[3];

            collecionAnimales[0] = ObjCaballo;

            collecionAnimales[1] = ObjHumano;

            collecionAnimales[2] = ObjGorila;

            collecionAnimales[1].getNombre();

            // ------------------Fin Principio de Sustitucion--------------------------

            // ------------------ Principio de Polimorfismo / Herencia --------------------------

            Console.WriteLine("Taller C# 48 - Herencia - Polimorfismo\n");

            for (int i = 0; i < 3; i++)
            {
                collecionAnimales[i].Pensar();
            }
            Ballena ObjBallena = new Ballena("Wally");

            ObjBallena.Nadar();

            // ------------------ Fin Principio de Polimorfismo / Herencia --------------------------

            // ------------------ Herencia / Interfaces --------------------------

            Console.WriteLine("---------------------------------------------------------------------------\n");

            Console.WriteLine("Taller C# 48 - Herencia - Intefaces\n");

            Console.WriteLine("---------------------------------------------------------------------------\n");

            Caballo miCaballo = new Caballo("Champion");
           
            IMamiferosTerrestres ImamiferosTerrestres = miCaballo;

            ISaltoConPatas ISaltoConPatas = miCaballo;

            Console.WriteLine($"Número de Patas de miCaballo = {ImamiferosTerrestres.numeroPatas()}");

            Console.WriteLine($"Número de Patas Usadas Para Salto de miCaballo = {ISaltoConPatas.numeroPatas()}");


            Console.WriteLine("---------------------------------------------------------------------------\n");

        }
    }

    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }
    class Mamiferos
    {
        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public void Respirar()
        {
            Console.WriteLine("Soy de La Clase Mamifero y Soy Capaz de Respirar");
        }

        public virtual void Pensar()    // Virtual Indica que todas las SubClases deberan tener un metodo Pensar pero con alguna modificacion.
        {
            Console.WriteLine("Soy de La Clase Mamiferos y Tengo Pensamiento Básico Instintivo ");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Soy de La Clase Mamifero y Soy Capaz de Cuidar Mis Crias");
        }

        public void getNombre()
        {
            Console.WriteLine("El Nombre del Ser Vivo es " + nombreSerVivo);
        }
        private string nombreSerVivo;
    }


    class Ballena  : Mamiferos
    {
        public Ballena(string nombreBallena):base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy una Ballena y Soy Capaz de Nadar");
        }

    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Soy de Clase CABALLO y Soy Capaz de Galopar");
        }

        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }

    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public override void Pensar()   // Override Indica que este Metodo es una MODIFICACION del Metodo Pensar Heredado de la SuperClase Mamiferos.
        {
            Console.WriteLine("Soy de Clase HUMANO y Soy Capaz de Pensar");
        }

    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public override void Pensar() // Override Indica que este Metodo es una MODIFICACION del Metodo Pensar Heredado de la SuperClase Mamiferos.
        {
            Console.WriteLine("Soy de Clase GORILA y Tengo Pensamiento Instintivo Avanzado");
        }
        public void Trepar()
        {
            Console.WriteLine("Soy de Clase GORILA y Soy Capaz de Trepar");

        }

        public int numeroPatas()
        {
            return 2;
        }
    }
}
