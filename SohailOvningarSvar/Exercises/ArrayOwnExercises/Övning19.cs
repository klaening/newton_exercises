using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning19
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.\n");

            Console.WriteLine(Check(123, 12300));
            Console.WriteLine(Check(1230, 1237));
            Console.WriteLine(Check(200, 300));
            Console.WriteLine(Check(120, 199));
            Console.ReadKey();
        }

        public bool Check(int num1, int num2)
        {
            return num1 >= 100 && num1 <= 200 || num2 >= 100 && num2 <= 200;
        }
    }
}
