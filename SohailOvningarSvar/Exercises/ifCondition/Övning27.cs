using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning27
    {
        //Läs in tre tal, skriv ut det minsta talet.

        double num1, num2, num3;
        public double Highest
        {
            get { return Math.Max(num1, Math.Max(num2, num3)); }
        }

        public double Lowest
        {
            get { return Math.Min(num1, Math.Min(num2, num3)); }
        }

        public void Print()
        {
            Console.WriteLine("Skriv första talet:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv andra talet:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv tredje talet:");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Högsta talet är: " + Highest);
            Console.WriteLine("Lägsta talet är: " + Lowest);

            Console.ReadKey();

        }
    }
}
