using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning74
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
Övn74: Skapa fem tal i en array, leta upp det största och minsta talen och skriv ut dem.

Med följande värden i en array:
   5, 3, 8, 2, 10
   så måste printen se ut på följande sätt:

    Biggest value is: 10
    Smallest value is: 2");
            Console.WriteLine();

            int[] intArray = { 5, 3, 8, 2, 10 };
            int largestElement = intArray[0];
            int smallestElement = intArray[0];

            foreach (int element in intArray)
            {
                if (largestElement <= element)
                {
                    largestElement = element;
                }
                if (smallestElement >= element)
                {
                    smallestElement = element;
                }
            }
            Console.WriteLine($"Largest: {largestElement}, smallest: {smallestElement}");
            Console.ReadKey();
            Console.WriteLine();

            //Alternativ lösning
            Console.WriteLine("Annan lösning:");
            Console.WriteLine();
            int[] intArray2 = { 5, 3, 8, 2, 10 };

            //Array.Sort(intArray2);
                                                    //Vilken array, värde
            int elementOfLargestIndex = Array.IndexOf(intArray2, intArray2.Max());
            int elementOfSmallestIndex = Array.IndexOf(intArray2, intArray2.Min());

            Console.WriteLine($"Largest: {intArray2.Max()}, smallest: {intArray2.Min()}");
            Console.WriteLine($"Index of largest: {elementOfLargestIndex}, index of smallest: {elementOfSmallestIndex}");
            Console.ReadLine();
        }
    }
}
