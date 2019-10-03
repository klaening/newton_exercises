using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning72
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
Övn72: Skapa en array av 5 tal, skriv ut indexet för det sista negativa talet i arrayn. Ett litet tips, om ni löser det med en for loop, 
börja loopen omvänd.

Med följande talföjd:
   2, 3, -5, 8, 10
  så SKA printe vara i följande format:

The last negative nr -5 was on index: 2");
            Console.WriteLine();

            int[] intArray = { 2, 3, -5, 8, -10};
            int lastNegative = 0;
            int index = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 0)
                {
                    lastNegative = intArray[i];
                    index = i;
                }
            }

            Console.WriteLine($"The last negative nr {lastNegative} was on index: {index}");
            Console.ReadKey();

            //Alternativ lösning
            /*foreach (int number in intArray)
            {
                if (number < 0)
                {
                    lastNegative = number;
                    index = Array.IndexOf(intArray, number);
                }
            }*/

            //Sohails lösning
            for (int i = intArray.Length; i <= 0; i--)
            {
                if (intArray[i] < 0)
                {
                    Console.WriteLine($"The last negative nr {intArray[i]} was on index: {i}");
                    i = 0;
                    //break; funkar också
                }
            }

            Console.WriteLine($"The last negative nr {lastNegative} was on index: {index}");
            Console.ReadKey();
        }
    }
}
