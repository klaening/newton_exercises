using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.TextMenus
{
    class HeadMenu
    {
        public void PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            String[] Exercises = { "Bob Tabor övningar", "Sequence Programming övningar", "if Condition övningar", "Loops övningar",
                                  "Arrays övningar", "Exempel och Tenta" };

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|               Meny                |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            /*for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{i+1}. {Choices[i]}");
            }*/
            int i = 1;

            foreach (String exercise in Exercises)
            {
                Console.WriteLine($"{i}. {Exercises}");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("'exit'. Avsluta");
            Console.WriteLine();

            Console.Write("Välj vilken mapp: ");
        }
    }
}
