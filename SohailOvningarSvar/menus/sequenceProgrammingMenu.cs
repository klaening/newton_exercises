using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class sequenceProgrammingMenu
    {
        public void PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
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
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }

        public void PrintMenuSP()
        {
            String choice;
            do
            {
                sequenceProgrammingMenu menuSP = new sequenceProgrammingMenu();
                menuSP.PrintMenu();

                choice = Console.ReadLine();

                #region Sequence Programming Cases

                switch (choice)
                {
                    case "0":
                        break;

                    #region Övning 1 - 10
                    case "1":
                        sequenceProgramming.Övning1Kvadrat ö1 = new sequenceProgramming.Övning1Kvadrat();
                        ö1.Print();
                        break;

                    case "2":
                        sequenceProgramming.Övning2SalaryProvision ö2 = new sequenceProgramming.Övning2SalaryProvision();
                        ö2.Print();
                        break;

                    case "3":
                        sequenceProgramming.Övning3CalcHours ö3 = new sequenceProgramming.Övning3CalcHours();
                        ö3.Print();
                        break;

                    case "4":
                        sequenceProgramming.Övning4Sum ö4 = new sequenceProgramming.Övning4Sum();
                        ö4.Print();
                        break;

                    case "5":
                        sequenceProgramming.Övning5Currency ö5 = new sequenceProgramming.Övning5Currency();
                        ö5.Print();
                        break;

                    case "6":
                        sequenceProgramming.Övning6Algorythm ö6 = new sequenceProgramming.Övning6Algorythm();
                        ö6.Print();
                        break;

                    case "7":
                        sequenceProgramming.Övning7Petrol ö7 = new sequenceProgramming.Övning7Petrol();
                        ö7.Print();
                        break;

                    case "8":
                        sequenceProgramming.Övning8RectangleArea ö8 = new sequenceProgramming.Övning8RectangleArea();
                        ö8.Print();
                        break;

                    case "9":
                        sequenceProgramming.Övning9CircleArea ö9 = new sequenceProgramming.Övning9CircleArea();
                        ö9.Print();
                        break;

                    case "10":
                        sequenceProgramming.Övning10FahrToCelc ö10 = new sequenceProgramming.Övning10FahrToCelc();
                        ö10.Print();
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        break;
                        #endregion
                }
            } while (choice != "0");
        }
    }
}
