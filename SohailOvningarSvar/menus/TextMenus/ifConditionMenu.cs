using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.TextMenus
{
    class ifConditionMenu
    {
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("*-----------------------------------*");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|               Meny                |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("*-----------------------------------*");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 11; i <= 30; i++)
            {
                Console.WriteLine($"{i}. Övning {i}");
            }
            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();

            Console.Write("Välj case: ");
        }
    }
}
