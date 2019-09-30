using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning70
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
Övn 70: Skapa en array av både positiva och negativa tal, skriv ut alla positiva tal.

Med följande värden i arrayn:
  2, 3, -5, 8, -10
  så borde printen se ut på följande sätt:

  Enter array elements : 
  Element[1]: 56
  Element[2]: 34
  Element[3]: -234
  Element[4]: -43
  Element[5]: 4
  List of positive numbers : 
56 34 4 ");
            Console.WriteLine();

            int[] intArray = new int[5];
            List<int> amountPositive = new List<int>();

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"Element[{i}]: ");
                intArray[i] = int.Parse(Console.ReadLine());

                if (intArray[i] > 0)
                {
                    amountPositive.Add(intArray[i]);
                }
            }

            Console.WriteLine($"List of positive numbers:");
            foreach (int element in amountPositive)
            {
                Console.Write($"{element} ");
            }
            Console.ReadKey();
        }
    }
}
