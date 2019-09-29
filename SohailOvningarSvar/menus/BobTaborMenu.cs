using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.menus
{
    class BobTaborMenu
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
            Console.WriteLine("1. Övning 1");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();

            Console.Write("Välj case: ");
        }

        public void PrintMenuBT()
        {
            String choice;
            do
            {
                BobTaborMenu menuBT = new BobTaborMenu();
                menuBT.PrintMenu();

                choice = Console.ReadLine();

                #region Bob Tabor Cases
                switch (choice)
                {
                    case "0":
                        break;

                    case "1":
                        BobTabor.ForIteration BT1 = new BobTabor.ForIteration();
                        BT1.Print();
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
