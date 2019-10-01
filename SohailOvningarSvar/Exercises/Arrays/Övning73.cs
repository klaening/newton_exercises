using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning73
    {
        public void Print()
        {
            Console.WriteLine(@"
Övn73: Skapa en array av 5 positiva tal, skriv ut summan och medel av de fem talen, svaret ska vara med 2 decimaler 
tex med nedanstående array värden:

2, 3.5, 5, 8, 10 

   The sum of all array items is: 28,5
   The avverage of all array items is: 5,70");
            Console.WriteLine();

            Console.WriteLine("Test:");
            double[] Numbers = { 2, 3.5, 5, 8, 10 };
            double sum = 0;
            int amount = Numbers.Length;

            foreach (double nr in Numbers)
            {
                sum += nr;
            }
            Console.WriteLine($"The sum of all array items is: {sum.ToString("F2")}");
            Console.WriteLine($"The avverage of all array items is: {CalcAverage(sum, amount).ToString("0.00")}");
            Console.ReadKey();
        }

        public double CalcAverage(double sumOfArray, int amountOfNumbers)
        {
            return sumOfArray / amountOfNumbers;
        }
    }
}
