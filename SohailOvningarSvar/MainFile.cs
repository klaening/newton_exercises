using System;
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
            coolHeader.PrintCoolHeader2();

            String choice;

            do
            {
                #region Head Menu
                menus.TextMenus.HeadMenu headMenu = new menus.TextMenus.HeadMenu();
                headMenu.PrintMenu();

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        //Bob Tabor Menu
                        menus.SwitchMenus.SwitchMenus menuBT = new menus.SwitchMenus.SwitchMenus();
                        menuBT.PrintMenuBT();
                        break;

                    case "2":
                        //Sequence Programming Menu
                        menus.SwitchMenus.SwitchMenus menuSP = new menus.SwitchMenus.SwitchMenus();
                        menuSP.PrintMenuSP();
                        break;

                    case "3":
                        //If Loop Menu
                        menus.SwitchMenus.SwitchMenus menuIf = new menus.SwitchMenus.SwitchMenus();
                        menuIf.PrintMenuIf();
                        break;

                    case "4":
                        //For Loop Menu
                        menus.SwitchMenus.SwitchMenus menuFor = new menus.SwitchMenus.SwitchMenus();
                        menuFor.PrintMenuFor();
                        break;

                    case "5":
                        //Arrays Menu
                        menus.SwitchMenus.SwitchMenus menuArrays = new menus.SwitchMenus.SwitchMenus();
                        menuArrays.PrintMenuArrays();
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
