using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class HeadMenu
    {
        public void PrintMenu()
        {
            //Console.Clear();

            String[] Exercises = { "Bob Tabor övningar", "Sequence Programming övningar", "if Condition övningar", "Loops övningar",
                                  "Arrays övningar", "Collections", "Examples" };

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("|                                   |");
            //Console.WriteLine("|               Meny                |");
            //Console.WriteLine("|                                   |");
            //Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            /*for (int i = 0; i < Exercises.Length; i++)
            {
                Console.WriteLine($"{i+1}. {Exercises[i]}");
            }*/

            int i = 0;

            foreach (String exercise in Exercises)
            {
                Console.WriteLine($"{i+1}. {Exercises[i]}");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("'exit'. Avsluta");
            Console.WriteLine();

            Console.Write("Välj vilken mapp: ");
        }
    }
}
