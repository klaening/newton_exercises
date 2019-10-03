using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class LoopMultiplicationExample
    {
        public void Print()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}*{j} = {i*j}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            Console.Write("Skriv in vilken multiplikationstabell: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10 ; i++)
            {
                Console.Write($"{number} * {i} = {number * i}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
