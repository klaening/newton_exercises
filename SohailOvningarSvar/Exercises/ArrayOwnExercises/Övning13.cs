using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning13
    {
        //Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string. 
        //If the given string length is less than 2 return the original string.
        public void Print()
        {
            Console.WriteLine(Copies("Hej och hå!"));
            Console.ReadKey();
        }

        public string Copies(string text)
        {
            return text.Length < 2 ? text : text.Substring(0, 2) + text.Substring(0, 2) + text.Substring(0, 2) + text.Substring(0, 2);
        }
    }
}
