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

            Console.WriteLine("ex. Exempel");
            for (int i = 66; i <= 76; i++)
            {
                if (i != 71)
                {
                    Console.WriteLine($"{i}. Övning {i}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }
        public void PrintSwitchArrays()
        {
            String choice;
            do
            {
                PrintMenu();

                choice = Console.ReadLine();
                #region Arrays
                switch (choice)
                {
                    case "1":
                        Exercises.Arrays.ArrayExamples.RunArray();
                        break;

                    case "66":
                        Exercises.Arrays.Övning66 ö66 = new Exercises.Arrays.Övning66();
                        ö66.Print();
                        break;

                    case "67":
                        Exercises.Arrays.Övning67 ö67 = new Exercises.Arrays.Övning67();
                        ö67.Print();
                        break;

                    case "68":
                        Exercises.Arrays.Övning68 ö68 = new Exercises.Arrays.Övning68();
                        ö68.Print();
                        break;

                    case "69":
                        Exercises.Arrays.Övning69 ö69 = new Exercises.Arrays.Övning69();
                        ö69.Print();
                        break;

                    case "70":
                        Exercises.Arrays.Övning70 ö70 = new Exercises.Arrays.Övning70();
                        ö70.Print();
                        break;

                    case "72":
                        Exercises.Arrays.Övning72 ö72 = new Exercises.Arrays.Övning72();
                        ö72.Print();
                        break;

                    case "73":
                        Exercises.Arrays.Övning73 ö73 = new Exercises.Arrays.Övning73();
                        ö73.Print();
                        break;

                    case "74":
                        Exercises.Arrays.Övning74 ö74 = new Exercises.Arrays.Övning74();
                        ö74.Print();
                        break;

                    case "75":
                        Exercises.Arrays.Övning75 ö75 = new Exercises.Arrays.Övning75();
                        ö75.Print();
                        break;

                    case "76":
                        Exercises.Arrays.Övning76 ö76 = new Exercises.Arrays.Övning76();
                        ö76.Print();
                        break;

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        break;
                }
                #endregion
            } while (choice != "0");
        }
    }
}
