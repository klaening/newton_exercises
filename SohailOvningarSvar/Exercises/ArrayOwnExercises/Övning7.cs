using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning7
    {
        //Write a C# Sharp program to compute the sum of the two given integer values. 
        //If the two values are the same, then return triple their sum.

        public void Print()
        {
            Console.Write("First integer: ");
            int int1 = int.Parse(Console.ReadLine());

            Console.Write("Second integer: ");
            int int2 = int.Parse(Console.ReadLine());

            Console.WriteLine("result: " + Calculate(int1, int2));
            Console.ReadKey();
        }

        public int Calculate(int int1, int int2)
        {
            return int1 == int2 ? (int1 + int2) * 3 : int1 + int2;
        }
    }
}
