using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Loops
{
    class forLoopExample
    {
        public void forLoopExample1()
        {
            for (int i = 1; i <= 20; i *= 2)
                {
                    Console.WriteLine("Nu är siffran: {0}", i);
                }
                Console.ReadKey();
        }
        
        //Från födelsedatum till 2019 skriv ut var fjärde år
        public void PrintEveryFourthYear()
        {
            int birthYear = 1987;
            int currentYear = 2019;

            for (int i = birthYear; i <= currentYear; i+=4)
            {
                Console.WriteLine($"Året är nu: {i}");
            }
            Console.ReadKey();
        }
    }
}
