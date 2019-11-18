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
                                  "Arrays övningar", "Egna övningar", "Examples"};

            Console.WriteLine();
            Console.WriteLine();

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
