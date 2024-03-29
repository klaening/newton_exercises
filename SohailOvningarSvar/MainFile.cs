﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar
{
    class MainFile
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            menus.CoolHeader coolHeader = new menus.CoolHeader();
            coolHeader.PrintCoolHeader1();

            String choice;

            do
            {
                Console.Clear();
                menus.CoolHeader cH = new menus.CoolHeader();
                cH.PrintCoolHeader2();

                #region Head Menu
                menus.HeadMenu headMenu = new menus.HeadMenu();
                headMenu.PrintMenu();

                choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        //Bob Tabor Menu
                        menus.BobTaborMenu menuBT = new menus.BobTaborMenu();
                        menuBT.PrintMenuBT();
                        break;

                    case "2":
                        //Sequence Programming Menu
                        menus.sequenceProgrammingMenu menuSP = new menus.sequenceProgrammingMenu();
                        menuSP.PrintMenuSP();
                        break;

                    case "3":
                        //If Loop Menu
                        menus.ifConditionMenu menuIf = new menus.ifConditionMenu();
                        menuIf.PrintMenuIf();
                        break;

                    case "4":
                        //For Loop Menu
                        menus.LoopsMenu menuLoops = new menus.LoopsMenu();
                        menuLoops.PrintMenuLoops();
                        break;

                    case "5":
                        //Arrays Menu
                        menus.ArraysMenu menuArrays = new menus.ArraysMenu();
                        menuArrays.PrintSwitchArrays();
                        break;

                    case "6":
                        menus.OwnArrays menuOwnArray = new menus.OwnArrays();
                        menuOwnArray.PrintSwitchOwnArrays();
                        break;

                    case "7":
                        Exercises.Exempel.Reference.ReferenceExempel();
                        break;

                    case "exit":
                        Console.WriteLine("Avslutar program.");
                        break;

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        break;
                }
                #endregion
            } while (choice != "exit");
        }
    }
}
