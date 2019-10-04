using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning78
    {
        public void Print()
        {
            Console.WriteLine(@"
Övn 78: Läs in två tal till en bråk, dvs täljare och nämnare, spara de i en array med två platser. 
Kontrollera om nämaren är 0, skriv i så fall ut ett felmeddelande

Exempel:
Enter array elements : 
   Element[1]: 3
   Element[2]: 0
   Numerator and denominator : 
   3 
   0 
   denominator cannot be 0


");
            double[] doubleArray = new double[2];
            double svar;

            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.Write($"Element {i}: ");
                doubleArray[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numerator and denominator:");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }

            if (doubleArray[1] == 0)
            {
                Console.WriteLine("denominator cannot be 0");
            }
            else
            {
                svar = doubleArray[0] / doubleArray[1];
                Console.WriteLine($"Svar: {svar}");
            }

            Console.ReadKey();
        }
    }
}
