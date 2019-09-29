using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    //Läs in två tal och avgör om det första talet är jämt delbart  delbart med det andra talet.
    class Övning15
    {
        public void CanDivideFirstWithSecond(int tal1, int tal2)
        {
            if (tal1 % tal2 == 0)
            {
                Console.WriteLine("Talet är jämnt delbart!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in ett till tal: ");
            int t2 = Convert.ToInt32(Console.ReadLine());

            CanDivideFirstWithSecond(t1, t2);

            Console.ReadKey();
        }
    }
}
