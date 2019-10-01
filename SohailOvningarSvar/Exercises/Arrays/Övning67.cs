using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning67
    {
        public void Print()
        {
            Console.WriteLine(@"Övn67: Avgör med personnr om det är en man eller kvinna, med formatet YYMMDD-NNNN.
Om nästsista nr är jämnt delbart så är det en kvinna, annars en man.

Printa ut Man eller Kvinna.");
            Console.WriteLine();

            String socNumber = Console.ReadLine();
            char[] charArray = socNumber.ToCharArray();
            String check = charArray[9].ToString();
            int checkSex = int.Parse(check);

            if (checkSex % 2 == 0)
            {
                Console.WriteLine("Kvinna");
            }
            else
            {
                Console.WriteLine("Man");
            }
            Console.ReadKey();
        }
    }
}
