using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning77
    {
        public void Print()
        {
            Console.WriteLine(@"
Övn 77: Läs in fem heltal, skriv sedan ut dem i omvänd ordning, enbart en array får användas. 
Som exempel så har ni nedan inlästa tal i en array:

Enter array elements : 
   Element[1]: 34
   Element[2]: 89
   Element[3]: 546
   Element[4]: 44
   Element[5]: 2
   Original array : 
   34 89 546 44 2 
   Reversed Array : 
   2
   44
   546
   89
   34");
            int[] intArray = new int[5];

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"Element[{i}]: ");
                intArray[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine();
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Original array:");
            foreach (int element in intArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Array.Reverse(intArray);

            Console.WriteLine("---------------");
            Console.WriteLine("Reversed array:");
            foreach (int element in intArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
