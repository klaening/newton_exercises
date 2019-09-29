using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning34
    {
        public void Print()
        {
            Console.WriteLine("Läs in ett tecken i taget tills en * skrivs in.");
            Console.WriteLine();

            String input = Console.ReadLine();

            do
            {
                Console.Write("Skriv in ett tal: ");
                input = Console.ReadLine();
            } while (input != "*");

            Console.WriteLine($"Du skrev: {input}");
            Console.WriteLine("Hej då!");
            Console.ReadKey();
        }
    }
}
