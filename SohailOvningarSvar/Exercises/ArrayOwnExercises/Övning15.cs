using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning15
    {
        // Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7

        public void Print()
        {
            Console.WriteLine(Check(21));
            Console.WriteLine(Check(30));
            Console.WriteLine(Check(17));

            Console.ReadKey();
        }

        public bool Check(int number)
        {
            return number % 3 == 0 || number % 7 == 0;
        }
    }
}
