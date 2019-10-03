using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
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

            for (int i = 31; i <= 65; i++)
            {
                if (i == 36 || i == 38 || i == 45 || i == 50 || i == 57 || i == 63 || i == 64)
                {
                }
                else
                {
                    Console.WriteLine($"{i}. Övning {i}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("ex. Multiplication Example");
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();

            Console.Write("Välj case: ");
        }

        public void PrintMenuLoops()
        {
            String choice;
            do
            {
                Console.Clear();
                LoopsMenu menuLoops = new LoopsMenu();
                menuLoops.PrintMenu();

                choice = Console.ReadLine();

                #region Loop Cases

                switch (choice)
                {
                    case "ex":
                        Exercises.Loops.LoopMultiplicationExample le = new Exercises.Loops.LoopMultiplicationExample();
                        le.Print();
                        break;

                    case "0":
                        break;

                    case "31":
                        Exercises.Loops.Övning31 ö31 = new Exercises.Loops.Övning31();
                        ö31.Print();
                        break;

                    case "32":
                        Exercises.Loops.Övning32 ö32 = new Exercises.Loops.Övning32();
                        ö32.Print();
                        break;

                    case "33":
                        Exercises.Loops.Övning33 ö33 = new Exercises.Loops.Övning33();
                        ö33.Print();
                        break;

                    case "34":
                        Exercises.Loops.Övning34 ö34 = new Exercises.Loops.Övning34();
                        ö34.Print();
                        break;

                    case "35":
                        Exercises.Loops.Övning35 ö35 = new Exercises.Loops.Övning35();
                        ö35.Print();
                        break;

                    case "37":
                        Exercises.Loops.Övning37 ö37 = new Exercises.Loops.Övning37();
                        ö37.Print();
                        break;

                    case "39":
                        Exercises.Loops.Övning39 ö39 = new Exercises.Loops.Övning39();
                        ö39.Print();
                        break;

                    case "40":
                        Exercises.Loops.Övning40 ö40 = new Exercises.Loops.Övning40();
                        ö40.Print();
                        break;

                    case "41":
                        Exercises.Loops.Övning41 ö41 = new Exercises.Loops.Övning41();
                        ö41.Print();
                        break;

                    case "42":
                        Exercises.Loops.Övning42 ö42 = new Exercises.Loops.Övning42();
                        ö42.Print();
                        break;

                    case "43":
                        Exercises.Loops.Övning43 ö43 = new Exercises.Loops.Övning43();
                        ö43.Print();
                        break;

                    case "44":
                        Exercises.Loops.Övning44 ö44 = new Exercises.Loops.Övning44();
                        ö44.Print();
                        break;

                    case "46":
                        Exercises.Loops.Övning46 ö46 = new Exercises.Loops.Övning46();
                        ö46.Print();
                        break;

                    case "47":
                        Exercises.Loops.Övning47 ö47 = new Exercises.Loops.Övning47();
                        ö47.Print();
                        break;

                    case "48":
                        Exercises.Loops.Övning48 ö48 = new Exercises.Loops.Övning48();
                        ö48.Print();
                        break;

                    case "49":
                        Exercises.Loops.Övning49 ö49 = new Exercises.Loops.Övning49();
                        ö49.Print();
                        break;

                    case "51":
                        Exercises.Loops.Övning51 ö51 = new Exercises.Loops.Övning51();
                        ö51.Print();
                        break;

                    case "52":
                        Exercises.Loops.Övning52 ö52 = new Exercises.Loops.Övning52();
                        ö52.Print();
                        break;

                    case "53":
                        Exercises.Loops.Övning53 ö53 = new Exercises.Loops.Övning53();
                        ö53.Print();
                        break;

                    case "54":
                        Exercises.Loops.Övning54 ö54 = new Exercises.Loops.Övning54();
                        ö54.Print();
                        break;

                    case "55":
                        Exercises.Loops.Övning55 ö55 = new Exercises.Loops.Övning55();
                        ö55.Print();
                        break;

                    case "56":
                        Exercises.Loops.Övning56 ö56 = new Exercises.Loops.Övning56();
                        ö56.Print();
                        break;

                    case "58":
                        Exercises.Loops.Övning58 ö58 = new Exercises.Loops.Övning58();
                        ö58.Print();
                        break;

                    case "59":
                        Exercises.Loops.Övning59 ö59 = new Exercises.Loops.Övning59();
                        ö59.Print();
                        break;

                    case "60":
                        Exercises.Loops.Övning60 ö60 = new Exercises.Loops.Övning60();
                        ö60.Print();
                        break;

                    case "61":
                        Exercises.Loops.Övning61 ö61 = new Exercises.Loops.Övning61();
                        ö61.Print();
                        break;

                    case "62":
                        Exercises.Loops.Övning62 ö62 = new Exercises.Loops.Övning62();
                        ö62.Print();
                        break;

                    case "65":
                        Exercises.Loops.Övning65 ö65 = new Exercises.Loops.Övning65();
                        ö65.Print();
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
