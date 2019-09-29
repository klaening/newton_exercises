using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning12
    {
        //Läs in två tal, kontrollera om det första talet är mer än dubbelt så stort som det andra talet.
        public void IsFirstTwiceAsSecond(double tal1, double tal2)
        {
            if (tal1 == 2 * tal2)
            {
                Console.WriteLine("Tal 1 är dubbelt så stort som tal 2!");
            }
            else
            {
                Console.WriteLine("Tal 1 är inte dubbelt så stort som tal 2");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in tal 1: ");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in tal 2: ");
            double t2 = Convert.ToDouble(Console.ReadLine());

            IsFirstTwiceAsSecond(t1, t2);

            Console.ReadKey();
        }
    }
}
