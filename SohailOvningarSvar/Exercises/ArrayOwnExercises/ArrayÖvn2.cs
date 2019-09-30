using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn2
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2 ");

            Console.Write("Input the number of elements to store in the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] Numbers = new int[length];

            Console.WriteLine($"Input {length} number of elements in the array: ");

            for (int i = 0; i < length; i++)
            {
                Console.Write("element - 0 : ");
                Numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Array.Sort(Numbers);
            Console.WriteLine($"The values store into the array are: ");
            foreach (int number in Numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Array.Reverse(Numbers);
            Console.WriteLine("The values store into the array in reverse are: ");
            foreach (int number in Numbers)
            {
                Console.Write($"{number} ");
            }
            Console.ReadKey();
        }
    }
}
