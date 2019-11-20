using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning17
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check if a given string starts with 'C#' or not.");

            Console.WriteLine(CheckStart("C# is a programming language"));
            Console.WriteLine(CheckStart("Java is another language"));
            Console.WriteLine(CheckStart("Python also"));
            Console.ReadKey();
        }
        
        public bool CheckStart(string text)
        {
            return text.StartsWith("C#");
        }
    }
}
