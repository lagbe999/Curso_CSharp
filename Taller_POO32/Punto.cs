using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_POO32
{
    class Punto
    {
        public Punto(int x, int y)
        {

            //Console.WriteLine($"Coordena X: {x}, Coordenada Y: {y}");

            this.x = x;

            this.y = y;

            contadorDeObjetos++;

        }

        public Punto()
        {
            //Console.WriteLine("Este es el Constructor por defecto");

            this.x = 0;

            this.y = 0;

            contadorDeObjetos++;

        }


        public double Distancia (Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;

        }

        /* public static int ObtenerContador()
        {
            return contadorDeObjetos;
        }
        */

        public static int ObtenerContadorObj() => contadorDeObjetos;
        
        private int x, y;

        private static int contadorDeObjetos = 0;

        public const int constPrueba = 7;
    }
}
