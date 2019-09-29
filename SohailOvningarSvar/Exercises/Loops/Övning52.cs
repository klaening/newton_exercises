using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning52
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in tio heltal och skriv summan av de positiva talen. Minst ett 
negativ tal måste förekomma bland de tio talen.");
            Console.WriteLine();

            int number;
            int sum = 0;

            Console.WriteLine("Skriv in tio tal");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Skriv in tal {i}: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    sum += number;
                }
                else
                {
                }
                if (i == 10)
                {
                    Console.WriteLine($"Summan av dina tio tal är: {sum}");
                }
            }
            Console.ReadKey();

            /*int input;
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Skriv in heltal {i}: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input % 2 == 0)
                {
                    sum += input;
                }
            }

            Console.WriteLine($"Summan av dina heltal är: {sum}");
            Console.ReadKey();
            Console.WriteLine();*/

            /*do
            {
                Console.Write($"Skriv in heltal 1: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input % 2 == 0)
                {
                    sum += input;
                }

                for (int i = 2; i <= 10; i++)
                {
                    Console.Write($"Skriv in heltal {i}: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    sum = 0;

                    if (input % 2 == 0)
                    {
                        sum += input;
                    }
                }
                Console.WriteLine($"Summan av dina heltal är: {sum}");
                Console.ReadKey();
                Console.WriteLine();
            } while (input < 0);*/
        }
    }
}
