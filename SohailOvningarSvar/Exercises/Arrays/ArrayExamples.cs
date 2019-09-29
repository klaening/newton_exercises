using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class ArrayExamples
    {
        public void PrintExample1()
        {
            //Arrays skrivs i plural
            //Så länge det är av samma datatyp så kan man skapa en lista med alla av samma typ
            String[] Customers = { "SAAB", "Boeing", "Airbus" };

            foreach (String customer in Customers)
            {
                Console.WriteLine("Aircraft makers: {0}", customer);
            }
            Console.ReadKey();
        }

        public void ArrayEx()
        {
            //Skriv först datatypen följt av [], namn = new datatyp[siffra];
            double[] laps = new double[3];

            laps[0] = 3.25;
            laps[1] = 2.25;
            laps[2] = 3.09;


            //Ett smartare sätt att skriva samma sak
            double[] machSpeed = { 2.1, 1.8, 3.5 };


            //Om du vill att användaren ger input mha en for loop
            /*double speed;

            for (int i = 0; i < 3; i++)
            {
                speed = double.Parse(Console.ReadLine());
                laps[i] = speed;
            }*/

            Console.WriteLine($"First laptime is: {laps[0]}");
            Console.WriteLine($"Second laptime is: {laps[1]}");
            Console.WriteLine($"Second laptime is: {laps[2]}");
            Console.WriteLine();

            Console.WriteLine($"First mach speed is: {machSpeed[0]}");
            Console.WriteLine($"Second mach speed is: {machSpeed[1]}");
            Console.WriteLine($"Second mach speed is: {machSpeed[2]}");
            Console.WriteLine();

            //Alternativ 1
            for (int i = 0; i < machSpeed.Length; i++)
            {
                Console.WriteLine($"mach speed nr {i+1}: {machSpeed[i]}");
            }
            Console.WriteLine();

            //Alternativ 2
            int nr = 0;
            foreach (var number in laps)
            {
                Console.WriteLine($"lap nr {nr+1}: {number}");
                nr++;
            }
            Console.WriteLine();

            //Sorteringsexempel
            int k = 0;
            //Sorterar i storleksordning minsta till största
            Array.Sort(laps);
            //Array.Sort<double>(laps);
            //Flippar indexplatserna
            Array.Reverse(laps);

            foreach  (double number in laps)
            {
                Console.WriteLine($"Nr1: {number}");
                k++;
            }
            Console.ReadLine();
        }

        public static void RunArray()
        {
            ArrayExamples arr2 = new ArrayExamples();
            arr2.ArrayEx();
        }
    }
}
