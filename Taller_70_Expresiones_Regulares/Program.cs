using System;
using System.Text.RegularExpressions;

namespace Taller_70_Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------- Taller C# 70 - Expresiones Regulares ---------------------\n");

            Console.WriteLine("--------------------- Ejercicio - Buscar un Caracter en un Texto ---------------------\n");

            Console.WriteLine();

            string frase = "Mi nombre es Luis Giraldo y mi Numero de Telefono es (+507)6712-3456, (+44)123-45-67, (+34)765-43-21 y mi Código postal es 507";

            string patron = "[J]";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine("--------------------- Ejercicio - Buscar un Digito en un Texto ---------------------\n");

            Console.WriteLine();

            patron = @"\d"; //Busqueda Un Digito con el Patron \d

            Regex miRegex1 = new Regex(patron);

            MatchCollection elMatch1 = miRegex1.Matches(frase);

            if (elMatch1.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine("--------------------- Ejercicio - Buscar un Grupo Digito en un Texto ---------------------\n");

            Console.WriteLine();

            patron = @"\d{3}"; //Busqueda 3 Digito con el Patron \d

            Regex miRegex2 = new Regex(patron);

            MatchCollection elMatch2 = miRegex2.Matches(frase);

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine();

            patron = @"\+34"; //Busqueda la secuencia de caracteres +34 con el Patron \+34

            Console.WriteLine();

            Regex miRegex3 = new Regex(patron);

            MatchCollection elMatch3 = miRegex2.Matches(frase);

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine();

            patron = @"\+34|\+44"; //Busqueda la secuencia de caracteres +34 O la secuencia de caracteres +44 con el Patron \+34|\+44

            Regex miRegex4 = new Regex(patron);

            MatchCollection elMatch4 = miRegex2.Matches(frase);

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine();

            frase = "Mi Web es https://wwww.pildorasinformaticas.es ";

            patron = "https?://(www.)?pildorasinformaticas.es"; //Busqueda la secuencia de caracteres que contengan: http:// o (www.)? y seguidamente pildorasinformaticas.es  

            Regex miRegex5 = new Regex(patron);

            MatchCollection elMatch5 = miRegex2.Matches(frase);

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado el caracter {0} en {1}", patron, frase);
            else Console.WriteLine("No se ha encontrado el caracter {0} en {1}", patron, frase);

            Console.WriteLine();

            //Expresiones Regulares Para Verificar si el Texto es un correo electronico

            Console.WriteLine("Expresiones Regulares - Validando Correo Electronico \n");

            string txt  = "cursos@pildorasinformaticas.es";

            string re1 = ".*?";

            string re2 = "(@)";

            string re3 = ".*?";

            string re4 = "\\.";

            Regex r  = new Regex(re1+re2+re3+re4, RegexOptions.IgnoreCase|RegexOptions.Singleline);

            Match m = r.Match(txt);

            if (m.Success) Console.WriteLine("El Texto SI corresponde a un Correo Electronico");
            else Console.WriteLine("El Texto SI corresponde a un Correo Electronico");



            Console.WriteLine("--------------------------------------------------------------------------------\n");
        }
    }
}
