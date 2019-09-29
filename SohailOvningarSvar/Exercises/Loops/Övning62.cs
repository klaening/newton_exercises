using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning62
    {
        public void Print()
        {
            Console.WriteLine(@"
10 tal ska läsas in, kontrollera om talen ligger mellan intervallet: 50 
till 100. Om talen ligger i detta intervall, ska ordet CORRECT! skrivas
ut, annars ska ERROR! skrivas ut. OBS! Intervall nr:et ska också 
skrivas ut.
Exempel:
 Input nr1
 55
 CORRECT!
 Input nr2
 2
 ERROR!
");
            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.Write($"Input nr {i}: ");
                int input = int.Parse(Console.ReadLine());

                if (input >= 50 && input <= 100)
                {
                    Console.WriteLine("CORRECT!");
                }
                else
                {
                    Console.WriteLine("ERROR!");
                }
            }
            Console.Write("Tryck på valfri tangent för att avsluta: ");
            Console.ReadKey();
        }
    }
}
