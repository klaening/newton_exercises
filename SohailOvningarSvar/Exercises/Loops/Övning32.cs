using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning32
    {
        public void Print()
        {
            Console.WriteLine("Uppgift:");
            Console.WriteLine("Skriv ut talen 2, 4, 6, ....100.");
            Console.WriteLine();

            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
