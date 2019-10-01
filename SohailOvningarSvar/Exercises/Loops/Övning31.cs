using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning31
    {
        public void Print()
        {
            Console.WriteLine("Uppgift:");
            Console.WriteLine("Läs in ett antal tal som skrivs ut, avsluta med 0.");
            int input;

            do
            {
                Console.WriteLine($"Skriv in ett tal: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                Console.WriteLine($"{input}");
                Console.WriteLine();
            } while (input != 0);
            Console.ReadKey();

            Console.WriteLine("Uppgift:");
            Console.WriteLine("Läs in ett antal tal som skrivs ut, avsluta med 0.");
            Console.WriteLine();
            String textLine = "Numbers:";

            //Ifall du bara vill skriva ut i slutet
            do
            {
                Console.WriteLine($"Skriv in ett tal: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                textLine += $" {input},";
                Console.WriteLine();
            } while (input != 0);
            Console.WriteLine(textLine);
            Console.ReadKey();
        }
    }
}
