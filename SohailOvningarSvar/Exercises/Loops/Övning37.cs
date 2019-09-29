using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning37
    {
        public void Print()
        {
            Console.WriteLine(
@"Läs in antal tal du vill ange, läs sedan in talen och printa ut de. OBS! 
Du ska inte kunna skriva in fler eller mindre tal än vad du först angav.
a.
Formatet ska vara följande om jag skrev in 4 för antal siffror som ska ska skrivas ut.
Skriv in ett tal
23
1:a talet
Skriv in ett tal
65
2:a talet
Skriv in ett tal
8
3:a talet
Skriv in ett tal
455
4:a talet
");


            Console.Write("Skriv hur många tal du vill lägga till: ");
            //skapar en int som ska bestämma hur många tal man vill ha
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Använd dig av variabeln amount för att bestämma hur många gånger du ska loopa for loopen
            for (int i = 1; i <= amount; i++)
            {
                Console.Write($"Skriv tal {i}: ");
                //variabeln number får ett nytt värde vid varje loop
                //använder mig av String eftersom jag inte kommer göra några beräkningar på värdet.
                String number = Console.ReadLine();
                Console.WriteLine($"Du angav numret: {number}");
                Console.WriteLine();
            }
            Console.ReadKey();
            
            /*Lösning med arrays*/
            
            Console.WriteLine();
            Console.WriteLine("Hur många platser vill du lägga till i din array?");

            int size = Convert.ToInt32(Console.ReadLine());

            int[] Numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Skriv in tal {i+1}: ");
                Console.WriteLine();
                int number = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = number;
            }

            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
}
