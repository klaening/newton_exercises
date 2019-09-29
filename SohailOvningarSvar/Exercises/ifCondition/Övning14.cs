using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    //Läs in ett, är talet jämt, skriv Jämt tal, om inte, skriv Udda tal, använd modulus operatorn %.
    class Övning14
    {
        public void IsNumberEvenOrOdd(int tal1)
        {
            if (tal1 % 2 == 0)
            {
                Console.WriteLine("Talet är jämnt!");
            }
            else
            {
                Console.WriteLine("Talet är ojämnt!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            
            IsNumberEvenOrOdd(t1);

            Console.ReadKey();
        }
    }
}
