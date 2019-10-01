using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Arrays
{
    class Övning66
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"Övn66: En array innehåller personnr, med formatet YYMMDD-NNNN. 
Kontrollera att födelsedatumet följ av en streck innan de fyra sista siffrorna, skriv ut ett fel meddelande annars.");
            Console.WriteLine();

            String socNumber = Console.ReadLine();
            char[] charArray = socNumber.ToCharArray();
            String check = charArray[6].ToString();

            if (check != "-")
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                Console.WriteLine("Right input!");
            }
            Console.ReadKey();


            String socNumberEx = "871107-4859";
            char[] socArray = socNumberEx.ToCharArray(6, 1);

            //String är dubbelfnuttar, char är enkelfnuttar
            if (socNumberEx[6] != '-')
            {
                Console.WriteLine("Wrong input!");
            }


            /*char[] charArray = new char[11];
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine($"skriv nr {i+1}: ");
                charArray[i] = Convert.ToChar(Console.ReadLine());
            }

            foreach (char letter in charArray)
            {
                Console.WriteLine(letter);
                if (charArray[6] != "-")
                {

                }
                Console.Write(letter);
            }
            Console.ReadLine();*/

/*            SocNumbers.

            char[] letterNr = new char[11];

            foreach (char nr in SocNumbers)
            {
                letterNr[j] = nr;

                if (letterNr[6] == "-")
                {
                    Console.WriteLine("Valid input!");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            Console.ReadLine();*/
        }
    }
}
