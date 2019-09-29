using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning60
    {
        public void Print()
        {
            Console.WriteLine(@"
Läs in positiva heltal. Inläsningen avbryts med 0.
Beräkna antalet ggr två intilliggande tal är lika.
Printen 
MÅSTE
vara i följande format, oavsett när ni avslutar 
programmet med 0:
Input first nr
2
Input nr to compare to previous nr
3
Input nr to compare to previous nr
4
Input nr to compare to previous nr
5
Input nr to compare to previous nr
5
Input nr to compare to previous nr
5
Input nr to compare to previous nr
7
Input nr to compare to previous nr
7
Input nr to compare to previous nr
9
Input nr to compare to previous nr
9
Input nr to compare to previous nr
0
There are: 4 nr of occurances of the same nr");
            Console.WriteLine();

            int input;

            Console.Write("Input first nr: ");
            input = int.Parse(Console.ReadLine());

            int compareNumber = input;
            int i = 2;
            int nrOfOccurances = 0;

            while (input != 0)
            {
                Console.Write($"Input nr {i} to compare to previous nr: ");
                input = int.Parse(Console.ReadLine());

                if (compareNumber == input)
                {
                    nrOfOccurances += 1;
                }

                compareNumber = input;
                i++;
            }

            Console.WriteLine($"There are: {nrOfOccurances} occurances of the same nr.");
            Console.ReadKey();
        }
    }
}
