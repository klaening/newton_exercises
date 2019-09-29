using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning16
    {
        /*En firma erbjuder sina kunder 10% rabatt om man vid ett köptillfälle handlar för minst 1000kr.
         Antag för enkelhetens skull att man bara handlar varor av samma typ.Beräkna vad en kund ska betala, 
         indata är antal köpta enheter, samt pris  per enhet.*/

        double discount = 0.1;

        public double CalculateSum(double costPerUnit, int amount)
        {
            double totalPrice = amount * costPerUnit;

            if (totalPrice >= 1000)
            {
                totalPrice = totalPrice - (totalPrice * discount);
            }
            return totalPrice;
        }

        public void Print()
        {
            Console.Write("Vad är styckpriset för dina varor?: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in hur många varor du har köpt: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ditt totala pris blir: "+ CalculateSum(input1, input2));
            Console.ReadKey();
        }

    }
}
