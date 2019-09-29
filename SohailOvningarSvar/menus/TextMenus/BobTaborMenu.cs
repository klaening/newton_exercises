using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.TextMenus
{
    class BobTaborMenu
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
            Console.WriteLine("1. Övning 1");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Skriv 'back' för att komma till huvudmeny");
            Console.WriteLine();

            Console.Write("Välj case: ");
        }
    }
}
