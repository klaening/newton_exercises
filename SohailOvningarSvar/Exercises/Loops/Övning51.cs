using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning51
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in tio heltal, och skriv ut hur många ggr talet 7 har lästs in. Talet 
7 måste förekomma minst en gång.");
            Console.WriteLine();

            int amountOfTImes = 0;
            int input;

            for (int i = 1; i <= 10; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("Skriv in sista talet:");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write($"Skriv in tal {i}: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                if (input == 7)
                    amountOfTImes += 1;
                if (i == 10)
                    Console.WriteLine("-------------");
                Console.WriteLine();
            }

            if (amountOfTImes != 0)
                Console.WriteLine($"Talet 7 har skrivits {amountOfTImes} ggr");
            else
                Console.WriteLine("Du har inte angett ett tal som är 7");
            Console.ReadKey();
        }
    }
}
