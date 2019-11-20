using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning20
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check the largest number among three given integers\n");

            Console.WriteLine(CheckLargest(13, 123, 50));
            Console.ReadKey();
        }

        private int CheckLargest(int num, int num1, int num2)
        {
            var max = Math.Max(num, Math.Max(num1, num2));

            return max;
        }
    }
}
