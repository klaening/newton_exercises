using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning23
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.\n");

            Console.WriteLine(EveryOtherLetter("C Sharp"));
            Console.WriteLine(EveryOtherLetter("Crudnit"));
            Console.WriteLine(EveryOtherLetter("Mikael Klaening"));

            Console.ReadKey();
        }


        public string EveryOtherLetter(string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                return text.Remove(i, 1);
            }
            return text;

            //Alternativ
            string result = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0) 
                    result += text[i];
            }
            return result;
            //
        }
    }
}
