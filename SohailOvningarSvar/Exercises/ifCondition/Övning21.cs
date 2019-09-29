using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning21
    {
        //Läs in ett tal, testa om talet är mindre än -10 eller större än 10, i så  fall skriv ut “Talet är minst två siffrigt.
        /*public void Print()
        {
            Console.Write("Skriv in ett tal: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input < -10 || input > 10)
            {
                Console.WriteLine("Talet är minst tvåsiffrigt.");
            }

            Console.ReadKey();
        }*/

        public void PrintTest(double input)
        {
            if (input > 10 || input < -10)
            {
                Console.WriteLine("Talet är minst två siffrigt.");
            }
        }
        
        public void Print()
        {
            Console.Write("Skriv ett tal: ");
            double inp = Convert.ToDouble(Console.ReadLine());

            PrintTest(inp);
            Console.ReadKey();
        }
    }
}
