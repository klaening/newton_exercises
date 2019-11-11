using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning49
    {
        public void Print()
        {
            Console.WriteLine(@"
Beräkna och resultatet för följande algoritm:
a.
f(x)=x^n
b.
x och n ska läsas in.");
            Console.WriteLine();
            int x;
            do
            {
                Console.Write("Värde för x: ");
                x = Convert.ToInt32(Console.ReadLine());

                if (x != 0)
                {
                    Console.Write("Värde för n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    int prod = 1;

                    if (n == 0)
                    {
                        Console.WriteLine($"Resultat: {prod}");
                        break;
                    }

                    for (int i = 1; i <= n; i++)
                    {
                        prod *= x;
                    }

                    Console.WriteLine($"Resultat: {prod}");
                }
                else
                {
                    Console.WriteLine("x får inte vara 0!");
                    Console.WriteLine("Testa igen!");
                    Console.ReadKey();
                }
            } while (x == 0);
            Console.ReadKey();
        }

        //public int CalcAlgorythm(int x, int n)
        //{
        //    return 0;
        //}
    }
}
