using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning18
    {
        public void Print()
        {
            Console.WriteLine("Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.");
            Console.WriteLine(CheckTemp(-12, 120));
            Console.WriteLine(CheckTemp(120, 40));
            Console.WriteLine(CheckTemp(150, -40));

            Console.ReadKey();
        }

        public bool CheckTemp(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp1 > 100 && temp2 < 0;
        }
    }
}
