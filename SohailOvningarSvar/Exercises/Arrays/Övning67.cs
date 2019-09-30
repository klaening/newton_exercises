using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SohailOvningarSvar.Exercises.Arrays
{
    class Övning67
    {
        public void Print()
        {
            Console.WriteLine(@"Övn67: Avgör med personnr om det är en man eller kvinna, med formatet YYMMDD-NNNN.");
            Console.WriteLine();

            String socNumber = Console.ReadLine();

            char[] charArray = socNumber.ToCharArray();

            string pattern = @"^\d{6}-\d{4}$";

            Regex regex = new Regex(pattern);
        }
    }
}
