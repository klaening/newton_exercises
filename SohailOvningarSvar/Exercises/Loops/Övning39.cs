using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning39
    {
        public void Print()
        {
            float price;
            do
            {
                /*Läs in ett pris och skriv ut priset inkl moms på 25%. Inläsningen avslutas med 0.*/
                Console.WriteLine("Om du anger 0 så avslutas programmet");
                Console.Write("Skriv hur mycket varan kostar: ");
                price = Convert.ToInt32(Console.ReadLine());
                if (price != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Pris inkl moms: {AddVAT(price)}");
                }
                else
                {
                    Console.WriteLine("Hej då!");
                }
            } while (price != 0);

            Console.ReadKey();
        }

        public float AddVAT(float priceOfProduct)
        {
            //Måste skriva in ett f efter doublen. Funkar också med (float)1.25;
            float priceWithVAT = priceOfProduct * 1.25f;
            return priceWithVAT;
        }
    }
}
