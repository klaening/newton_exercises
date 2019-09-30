using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning56
    {
        int number;

        public void Print()
        {
            Console.WriteLine(@"
Läs in ett antal tal. Inläsningar stoppas av talet 9999. Skriv ut 
medelvärdet 
av de inlästa talen.
a.
Hantera inläsningen om det första inlästa talet är stopvärdet.");
            Console.WriteLine();


            int sum = 0;
            int i = 1;
            int amountNumbers = 0;

            do
            {
                Console.Write($"Skriv in tal {i}: ");
                sum = int.Parse(Console.ReadLine());
                if (sum == 9999)
                {
                    Console.WriteLine("Du måste ange ett förstavärde!");
                }
            } while (sum == 9999);

            amountNumbers++;
            i++;

            while (number != 9999)
            {
                Console.Write($"Skriv in tal {i}: ");
                number = int.Parse(Console.ReadLine());

                if (number != 9999)
                {
                    sum += number;
                    amountNumbers += 1;
                    i++;
                }
            }
            Console.WriteLine($"Medelvärdet är: {CalcAverage(sum, amountNumbers).ToString("F2")}");
            Console.ReadKey();
        }

        public double CalcAverage(double sum, double amount)
        {
            return sum / amount;
        }
    }
}
