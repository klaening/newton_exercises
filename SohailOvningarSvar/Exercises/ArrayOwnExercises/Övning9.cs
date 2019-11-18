using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning9
    {
        //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

        public void Print()
        {
            Console.WriteLine(Calculate(20, 40));
            Console.WriteLine(Calculate(30, 20));
            Console.WriteLine(Calculate(40, 30));
            Console.WriteLine(Calculate(20, 10));
            Console.ReadKey();
        }

        public bool Calculate(int x, int y)
        {
            return x == 30 || y == 30 || x + y == 30;
        }
    }
}
