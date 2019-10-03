using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class Collections
    {
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|          Meny Collections         |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. Övning {i}");
            }

            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }

        public void PrintSwitchCollections()
        {
            String choice;
            do
            {
                PrintMenu();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Exercises.Collections.ListOrCollections.RunMedical();
                        break;

                    default:
                        break;
                }
            } while (choice != "0");
        }
    }
}
