using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning20
    {
        /*Läs in ett tal, testa om talet är mellan 0 till 9, i så fall skriv ut  kvadraten. Annars generera en felmeddalnde.*/
        public void Print()
        {
            Console.Write("Skriv in ett tal mellan 0 och 9: ");
            double input = Convert.ToDouble(Console.ReadLine());

            TestInterval(input);

            Console.ReadKey();
        }

        public void TestInterval(double num1)
        {
            if (num1 > 0 && num1 < 9)
            {
                Console.WriteLine($"Kvadraten är: {num1*num1}");
            }
            else
            {
                Console.WriteLine("Felmeddelande!");
            }
        }
    }
}
