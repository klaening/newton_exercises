using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus.SwitchMenus
{
    class SwitchMenus
    {
        public void PrintMenuBT()
        {
            String choice;
            do
            {
                menus.TextMenus.BobTaborMenu menuBT = new menus.TextMenus.BobTaborMenu();
                menuBT.PrintMenu();

                choice = Console.ReadLine();

                #region Bob Tabor Cases
                switch (choice)
                {
                    case "1":
                        BobTabor.ForIteration BT1 = new BobTabor.ForIteration();
                        BT1.Print();
                        break;

                    case "back":
                        break;

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        SwitchMenus repeatMenu = new SwitchMenus();
                        repeatMenu.PrintMenuBT();
                        break;
                }
                break;
                #endregion
            } while (choice != "back");
        }

        //Sätt ihop menyerna med Switch cases
        public void PrintMenuSP()
        {
            do
            {
                try
                {
                    menus.TextMenus.sequenceProgrammingMenu menuSP = new menus.TextMenus.sequenceProgrammingMenu();
                    menuSP.PrintMenu();

                    String choice = Console.ReadLine();

                    #region Sequence Programming Cases

                    switch (choice)
                    {
                        case "back":
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

                        case "11":
                            Console.Clear();
                            menus.TextMenus.sequenceProgrammingMenu menu = new menus.TextMenus.sequenceProgrammingMenu();
                            menu.PrintMenu();
                            break;

                        default:
                            Console.WriteLine("Error, try again");
                            Console.ReadKey();
                            SwitchMenus repeatMenu = new SwitchMenus();
                            repeatMenu.PrintMenuSP();
                            break;
                            #endregion
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Error, try again!");
                    Console.ReadKey();
                }
            } while (true);
        }

        public void PrintMenuIf()
        {
            do
            {
                try
                {
                    menus.TextMenus.ifConditionMenu menuIf = new menus.TextMenus.ifConditionMenu();
                    menuIf.PrintMenu();

                    int choice = Convert.ToInt32(Console.ReadLine());

                    #region ifCondition Cases

                    switch (choice)
                    {
                        case 0:
                            break;

                        #region Övning 1 - 10
                        case 1:
                            ifCondition.Övning11.RunExercise11();
                            break;

                        case 2:
                            ifCondition.Övning12 ö12 = new ifCondition.Övning12();
                            ö12.Print();
                            break;

                        case 3:
                            ifCondition.Övning13 ö13 = new ifCondition.Övning13();
                            ö13.Print();
                            break;

                        case 4:
                            ifCondition.Övning14 ö14 = new ifCondition.Övning14();
                            ö14.Print();
                            break;

                        case 5:
                            ifCondition.Övning15 ö15 = new ifCondition.Övning15();
                            ö15.Print();
                            break;

                        case 6:
                            ifCondition.Övning16 ö16 = new ifCondition.Övning16();
                            ö16.Print();
                            break;

                        case 7:
                            ifCondition.Övning17 ö17 = new ifCondition.Övning17();
                            ö17.Print();
                            break;

                        case 8:
                            ifCondition.Övning18 ö18 = new ifCondition.Övning18();
                            ö18.Print();
                            break;

                        case 9:
                            ifCondition.Övning19 ö19 = new ifCondition.Övning19();
                            ö19.Print();
                            break;

                        case 10:
                            ifCondition.Övning20 ö20 = new ifCondition.Övning20();
                            ö20.Print();
                            break;
                        #endregion

                        #region Övning 21 - 30
                        case 11:
                            ifCondition.Övning21 ö21 = new ifCondition.Övning21();
                            ö21.Print();
                            break;

                        case 12:
                            ifCondition.Övning22 ö22 = new ifCondition.Övning22();
                            ö22.Print();
                            break;

                        case 13:
                            ifCondition.Övning23 ö23 = new ifCondition.Övning23();
                            ö23.Print();
                            break;

                        case 14:
                            ifCondition.Övning24 ö24 = new ifCondition.Övning24();
                            ö24.Print();
                            break;

                        case 15:
                            ifCondition.Övning25 ö25 = new ifCondition.Övning25();
                            ö25.Print();
                            break;

                        case 16:
                            ifCondition.Övning26 ö26 = new ifCondition.Övning26();
                            ö26.Print();
                            break;

                        case 17:
                            ifCondition.Övning27 ö27 = new ifCondition.Övning27();
                            ö27.Print();
                            break;

                        case 18:
                            break;

                        case 19:
                            ifCondition.Övning29 ö29 = new ifCondition.Övning29();
                            ö29.Print();
                            break;

                        case 20:
                            ifCondition.Övning29Continued ö29C = new ifCondition.Övning29Continued();
                            ö29C.Print();
                            break;
                        #endregion

                        default:
                            Console.WriteLine("Error, try again");
                            Console.ReadKey();
                            SwitchMenus repeatMenu = new SwitchMenus();
                            repeatMenu.PrintMenuIf();
                            break;
                    }
                    break;
                    #endregion

                }
                catch
                {
                    Console.WriteLine("Error, try again!");
                    Console.ReadKey();
                }
            } while (true);
        }

        public void PrintMenuFor()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    menus.TextMenus.LoopsMenu menuFor = new menus.TextMenus.LoopsMenu();
                    menuFor.PrintMenu();

                    int choice = Convert.ToInt32(Console.ReadLine());

                    #region forLoop Cases

                    switch (choice)
                    {
                        case 0:
                            break;

                        case 31:
                            Exercises.Loops.Övning31 ö31 = new Exercises.Loops.Övning31();
                            ö31.Print();
                            break;

                        case 32:
                            Exercises.Loops.Övning32 ö32 = new Exercises.Loops.Övning32();
                            ö32.Print();
                            break;

                        case 33:
                            Exercises.Loops.Övning33 ö33 = new Exercises.Loops.Övning33();
                            ö33.Print();
                            break;

                        case 34:
                            Exercises.Loops.Övning34 ö34 = new Exercises.Loops.Övning34();
                            ö34.Print();
                            break;

                        case 35:
                            Exercises.Loops.Övning35 ö35 = new Exercises.Loops.Övning35();
                            ö35.Print();
                            break;

                        case 37:
                            Exercises.Loops.Övning37 ö37 = new Exercises.Loops.Övning37();
                            ö37.Print();
                            break;

                        case 39:
                            Exercises.Loops.Övning39 ö39 = new Exercises.Loops.Övning39();
                            ö39.Print();
                            break;

                        case 40:
                            Exercises.Loops.Övning40 ö40 = new Exercises.Loops.Övning40();
                            ö40.Print();
                            break;

                        case 41:
                            Exercises.Loops.Övning41 ö41 = new Exercises.Loops.Övning41();
                            ö41.Print();
                            break;

                        case 42:
                            Exercises.Loops.Övning42 ö42 = new Exercises.Loops.Övning42();
                            ö42.Print();
                            break;

                        case 43:
                            Exercises.Loops.Övning43 ö43 = new Exercises.Loops.Övning43();
                            ö43.Print();
                            break;

                        case 44:
                            Exercises.Loops.Övning44 ö44 = new Exercises.Loops.Övning44();
                            ö44.Print();
                            break;

                        case 46:
                            Exercises.Loops.Övning46 ö46 = new Exercises.Loops.Övning46();
                            ö46.Print();
                            break;

                        case 47:
                            Exercises.Loops.Övning47 ö47 = new Exercises.Loops.Övning47();
                            ö47.Print();
                            break;

                        case 48:
                            Exercises.Loops.Övning48 ö48 = new Exercises.Loops.Övning48();
                            ö48.Print();
                            break;

                        case 49:
                            Exercises.Loops.Övning49 ö49 = new Exercises.Loops.Övning49();
                            ö49.Print();
                            break;

                        case 51:
                            Exercises.Loops.Övning51 ö51 = new Exercises.Loops.Övning51();
                            ö51.Print();
                            break;

                        case 52:
                            Exercises.Loops.Övning52 ö52 = new Exercises.Loops.Övning52();
                            ö52.Print();
                            break;

                        case 53:
                            Exercises.Loops.Övning53 ö53 = new Exercises.Loops.Övning53();
                            ö53.Print();
                            break;

                        case 54:
                            Exercises.Loops.Övning54 ö54 = new Exercises.Loops.Övning54();
                            ö54.Print();
                            break;

                        case 55:
                            Exercises.Loops.Övning55 ö55 = new Exercises.Loops.Övning55();
                            ö55.Print();
                            break;

                        case 56:
                            Exercises.Loops.Övning56 ö56 = new Exercises.Loops.Övning56();
                            ö56.Print();
                            break;

                        case 58:
                            Exercises.Loops.Övning58 ö58 = new Exercises.Loops.Övning58();
                            ö58.Print();
                            break;

                        case 59:
                            Exercises.Loops.Övning59 ö59 = new Exercises.Loops.Övning59();
                            ö59.Print();
                            break;

                        case 60:
                            Exercises.Loops.Övning60 ö60 = new Exercises.Loops.Övning60();
                            ö60.Print();
                            break;

                        case 61:
                            Exercises.Loops.Övning61 ö61 = new Exercises.Loops.Övning61();
                            ö61.Print();
                            break;

                        case 62:
                            Exercises.Loops.Övning62 ö62 = new Exercises.Loops.Övning62();
                            ö62.Print();
                            break;

                        case 65:
                            Exercises.Loops.Övning65 ö65 = new Exercises.Loops.Övning65();
                            ö65.Print();
                            break;

                        default:
                            Console.WriteLine("Error, try again");
                            Console.ReadKey();
                            SwitchMenus repeatMenu = new SwitchMenus();
                            repeatMenu.PrintMenuFor();
                            break;
                    }
                    break;
                    #endregion
                }
                catch
                {
                    Console.WriteLine("Error, try again!");
                    Console.ReadKey();
                }
            } /*while (true);*/
        }

        public void PrintMenuArrays()
        {
            do
            {
                try
                {
                    menus.TextMenus.ArraysMenu menuArrays = new menus.TextMenus.ArraysMenu();
                    menuArrays.PrintMenu();

                    int choice = Convert.ToInt32(Console.ReadLine());
                    #region Arrays
                    switch (choice)
                    {
                        case 0:
                            break;

                        case 1:
                            Exercises.Arrays.ArrayExamples.RunArray();
                            break;

                        case 2:
                            Exercises.Collections.ListOrCollections.RunMedical();
                            break;

                        case 3:
                            break;

                        default:
                            Console.WriteLine("Error, try again");
                            Console.ReadKey();
                            SwitchMenus repeatMenu = new SwitchMenus();
                            repeatMenu.PrintMenuArrays();
                            break;
                    }
                    break;
                    #endregion
                }
                catch
                {
                    Console.WriteLine("Error, try again!");
                    Console.ReadKey();
                }
            } while (true);
        }
    }
}
