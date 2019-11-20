using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SohailOvningar.Exercises.ArrayOwnExercises;


namespace SohailOvningar.menus
{
    class OwnArrays
    {
        public void PrintMenu()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|          Meny Egna Arrays         |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i}. Övning {i}");
            }
            Console.WriteLine();

            Console.WriteLine("");
            Console.WriteLine("0. Huvudmeny");
            Console.WriteLine();
            Console.Write("Välj case: ");
        }

        String choice;
        public void PrintSwitchOwnArrays()
        {
            do
            {
                Console.Clear();
                PrintMenu();

                choice = Console.ReadLine();
                Console.Clear();


                switch (choice)
                {
                    case "0":
                        break;

                    case "1":
                        ArrayÖvn1 ö1 = new ArrayÖvn1();
                        ö1.Print();
                        break;

                    case "2":
                        ArrayÖvn2 ö2 = new ArrayÖvn2();
                        ö2.Print();
                        break;

                    case "3":
                        ArrayÖvn3 ö3 = new ArrayÖvn3();
                        ö3.Print();
                        break;

                    case "4":
                        ArrayÖvn4 ö4 = new ArrayÖvn4();
                        ö4.Print();
                        break;

                    case "5":
                        ArrayÖvn5 ö5 = new ArrayÖvn5();
                        ö5.Print();
                        //ö5.PrintFacit();
                        break;

                    case "5a":
                        Övning5Restart ö5a = new Övning5Restart();
                        ö5a.Print();
                        break;

                    case "6":
                        ArrayÖvn6 ö6 = new ArrayÖvn6();
                        ö6.Print();
                        break;

                    case "7":
                        Övning7 ö7 = new Övning7();
                        ö7.Print();
                        break;

                    case "8":
                        Övning8 ö8 = new Övning8();
                        ö8.Print();
                        break;

                    case "9":
                        Övning9 ö9 = new Övning9();
                        ö9.Print();
                        break;

                    case "10":
                        Övning10 ö10 = new Övning10();
                        ö10.Print();
                        break;

                    case "11":
                        Övning11 ö11 = new Övning11();
                        ö11.Print();
                        break;

                    case "12":
                        Övning12 ö12 = new Övning12();
                        ö12.Print();
                        break;

                    case "13":
                        Övning13 ö13 = new Övning13();
                        ö13.Print();
                        break;

                    case "14":
                        Övning14 ö14 = new Övning14();
                        ö14.Print();
                        break;

                    case "15":
                        Övning15 ö15 = new Övning15();
                        ö15.Print();
                        break;

                    case "16":
                        Övning16 ö16 = new Övning16();
                        ö16.Print();
                        break;

                    case "17":
                        Övning17 ö17 = new Övning17();
                        ö17.Print();
                        break;

                    case "18":
                        Övning18 ö18 = new Övning18();
                        ö18.Print();
                        break;

                    case "19":
                        Övning19 ö19 = new Övning19();
                        ö19.Print();
                        break;

                    case "20":
                        Övning20 ö20 = new Övning20();
                        ö20.Print();
                        break;

                    case "21":
                        Övning21 ö21 = new Övning21();
                        ö21.Print();
                        break;

                    case "22":
                        Övning22 ö22 = new Övning22();
                        ö22.Print();
                        break;

                    case "23":
                        Övning23 ö23 = new Övning23();
                        ö23.Print();
                        break;

                    case "24":
                        Övning24 ö24 = new Övning24();
                        ö24.Print();
                        break;

                    case "25":
                        Övning25 ö25 = new Övning25();
                        ö25.Print();
                        break;

                    case "26":
                        Övning26 ö26 = new Övning26();
                        ö26.Print();
                        break;

                    case "27":
                        Övning27 ö27 = new Övning27();
                        ö27.Print();
                        break;

                    case "28":
                        Övning28 ö28 = new Övning28();
                        ö28.Print();
                        break;

                    case "29":
                        Övning29 ö29 = new Övning29();
                        ö29.Print();
                        break;

                    default:
                        Console.WriteLine("Error, try again");
                        Console.ReadKey();
                        break;
                }
            } while (choice != "0");
        }
    }
}
