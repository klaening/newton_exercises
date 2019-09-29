using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning42
    {
        public void Print()
        {
            Console.WriteLine(@"Läs in och addera 20 heltal, summan ska skrivas ut.
Svaret Måste vara i följande format:
    Omgång1 är summan: 1,
    Omgång2 är summan: 3,
    Omgång3 är summan: 6....och så vidare");

            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Skriv in tal {i}: ");
                Console.Write("hej hej");
                int input = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    sum += input;
                }
                else
                {
                    sum += input;
                    Console.WriteLine($"Omgång {i} är summan: {sum}");
                }
            }
            Console.ReadKey();
        }
    }
}
