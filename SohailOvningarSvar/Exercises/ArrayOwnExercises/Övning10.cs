using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning10
    {
        //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. 
        //If the string already begins with 'if', return the string unchanged.

        public void Print()
        {
            Console.WriteLine(Add("You want me, I'll be there."));
            Console.ReadKey();
        }

        public string Add(string text)
        {
            return text.ToLower().StartsWith("if") ? text : "If " + text.ToLower();
        }
    }
}
