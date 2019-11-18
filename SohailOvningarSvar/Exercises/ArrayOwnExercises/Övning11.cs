using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning11
    {
        //Write a C# Sharp program to remove the character in a given position of a given string. 
        //The given position will be in the range 0.. string length -1 inclusive.

        public void Print()
        {
            string text = "Hej, hur mår du idag?";
            Console.WriteLine(Remove(text, 5));
            Console.WriteLine(Remove(text, 10));
            Console.WriteLine(Remove(text, 1));

            Console.ReadKey();
        }

        public string Remove(string text , int x)
        {
            return text.Remove(x - 1, 1);
        }
    }
}
