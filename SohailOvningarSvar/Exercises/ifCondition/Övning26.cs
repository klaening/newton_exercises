using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning26
    {
        //Läs in två tal, och skriv ut det största talet, följt av orden “är störst”.  Om talet är lika, skriv ut “Talen är lika”.

        public void CheckWhichIsBigger(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} är störst.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} är störst.");
            }
            else
            {
                Console.WriteLine("Talen är lika.");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in första talet: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv in andra talet: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            CheckWhichIsBigger(input1, input2);
            Console.ReadKey();
        }
    }
}
