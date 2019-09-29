using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning54
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in tio heltal, skriv ut hur många av talen var positiva, respektive 
negativa. Minst en förekomst av både positiva respektive negativa tal måste 
förekomma i de inlästa talen.");
            Console.WriteLine();

            int number;
            int negAmount = 0;
            int posAmount = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Skriv in tal {i}: ");
                number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    negAmount += 1;
                }
                if (number > 0)
                {
                    posAmount += 1;
                }
            }
            Console.WriteLine($"Du skrev {negAmount} negativa tal!");
            Console.WriteLine($"Du skrev {posAmount} positiva tal!");
            Console.ReadKey();
        }
    }
}
