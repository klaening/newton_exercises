using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning69
    {
        public void Print()
        {
            Console.WriteLine(@"    
Övn69: Skapa en array på 11 tal, Addera 2 till talen som befinner sig på indexplats
 0, 2, 4, 6, 8, 10.

 Utprinten ska ha följande format, värden i arrayn kan bero på era värden:

  Index 0 has value 4

  Index 2 has value 7

  Index 4 has value 12

  Index 6 has value 1030

  Index 8 has value 100002

  Index 10 has value 4");

            Console.WriteLine();
            Console.WriteLine("Lösning:");

            int[] intArray = { 2, 6, 3, 8, 23, 567, 2, 456, 21, 2, 19 };

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    Console.WriteLine($"Index {i} has value {intArray[i] + 2}");
                }
            }
            Console.ReadKey();
        }
    }
}
