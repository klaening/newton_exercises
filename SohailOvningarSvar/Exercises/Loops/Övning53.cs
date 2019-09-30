using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning53
    {
        int maxLength = 10;
        public void Print()
        {
            Console.WriteLine(@"
Läs in tio korrekta tal, korrekta tal är tal mellan 5ooo < n < 10000.
a.
Skriv ut summan och 
medelvärdet.");
            Console.WriteLine();

            Console.WriteLine("Skriv in tio korrekta tal");

            int number;
            string writeNumbers = "";
            int sum = 0;
            int median = 0;
            int[] Numbers = new int[maxLength];

            for (int i = 0; i < maxLength ; i++)
            {
                do
                {
                    Console.Write($"Skriv in tal {i+1}: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number > 5000 && number < 10000)
                    {
                        Numbers[i] = number;
                        writeNumbers = $"{writeNumbers}" + $" {number}";

                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Inkorrekt tal!");
                    }
                    if (i == 5)
                    {
                        median += number;
                    }
                } while (number < 5000 || number > 10000);
            }

            Console.Write("Siffrorna du skrev in var: ");
            foreach (int nr in Numbers)
            {
                    Console.Write($"{nr} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Summan av talen är: {sum}");
            Console.WriteLine($"Medelvärdet är: {CalcAverage(sum)}");
            Console.WriteLine($"Medianen är: {median}");
            Console.ReadKey();
        }

        public double CalcAverage(double sum)
        {
            return sum / maxLength;
        }
    }
}
