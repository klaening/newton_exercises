using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning17
    {
        /*Läs in två tal, och dividera det första talet med det andra talet, Om det andra talet är 0, ska fel meddelande skrivas ut 
          “ERROR!!!  Nämnaren är 0, noll division är inte tillåtet”  Annars skriv ut kvoten.*/

        public double CalcDivide(double tal1, double tal2)
        {
            double kvot = tal1 / tal2;
            if (tal2 == 0)
            {
                Console.WriteLine("ERROR!!!  Nämnaren är 0, nolldivision är inte tillåtet");
            }
            else
            {
                Console.WriteLine($"Resultat: {kvot}");
            }
            return kvot;
        }

        public void Print()
        {
            Console.Write("Skriv in första talet: ");
            double t1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv in andra talet: ");
            double t2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            CalcDivide(t1, t2);
            Console.ReadKey();
        }

    }
}
