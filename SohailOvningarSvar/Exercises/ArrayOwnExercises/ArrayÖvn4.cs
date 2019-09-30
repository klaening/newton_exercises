using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn4
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
4. Write a program in C# Sharp to copy the elements one array into another array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 15
element - 1 : 10
element - 2 : 12
Expected Output:
The elements stored in the first array are :
15 10 12
The elements copied into the second array are :
15 10 12 ");
            Console.WriteLine();

            Console.Write("Input the number of elements to be stored in the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] Numbers = new int[length];

            Console.WriteLine($"Input {length} elements in the array:");
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                Console.Write($"element - {i} : ");
                int input = int.Parse(Console.ReadLine());
                Numbers[i] = input;
            }
            Console.WriteLine();

            Console.WriteLine("The elements stored in the first array are: ");
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            int[] Numbers2 = new int[length];
            int round = 0;

            foreach (int number in Numbers)
            {
                Numbers2[round] = number;
                round++;
            }
            Console.WriteLine("The elements copied into the second array are: ");

            foreach (int number in Numbers2)
            {
                Console.WriteLine(number);
            }

            //Array.Copy(Array Numbers, Array Numbers2, int length);
            Console.ReadLine();
        }
    }
}
