using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning59
    {
        public void Print()
        {
            Console.WriteLine(@"
Bestäm hur många tal du vill läsa in. Det största och minsta värdet 
av talen ska skrivas ut. I nedanstående exempel så är det fem tal 
som läses in. 
a.
OBS! Ordningsföljden för tal n2 och vidare ska 
beräknas och skrivas ut dynamisk.
Which nr is largest and smallest
Input amount of numbers
5
Input first number
34
Input number 2
456
Input number 3
21
Input number 4
8976
Input number 5
45
largest nr is: 8976 and the smallest nr is: 21");
            Console.WriteLine();

            Console.Write("Skriv in hur många tal: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Skriv in första talet: ");
            int number = int.Parse(Console.ReadLine());

            int largestNumber = number;
            int smallestNumber = number;

            for (int i = 1; i < length; i++)
            {
                Console.Write($"Skriv in tal {i+1}: ");
                number = int.Parse(Console.ReadLine());

                if (largestNumber > number)
                {
                    largestNumber = number;
                }
                else if (smallestNumber < number)
                {
                    smallestNumber = number;
                }
            }
            Console.WriteLine($"Största numret är: {largestNumber}.");
            Console.WriteLine($"Minsta numret är: {smallestNumber}.");
            Console.ReadKey();
        }
    }
}
