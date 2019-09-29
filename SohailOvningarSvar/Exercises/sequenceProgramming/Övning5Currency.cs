using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{ 
    class Övning5Currency
    {
        /* Läs in ett heltal motsvarande svenska kronor och omvandla till pund och dollar. 
           Antag att kursen för närvarande är 1dollar är 11kr, 1pund är 13kr. */
       

        int poundRate = 13;

        int dollarRate = 11;

        public double CalculatePound(int Sek)
        {
            //(double) gör att returneringen ska räknas som en double
            return (double)Sek / poundRate;

        }

        public double CalculateDollar(int Sek)
        {
            return (double)Sek / dollarRate;
        }

        public void Print()
        {
            Console.Write("Skriv in hur många svenska kronor: ");
            int Sek = (int)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Omvandlat till pund: {0}", CalculatePound((int)Sek));
            Console.WriteLine("Omvandlat till dollar: {0}", CalculateDollar((int)Sek));

            Console.ReadKey();
        }
    }
}
