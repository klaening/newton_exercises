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
            String input = "*";

            do
            {
                Console.Write("Skriv in ett tal: ");
                input = Console.ReadLine();
            } while (input != "*");

            /*while (input != "*")
            {
                Console.Write("Skriv in ett tal: ");
                input = Console.ReadLine();
            }*/
            Console.WriteLine($"Du skrev: {input}");
            Console.WriteLine("Hej då!");
            Console.ReadKey();
        }
    }
}
