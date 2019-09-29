using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning41
    {
        public void Print()
        {
            Console.WriteLine(@"Skriv ut summan av talen 1 till 50.
Svaret Måste vara i följande format:
    Omgång1 är summan: 1,
    Omgång2 är summan: 3,
    Omgång3 är summan: 6....och så vidare");

            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {
                sum = sum + i;
                Console.WriteLine($"Omgång {i} är summan: {sum}");
            }
            Console.ReadKey();
        }
    }
}
