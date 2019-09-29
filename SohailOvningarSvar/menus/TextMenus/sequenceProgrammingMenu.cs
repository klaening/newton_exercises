using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.TextMenus
{
    class sequenceProgrammingMenu
    {
        public void PrintMenu()
        {
            String[] Choices = { "Kvadrat", "Salary Provision", "Calculate Hours", "Sum", "Currency",
                                        "Algorythm", "Petrol", "RectangleArea", "CircleArea", "Fahrenheit to Celsius" };

            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|               Meny                |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}. Övning {i+1} {Choices[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Skriv  Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }
    }
}
