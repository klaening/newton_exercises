using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning14
    {
        //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
        public void Print()
        {
            Console.WriteLine(Change("Sista karaktären i början och slutet"));
            Console.WriteLine(Change("1"));
            Console.ReadKey();
        }

        public string Change(string text)
        {
            return text.Length > 1 ? text.ToUpper().Last() + text.ToLower().Substring(0, text.Length - 1) + text.Last() : text;
        }
    }
}
