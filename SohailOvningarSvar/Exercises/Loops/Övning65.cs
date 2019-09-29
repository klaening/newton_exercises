using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning65
    {
        public void Print()
        {
            Console.WriteLine(@"
Indata består av 10 positiva tal. Beräkna skillnaden mellan det 
största och nästa största talet.
Exempel:
Input nr1
1
Input nr2
2
Input nr3
3
...
The diff betweeen the largest and second largest nr is: 5");
            Console.WriteLine();

            int input;

            Console.WriteLine($"Input nr 1: ");
            input = int.Parse(Console.ReadLine());

            int smallestNumber = input;
            int secondLargestNumber = input;
            int largestNumber = input;

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"Input nr {i}: ");
                input = int.Parse(Console.ReadLine());

                if (smallestNumber > input)
                {
                    smallestNumber = input;
                }
                if (largestNumber < input)
                {
                    secondLargestNumber = largestNumber;
                    largestNumber = input;
                }
            }
            //Console.WriteLine($@"Smallest nr: {smallestNumber}, second largest nr: {secondLargestNumber}, largest number: {largestNumber}");
            Console.WriteLine($"The diff betweeen the largest and second largest nr is: {CalcDifference(largestNumber, secondLargestNumber)}.");
            Console.ReadKey();
        }

        public int CalcDifference(int largest, int secondLargest)
        {
            return largest - secondLargest;
        }
    }
}
