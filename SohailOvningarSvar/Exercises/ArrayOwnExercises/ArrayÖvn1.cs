using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn1
    {
        public void Print()
        {
            Console.WriteLine(@"
1. Write a program in C# Sharp to store elements in an array and print it. Go to the editor
Test Data:
Input 10 elements in the array:
element - 0 : 1
element - 1 : 1
element - 2 : 2
.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 9 ");

            int Length = 10;
            int[] Numbers = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"element - {i} : ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Elements in array are: ");
            foreach (int nr in Numbers)
            {
                Console.Write($"{nr} ");
            }
            Console.ReadKey();
        }
    }
}
