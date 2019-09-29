using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning33
    {
        public void Print()
        {
            Console.WriteLine("Uppgift:");
            Console.WriteLine("Skriv ut talen 100, 99, 98, ...., 0.");
            Console.WriteLine();

            for (int i = 100; i <= 0; i =-2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
