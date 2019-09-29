using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning31
    {
        int input;
        public void Print()
        {
            Console.WriteLine("Uppgift:");
            Console.WriteLine("Läs in ett antal tal som skrivs ut, avsluta med 0.");
            Console.WriteLine();

            while (input != 0)
            {
                Console.WriteLine($"Skriv in ett tal: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{input}");
                Console.WriteLine();
            }
            Console.ReadKey();
            return;
        }
    }
}
