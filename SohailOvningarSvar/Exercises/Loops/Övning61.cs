using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning61
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in ett antal positiva heltal sorterade i växande ordning. Talföljden
slut anges med 0. 
Om det finns fel i sorteringsordningen ska utskriften ske enligt 
följande exempel:
Exempel på talföljd som matas in, och dess resultat:
1 1 2 7 4 6 12 16 13 8 12 24 samt 0 för att avsluta programmet.
Input first nr
1
Input nr 2
1
Input nr 3
2
Input nr 4
7
Input nr 5
4
The nr 5 is wrong, it should be 4
Input nr 6
6
Input nr 7
 12
 Input nr 8
 16
 Input nr 9
 13
 The nr 9 is wrong, it should be 13
 Input nr 10
 8
 The nr 10 is wrong, it should be 8
 Input nr 11
 12
 Input nr 12
 24
 Input nr 13
 0
 The nr 13 is wrong, it should be 0");
            Console.WriteLine();

            int number;
            int lastNumber;
            int i = 2;

            Console.Write("Input first nr: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            lastNumber = number;

            while (number != 0)
            {
                Console.Write($"Input nr {i}: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // if break först så att den kollar det argumentet och breakar innan den går vidare och ger ett nytt värde på lastNumber
                if (number == 0)
                {
                    break;
                }
                if (number < lastNumber)
                {
                    Console.WriteLine($"Input nr {i} is wrong, it should be {lastNumber} or bigger than {lastNumber}.");
                }
                else
                {
                    lastNumber = number;
                }

                i++;
            }
            Console.WriteLine($"Last number revieved: {lastNumber}");
            Console.ReadKey();
        }
    }
}
