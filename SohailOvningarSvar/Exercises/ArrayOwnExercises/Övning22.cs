using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning22
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check if the first appearance of 'a' in a given string " +
                "is immediately followed by another 'a'.");

            Console.WriteLine(CheckForA("DJ Khaaled"));
            Console.WriteLine(CheckForA("another one"));
            Console.WriteLine(CheckForA("Aarkvard"));

            Console.ReadKey();
        }

        public bool CheckForA(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.ToLower().Substring(i, 1) == "a" && text.ToLower().Substring(i + 1, 1) == "a")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
