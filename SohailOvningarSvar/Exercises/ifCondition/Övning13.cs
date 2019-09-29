using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning13
    {
        //Läs in ett, är talet jämt, skriv Jämt tal, använd modulus operatorn %.
        public void IsNumberEven(int tal1)
        {
            //Vi använder en modulus (%) för att säga att om vi delar input med 2 == (ett valfritt) jämt eller ojämt tal
            if (tal1 % 2 == 0)
            {
                Console.WriteLine("Talet är jämnt!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in tal 1: ");
            int t1 = Convert.ToInt32(Console.ReadLine());

            IsNumberEven(t1);

            Console.ReadKey();
        }
    }
}
