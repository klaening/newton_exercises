using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class ifConditionMenu
    {
        public void PrintMenu()
        {

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

        public void PrintMenuIf()
        {
            String choice;
            do
            {
                ifConditionMenu menuIf = new ifConditionMenu();
                menuIf.PrintMenu();

                choice = Console.ReadLine();
                Console.Clear();

                #region ifCondition Cases

                switch (choice)
                {
                    case "0":
                        break;

                    #region Övning 1 - 10
                    case "1":
                        ifCondition.Övning11.RunExercise11();
                        break;

                    case "2":
                        ifCondition.Övning12 ö12 = new ifCondition.Övning12();
                        ö12.Print();
                        break;

                    case "3":
                        ifCondition.Övning13 ö13 = new ifCondition.Övning13();
                        ö13.Print();
                        break;

                    case "4":
                        ifCondition.Övning14 ö14 = new ifCondition.Övning14();
                        ö14.Print();
                        break;

                    case "5":
                        ifCondition.Övning15 ö15 = new ifCondition.Övning15();
                        ö15.Print();
                        break;

                    case "6":
                        ifCondition.Övning16 ö16 = new ifCondition.Övning16();
                        ö16.Print();
                        break;

                    case "7":
                        ifCondition.Övning17 ö17 = new ifCondition.Övning17();
                        ö17.Print();
                        break;

                    case "8":
                        ifCondition.Övning18 ö18 = new ifCondition.Övning18();
                        ö18.Print();
                        break;

                    case "9":
                        ifCondition.Övning19 ö19 = new ifCondition.Övning19();
                        ö19.Print();
                        break;

                    case "10":
                        ifCondition.Övning20 ö20 = new ifCondition.Övning20();
                        ö20.Print();
                        break;
                    #endregion

                    #region Övning 11 - 20
                    case "11":
                        ifCondition.Övning21 ö21 = new ifCondition.Övning21();
                        ö21.Print();
                        break;

                    case "12":
                        ifCondition.Övning22 ö22 = new ifCondition.Övning22();
                        ö22.Print();
                        break;

                    case "13":
                        ifCondition.Övning23 ö23 = new ifCondition.Övning23();
                        ö23.Print();
                        break;

                    case "14":
                        ifCondition.Övning24 ö24 = new ifCondition.Övning24();
                        ö24.Print();
                        break;

                    case "15":
                        ifCondition.Övning25 ö25 = new ifCondition.Övning25();
                        ö25.Print();
                        break;

                    case "16":
                        ifCondition.Övning26 ö26 = new ifCondition.Övning26();
                        ö26.Print();
                        break;

                    case "17":
                        ifCondition.Övning27 ö27 = new ifCondition.Övning27();
                        ö27.Print();
                        break;

                    case "18":
                        break;

                    case "19":
                        ifCondition.Övning29 ö29 = new ifCondition.Övning29();
                        ö29.Print();
                        break;

                    case "20":
                        ifCondition.Övning29Continued ö29C = new ifCondition.Övning29Continued();
                        ö29C.Print();
                        break;
                    #endregion

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
