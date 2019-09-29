using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning43
    {
        public void Print()
        {
            Console.WriteLine(@"Skriv ut summan av de jämna heltalen från 2 till 30.
Svaret Måste vara i följande format:
    Omgång1 är summan: 2,
    Omgång2 är summan: 6,
    Omgång3 är summan: 12....och så vidare");
            /*
            int sum = 0;
            int result = 2;

            for (int i = 1; i <= 15; i++)
            {
                sum += result;
                Console.WriteLine($"Omgång {i} är summan: {sum}");
                result += 2;   
            }
            Console.ReadKey();*/

            int sum = 0;

            for (int i = 2; i <= 30; i += 2)
            {
                sum += i;
                Console.WriteLine($"Omgång {i/2} är summan: {sum}");
            }
            Console.ReadKey();
        }
    }
}
