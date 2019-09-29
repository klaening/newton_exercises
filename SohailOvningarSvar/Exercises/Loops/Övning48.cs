using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning48
    {
        public void Print()
        {
            Console.WriteLine(@"
Skriv ut n! (fakulteten). n ska läsas in.
a.
ex: 3!=1*2*3
b.
ex: 5!=1*2*3*4*5");
            Console.WriteLine();

            Console.Write("Skriv in värdet på n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            Console.Write($"{n}! = ");

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    sum *= i;
                    Console.WriteLine($"{i}.");
                }
                else
                {
                    sum *= i;
                    Console.Write($"{i} * ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Produkten av n! = {sum}");
            Console.ReadKey();
        }
    }
}
