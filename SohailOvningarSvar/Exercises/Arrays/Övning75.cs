using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning75
    {
        public void Print()
        {
            Console.WriteLine(@"
Övn75: Skapa en array med fem heltal, beräkna summan av alla positiva och alla negativa tal och skriv ut dem.

   Med följande värden i en array:
   2, -3, -5, 8, 10
   så måste printen se ut på följande sätt:

   The sum of all positive nrs are: 20
   The sum of all negative nrs are: -8");
            Console.WriteLine();

            int[] intArray = { 2, -3, -5, 8, 10 };
            int sumPositive = 0;
            int sumNegative = 0;

            foreach (int element in intArray)
            {
                if (element > 0)
                {
                    sumPositive += element;
                }
                else
                {
                    sumNegative += element;
                }
            }
            Console.WriteLine($"The sum of all positive numbers is: {sumPositive}");
            Console.WriteLine($"The sum of all negative numbers is: {sumNegative}");
            Console.ReadKey();
        }
    }
}
