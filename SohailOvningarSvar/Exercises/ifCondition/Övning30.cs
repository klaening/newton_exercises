using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning30
    {
        //Läs in ett tal, Printa ut om talet är mindre än 10, mindre än 100, eller  större än 100.

        public void InputOutput(double input)
        {
            if (input < 10)
                Console.WriteLine("Talet är mindre än 10");
            else if (input < 100)
                Console.WriteLine("Talet är mindre än 100");
            else
                Console.WriteLine("Talet är större än 100");
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            double input = double.Parse(Console.ReadLine());

            InputOutput(input);
            Console.ReadKey();
        }
    }
}
