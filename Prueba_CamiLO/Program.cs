using System;

namespace Prueba_CamiLO
{
    class Program
    {
        public static void Main(string[] args)
        {
            int mayorSec = 1;

            int mayorSecAux = 1;

            int numeroMayorSec = 0;


            int numeroAux = 0;

             int[] myArray = { 1, 2, 2, 4, 5, 6, 7, 8, 8, 8};


            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i] == numeroAux)
                {
                    mayorSecAux += 1;

                }
                else
                {
                    mayorSecAux

             = 0;
                }
 





if (mayorSecAux > mayorSec)

                {
                    mayorSec = mayorSecAux;

                    numeroMayorSec = myArray[i];
                }


                numeroAux = myArray[i];

            }


            Console.WriteLine("Longest: " + (mayorSec + 1));

            Console.WriteLine("Number: " + numeroMayorSec);

        }
    }
}
