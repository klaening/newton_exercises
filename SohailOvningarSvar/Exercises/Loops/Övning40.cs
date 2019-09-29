using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning40
    {
        public void Print()
        {
            Console.WriteLine(@"Skriv ut svaret för följande algoritm. 
a.
f(x)=3x^3-5x^2+2x-20
b.
Skriv ut resultatet om x är ett heltal mellan -10 och 10.
");
            Console.WriteLine("a.");
            Console.Write("Skriv in värdet för x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Svaret är: {Calculation(x)}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("b.");

            for (int i = -10; i <= 10 ; i++)
            {
                    Console.WriteLine($"Svaret på f(x) är: {Calculation(i)}");
            }
            Console.ReadKey();
        }

        //Skapar en funktion för jag vill inte ha en uträkning i min Printmetod
        public int Calculation(int x)
        {
            return 3 * x * x * x - 5* x * x + 2 * x - 20;
        }


        /*Exempel utskrift:
Svaret på f(x) är: -29540
Svaret på f(x) är: -21746
Svaret på f(x) är: -15460
Svaret på f(x) är: -10520
Svaret på f(x) är: -6764
Svaret på f(x) är: -4030
Svaret på f(x) är: -2156
Svaret på f(x) är: -980
Svaret på f(x) är: -340
Svaret på f(x) är: -74
Svaret på f(x) är: -20
Svaret på f(x) är: -16
Svaret på f(x) är: 100
Svaret på f(x) är: 490
Svaret på f(x) är: 1316
Svaret på f(x) är: 2740
Svaret på f(x) är: 4924
Svaret på f(x) är: 8030
Svaret på f(x) är: 12220
Svaret på f(x) är: 17656
*/
    }
}
