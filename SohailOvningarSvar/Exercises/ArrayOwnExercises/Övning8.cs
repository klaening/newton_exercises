using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning8
    {
        //Write a C# Sharp program to get the absolute difference between n and 51. 
        //If n is greater than 51 return triple the absolute difference.

        public void Print()
        {
            Console.WriteLine(Calculate(6));
            Console.WriteLine(Calculate(60));
            Console.WriteLine(Calculate(51));
            Console.ReadKey();
        }

        public int Calculate(int n)
        {
            return n > 51 ? (n - 51) * 3 : 51 - n;
        }
    }
}
