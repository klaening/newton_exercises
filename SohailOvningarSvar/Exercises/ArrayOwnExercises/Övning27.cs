using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning27
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to compare two given strings " +
                "and return the number of the positions where they contain the same length of substring.");

            Console.WriteLine(WhereIs("Hi", "Hi there stranger!"));
            Console.WriteLine(WhereIs("hello", "Well, hello there!"));
            Console.ReadKey();
        }

        public string WhereIs(string substring, string text)
        {
            int[] indexPlaces = new int[substring.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (substring == text.Substring(i, substring.Length))
                {
                    //en for loop för att lägga till resterande indexplatser
                    for (int j = 0; j < substring.Length; j++)
                    {
                        indexPlaces[j] = i++;
                    }
                    break;
                }
            }

            string output = string.Empty;

            foreach (int index in indexPlaces)
            {
                output += index.ToString();
                if (index != indexPlaces.Last())
                {
                    output += ", ";
                }
            }

            return output;
        }
    }
}
