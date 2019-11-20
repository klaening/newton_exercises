using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning26
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.");

            Console.WriteLine(CheckForSequence(123, 123456));
            Console.WriteLine(CheckForSequence(456, 1298456221));
            Console.WriteLine(CheckForSequence(23, 1432675));
            Console.ReadKey();
        }

        private bool CheckForSequence(int sequence, int Numbers)
        {
            string NumbersString = Numbers.ToString();

            return NumbersString.Contains(sequence.ToString());
        }
    }
}
