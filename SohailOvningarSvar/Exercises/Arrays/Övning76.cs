using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning76
    {
        public void Print()
        {
            Console.Write("Hur lång vill du att din array ska vara: ");
            int length = int.Parse(Console.ReadLine());

            int[] Numbers = new int[length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Skriv in nummer {i+1} i din array: ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Original array:");
            Console.WriteLine("---------------");
            int round = 0;
            foreach (int number in Numbers)
            {
                if (round == length - 1)
                {
                    Console.WriteLine($"{number}.");
                }
                else
                {
                    Console.Write($"{number} ");
                }
                round++;
            }
            Console.WriteLine();


            int[] CopiedNumbers = new int[length];

            Numbers.CopyTo(CopiedNumbers, 0);
            Array.Reverse(CopiedNumbers);

            Console.WriteLine("Reversed array:");
            Console.WriteLine("---------------");
            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    Console.Write($"{CopiedNumbers[i]}.");
                }
                else
                {
                    Console.Write($"{CopiedNumbers[i]} ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
