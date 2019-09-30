using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn3
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15 ");
            Console.WriteLine();

            Console.Write("Input the number of elements to be stored in the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] Numbers = new int[length];
            Console.WriteLine($"Input {length} elements in the array:");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"element - {i} : ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine($"Sum of all elements stored in the array is : {Numbers.Sum()} ");
            Console.ReadKey();
        }
    }
}
