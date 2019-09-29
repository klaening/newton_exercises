using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.TextMenus
{
    class LoopsMenu
    {
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|               Meny                |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 35; i++)
            {
                Console.WriteLine($"{i + 30}. Övning {i + 30}");
            }

            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();

            Console.Write("Välj case: ");
        }
    }
}
