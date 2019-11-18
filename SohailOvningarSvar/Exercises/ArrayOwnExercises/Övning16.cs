using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning16
    {
        //Write a C# Sharp program to create a new string taking the first 3 characters of a given string 
        //and return the string with the 3 characters added at both the front and back. 
        //If the given string length is less than 3, use whatever characters are there.

        public void Print()
        {
            Console.WriteLine(Change("Something"));
            Console.ReadKey();
        }

        public string Change(string text)
        {
            return text.Length > 3 ? text.Substring(0, 3) + text + text.Substring(0, 3) : text + text + text;
        }
    }
}
