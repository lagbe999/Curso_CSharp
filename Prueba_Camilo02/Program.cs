using System;

namespace Prueba_Camilo02
{
    class Program
    {

        static int[] myArray = { 1, 3, 4, 2, 7, 0 };
        static void Main(string[] args)
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == 10)
                    {
                        Console.WriteLine(myArray[i] + " " + myArray[j]);
                    }
                }
            }
        }
    }
}
