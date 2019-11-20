using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning24
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to create a string like 'aababcabcd' from a given string 'abcd'.");

            Console.WriteLine(AddLetters("abcd"));
            Console.ReadKey();
        }

        private string AddLetters(string text)
        {
            //Lägg till första bokstaven
            //Skriv ut så många bokstäver som finns fram till och med den bokstaven
            //Skriv ut nästa bokstav
            //osv
            //Skriv ut sista men inte alla bokstäver fram till den

            string addedLetters = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                addedLetters += text.Substring(0, i + 1);
            }

            return addedLetters;
        }
    }
}
