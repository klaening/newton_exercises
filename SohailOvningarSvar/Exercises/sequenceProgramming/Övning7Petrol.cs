using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning7Petrol
    {
        /*Beräkna vad du ska betala för en tank bensin.

        Indata är är antal liter, pris per liter och rabatt.
        Utdata är priset du ska betala.*/

        public double CalcPrice(double amountLiter, double pricePerLiter, double discount)
        {
            return amountLiter * pricePerLiter * (1 - discount / 100);
        }

        public void Print()
        {
            Console.Write("Ange antal liter: ");
            double al = (double)Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ange pris per liter: ");
            double ppl = (double)Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ange rabatt i antal procent: ");
            double disc = (double)Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Pris du ska betala: {CalcPrice(al, ppl, disc)}");
            Console.WriteLine();
            Console.Write("Tryck på valfri tangent för att avsluta: ");
            Console.ReadKey();
        }
    }
}
