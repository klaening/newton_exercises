using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning23
    {
        //Läs in ett tal, testa om talet är jämt delbart med 3, men inte med 30, I så fall divideras talet med 3.

        /*public void TestStatement(double num)
        {
            if (num % 3 == 0 && num % 30 != 0)
            {
                num = num / 3;
                Console.WriteLine($"Ditt nummer är nu: {num}");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            double input = Convert.ToDouble(Console.ReadLine());

            TestStatement(input);
            Console.ReadKey();
        }*/
        decimal kvot;

        public int CalcKvot(int num)
        {
            if (num % 3 == 0 && num % 30 != 0)
            {
                kvot = num / 3;
            }
            return (int)kvot;
        }


        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kvoten är: {CalcKvot(input)}");
            Console.ReadKey();
        }

    }
}
