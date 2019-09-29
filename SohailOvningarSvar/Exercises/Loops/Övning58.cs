using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning58
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in tio tal, bestäm och skriv ut det största av de tio inlästa talen. 
Talordningen ska utryckas dynamisk, förutom för det första talet som
läses in.
Exempel på utskrift:
    Input a number, nr1
23,23
    Input a number, nr2
    12,45
    Input a number, nr3
    87,34
    Input a number, nr4
    10004,456
    Input a number, nr5
    12,567
    Input a number, nr6
    3,4
    Input a number, nr7
    19,5
    Input a number, nr8
    76,3
    Input a number, nr9
    1,2
    Input a number, nr10
    0,34
    Largest number is: 10004,46");
            Console.WriteLine();

            float number;
            float largestNumber = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Input a number, nr{i}: ");
                number = float.Parse(Console.ReadLine());
                Console.WriteLine();
                if (largestNumber < number)
                {
                    largestNumber = number;
                }
            }
            Console.WriteLine("_____________________________");
            Console.WriteLine($"Largest number is: {largestNumber}.");
            Console.ReadKey();
        }
    }
}
