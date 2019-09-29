using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning44
    {
        public void Print()
        {
            Console.WriteLine(@"Bestäm hur många tal du vill summera. Läs in detta antal och 
summera dem, printa ut dem.
Tex om du skriver in 5, så Måste printen se ut på följande vis:
Skriv in antal ggr för Summa beräkningen
5
Omgång1 är summan: 5,
Omgång2 är summan: 10,
Omgång3 är summan: 15,
Omgång4 är summan: 20,
Omgång5 är summan: 25");
            Console.WriteLine();
            Console.WriteLine("Lösning 1:");
            Console.WriteLine();
            Console.Write("Skriv in hur många tal du vill addera: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int sum = length;

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine($"Omgång {i} är summan {sum}");
                sum += length;
            }
            Console.ReadKey();
            Console.WriteLine();

            //Lösning 2
            Console.WriteLine("Lösning 2:");
            Console.WriteLine();
            Console.Write("Skriv hur många tal du vill addera: ");
            length = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            for (int i = 1; i < length; i++)
            {
                Console.Write($"Skriv in siffra {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                sum += number;
                Console.WriteLine($"Omgång {i} är summan: {sum}");
                Console.WriteLine();
            }
            Console.ReadKey();

            //Lösning 3
            Console.WriteLine("Lösning 3:");
            Console.WriteLine();
            Console.Write("Skriv hur många tal du vill addera: ");
            length = Convert.ToInt32(Console.ReadLine());
            sum = 0;

            for (int i = 1; i < length; i++)
            {
                Console.Write($"Skriv in siffra {i}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    sum += number;
                }
                else
                {
                    sum += number;
                    Console.WriteLine($"Omgång {i} är summan: {sum}");
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
