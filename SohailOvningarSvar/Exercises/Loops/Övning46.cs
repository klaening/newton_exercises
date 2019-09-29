using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning46
    {
        public void Print()
        {
            Console.WriteLine(@"Lönen första dagen är 1 öre. andra dag är det 2 öre, tredje dagen är 
det 4 öre.Alltså fördubblas lönen varje dag.Hur många dagar måste
man jobba för att tjäna ihop 1miljon kronor.");
            //Övning 46 med user input
            /*
            float salary = 0.01f;
            float money = 0;
            float wantedAmount = (float)Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 40; i++)
            {
                money += salary;
                if (money >= wantedAmount)
                {
                    Console.WriteLine($"Det tog {i} dagar att tjäna ihop {wantedAmount} kr");
                    Console.WriteLine($"Din lön idag var: {salary}");
                    Console.WriteLine($"Du har nu: {money}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Dag {i} är din lön: {salary}");
                    Console.WriteLine($"Du har tjänat ihop: {money}");
                    Console.WriteLine();
                    salary = salary * 2;
                }
            }
            Console.ReadKey();*/

            
            float salary = 0.01f;
            float sum = 0;

            for (int i = 1; i < 50; i++)
            {
                sum = sum + salary;
                if (sum >= 1000000)
                {
                    Console.WriteLine();
                    Console.WriteLine("_______________________________");
                    Console.WriteLine($"Dag {i}: Lönen är: {salary}");
                    Console.WriteLine($"Det tog {i} dagar att tjäna: {sum}");
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"Dag {i}: Lönen är: {salary}");
                    Console.WriteLine($"Din totala summa är: {sum}");
                    Console.WriteLine("--------------------------");
                    salary = 2 * salary;
                }
            }
            Console.ReadKey();
        }
    }
}
