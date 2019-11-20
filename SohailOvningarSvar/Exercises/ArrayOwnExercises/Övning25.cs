using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning25
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last " +
                "2 characters of the string. Do not count the end substring.");

            Console.WriteLine(CheckForSubstring("ooHelloo Woorld! oo"));
            Console.WriteLine(CheckForSubstring("Aardvark, aasgard"));
            Console.ReadKey();
        }

        private int CheckForSubstring(string text)
        {
            string lastTwo = text.Substring(text.Length - 2);
            int ctrSubstring = 0;
            for (int i = 0; i < text.Length - 2; i++)
            {
                if (text.ToLower().Substring(i, 2).Equals(lastTwo))
                    ctrSubstring++;
            }
            return ctrSubstring;
        }
    }
}
