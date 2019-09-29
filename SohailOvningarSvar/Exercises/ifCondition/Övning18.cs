using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning18
    {
        /*Läs in värden av två tal, X och Y. Tilldela sedan variablen A värdet 2 om   X är större än 5 + Y.  
         * I annat fall så tilldelas variablen A värdet 5.*/

        double a;
        public void DelegateValue(double x, double y)
        {
            if (x > 5 + y)
            {
                a = 2;
            }
            else
            {
                a = 5;
            }
            Console.WriteLine($"Värdet på a är: {a}");
        }
        public void Print()
        {
            Console.Write("Sätt värde för x :");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sätt värde för y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DelegateValue(x, y);
            Console.ReadKey();
        }
    }
}
