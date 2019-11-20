using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning28
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to compare two given strings " +
                "and return the number of the positions where they contain the same length 2 substring.\n");

            Console.WriteLine(WhereIs("abcdefab", "abdkefodfab"));
            Console.ReadKey();
        }

        private string WhereIs(string text1, string text2)
        {
            //string indexPlaces = string.Empty;

            //for (int i = 0; i < text1.Length - 1; i++)
            //{
            //    if (text1.Substring(i, 2) == text2.Substring(i, 2))
            //    {
            //        indexPlaces += i + " " + (i + 1) + " ";
            //    }
            //}

            //return indexPlaces;

            //Alternative solution

            int ctr = 0;

            for (int i = 0; i < text1.Length - 1; i++)
            {
                string substring1 = text1.Substring(i, 2);

                for (int j = 0; j < text2.Length - 1; j++)
                {
                    string substring2 = text2.Substring(j, 2);

                    if (substring1 == substring2)
                    {
                        ctr++;
                    }
                }
            }

            return ctr.ToString();
        }
    }
}
