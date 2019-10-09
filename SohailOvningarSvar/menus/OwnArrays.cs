using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            for (int i = 1; i <= 10; i++)
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
                        Exercises.ArrayOwnExercises.ArrayÖvn1 ö1 = new Exercises.ArrayOwnExercises.ArrayÖvn1();
                        ö1.Print();
                        break;

                    case "2":
                        Exercises.ArrayOwnExercises.ArrayÖvn2 ö2 = new Exercises.ArrayOwnExercises.ArrayÖvn2();
                        ö2.Print();
                        break;

                    case "3":
                        Exercises.ArrayOwnExercises.ArrayÖvn3 ö3 = new Exercises.ArrayOwnExercises.ArrayÖvn3();
                        ö3.Print();
                        break;

                    case "4":
                        Exercises.ArrayOwnExercises.ArrayÖvn4 ö4 = new Exercises.ArrayOwnExercises.ArrayÖvn4();
                        ö4.Print();
                        break;

                    case "5":
                        Exercises.ArrayOwnExercises.ArrayÖvn5 ö5 = new Exercises.ArrayOwnExercises.ArrayÖvn5();
                        ö5.Print();
                        //ö5.PrintFacit();
                        break;

                    case "5a":
                        Exercises.ArrayOwnExercises.Övning5Restart ö5a = new Exercises.ArrayOwnExercises.Övning5Restart();
                        ö5a.Print();
                        break;

                    case "6":
                        Exercises.ArrayOwnExercises.ArrayÖvn6 ö6 = new Exercises.ArrayOwnExercises.ArrayÖvn6();
                        ö6.Print();
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
