using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning12
    {
        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.

        public void Print()
        {
            Console.WriteLine(Switch("Hello"));
            Console.WriteLine(Switch("AbCde"));
            Console.ReadKey();
        }

        public string Switch(string text)
        {
            return text.Length > 1 ? text.ToUpper().Last() + text.Substring(1, text.Length - 2) + text.ToLower().Last() : text;
        }
    }
}
