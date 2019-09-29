using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class ArraysMenu
    {
        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|            Meny Arrays            |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 65; i <= 90; i++)
            {
                Console.WriteLine($"{i}. Övning {i}");
            }

            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }
        public void PrintMenuArrays()
        {
            String choice;
            do
            {
                ArraysMenu menuArrays = new ArraysMenu();
                menuArrays.PrintMenu();

                choice = Console.ReadLine();
                #region Arrays
                switch (choice)
                {
                    case "0":
                        break;

                    case "1":
                        Exercises.Arrays.ArrayExamples.RunArray();
                        break;

                    case "2":
                        Exercises.Collections.ListOrCollections.RunMedical();
                        break;

                    case "3":
                        break;

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        break;
                }
                break;
                #endregion
            } while (choice != "0");
        }
    }
}
