using System;

namespace Taller_42_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taller C# 42 - Herencia\n");

            Caballo ObjCaballo = new Caballo("Rocinante");

            Humano ObjHumano = new Humano("Juan");

            Gorila ObjGorila= new Gorila("Chita");

            ObjCaballo.Galopar();

            ObjHumano.Pensar();

            ObjGorila.Trepar();

            ObjCaballo.getNombre();

            ObjHumano.getNombre();

            ObjGorila.getNombre();



            // ------------------ Principio de Sustitucion / Herencia --------------------------

            Console.WriteLine("Taller C# 42 - Herencia - Principio de Sustitucón\n");

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

            Console.WriteLine("Taller C# 42 - Herencia - Polimorfismo\n");

            for (int i = 0; i < 3; i++)
            {
                collecionAnimales[i].Pensar();
            }

            // ------------------ Fin Principio de Polimorfismo / Herencia --------------------------

        }
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
            Console.WriteLine("El Nombre del Ser Vivo es "+nombreSerVivo);
        }
        private string nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) 
        {
        
        }

        public void Galopar()
        {
            Console.WriteLine("Soy de Clase CABALLO y Soy Capaz de Galopar");
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

    class Gorila : Mamiferos
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


    }
}
