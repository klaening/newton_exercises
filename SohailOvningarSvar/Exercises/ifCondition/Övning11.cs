using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning11
    {   /*
        public void Print(double input1, double input2)
        {
            Console.Write("Skriv in första talet: ");
            input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in andra talet: ");
            input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (input1 > input2)
            {
                Console.WriteLine("Tal 1 ");
                Console.WriteLine(input1);
            }
            Console.ReadKey(); */

        public void IsVal1Bigger(double tal1, double tal2)
        {
            if (tal1>tal2)
            {
                Console.WriteLine("Tal1 är större än tal2");
            }
            else
            {
                Console.WriteLine("Tal1 är inte större än tal2");
            }
            Console.ReadKey();
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write("Läs in tal 1: ");
            double t1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Läs in tal 2: ");
            double t2 = Convert.ToDouble(Console.ReadLine());

            IsVal1Bigger(t1, t2);
        }

        //Måste vara static för att kunna komma åt den i andra klasser
        public static void RunExercise11()
        {
            Övning11 ö11 = new Övning11();
            ö11.Print();
        }
    }
}
