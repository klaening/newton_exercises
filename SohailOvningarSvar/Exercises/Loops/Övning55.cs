using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning55
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in 11 heltal. Bestäm och skriv ut summan av de tal som är större
än första talet som lästes in, samt summan av de tal som var mindre
än det första talet som lästes in. 
a.
Minst en förekomst av ett tal som var större, respektive mindre
än det första talet som lästes in måste förekomma i de 
efterföljande inlästa talen.
Utskriften bör se ut på följande sätt om 50 var första talet:
Input first number to compare to others
     50
     _________________________
     Input number 1
     1
     Input number 2
     2
     Input number 3
     3
     Input number 4
     4
     Input number 5
     5
     Input number 6
     55
     Input number 7
     55
     Input number 8
     55
     Input number 9
     55
     Input number 10
     55
     Sum of numbers larger then 50 is 275
     Sum of numbers smaller then 50 is 15");
            Console.ReadKey();
            Console.Clear();

            int number;
            int sumOfLarger = 0;
            int sumOfSmaller = 0;

            Console.Write("Skriv in första talet att jämföra med: ");
            int firstNumber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 11; i++)
            {
                Console.Write($"Skriv in tal {i} att jämföra med: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > firstNumber)
                {
                    sumOfLarger += number;
                }
                else
                {
                    sumOfSmaller += number;
                }
            }
            Console.WriteLine($"Sum of number larger than {firstNumber} is: {sumOfLarger}");
            Console.WriteLine($"Sum of numbers smaller than {firstNumber} is: {sumOfSmaller}");
            Console.ReadKey();
        }
    }
}
