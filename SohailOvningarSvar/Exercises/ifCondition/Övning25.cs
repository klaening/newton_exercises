using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning25
    {
        //Läs in ett tal och skriv ut om det är positivt eller negativt.
        public void CheckIfNegativeOrPositive(double number)
        {
            if (number >= 0)
            {
                Console.WriteLine("Numret du angett är positivt!");
            }
            else
            {
                Console.WriteLine("Numret du angett är negativt!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in ett nummer: ");
            double input = Convert.ToDouble(Console.ReadLine());

            CheckIfNegativeOrPositive(input);
            Console.ReadKey();
        }
    }
}
