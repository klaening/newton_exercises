using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning21
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to count the string 'aa' in a given string and assume 'aaa' contains two 'aa'.");

            Console.WriteLine(CheckForA("ahaa!"));
            Console.WriteLine(CheckForA("aaah!"));
            Console.WriteLine(CheckForA("hahahahaaaaa!"));

            Console.ReadKey();
        }

        private int CheckForA(string text)
        {
            int occurences = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i, 2) == "aa")
                {
                    occurences++;
                }
            }

            return occurences;
        }
    }
}
