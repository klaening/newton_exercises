using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning68
    {
        public void Print()
        {
            Console.WriteLine(@"
Övn68: Skapa en array med fem tal, fördubbla värdet på talen på varje indexplats i arrayn. 
Exempel utprinten ska vara på följande sätt, era värden kan dock variear beroende på siffrorna i eran array, 
får enbart lösas med någon typ av for loop:

Index value is 2, the double value is: 4

     Index value is 3, the double value is: 6
     Index value is 5, the double value is: 10
     Index value is 8, the double value is: 16

Index value is 10, the double value is: 20");
            Console.WriteLine();

            int[] intArray = { 2, 6, 3, 8, 10 };

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Index value is: {intArray[i]}, the double value is: {intArray[i] * 2}");
                    Console.WriteLine();
                }
                else if (i == intArray.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Index value is: {intArray[i]}, the double value is: {intArray[i] * 2}");
                }
                else
                Console.WriteLine($"    Index value is: {intArray[i]}, the double value is: {intArray[i] * 2}");
            }
            Console.ReadKey();
        }
    }
}
