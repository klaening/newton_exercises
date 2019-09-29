using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning22
    {
        //Läs in ett tal, testa om talet är mellan 0 till 9, men inte 5.  Printa ut Rätt eller Fel.
        public void TestStatement(double input)
        {
            if (input > 0 && input < 9 && input !=5)
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            double inp = Convert.ToDouble(Console.ReadLine());

            TestStatement(inp);
            Console.ReadKey();
        }
    }
}
