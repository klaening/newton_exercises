using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning29
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.");

            Console.WriteLine(NewString("Hello, World!"));
            Console.WriteLine(test("Hello, World!"));

            Console.ReadKey();
        }

        //Alternative solution
        public static string test(string str1)
        {
            var result = string.Empty;
            for (var i = 0; i < str1.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;

                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
        }

        private string NewString(string text)
        {
            int index = 0;
            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                newText += text[i];
                index++;
                if (index == 2)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        i++;
                    }
                    index = 0;
                }
            }
            return newText;
        }
    }
}
