using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn5
    {
        public void Print()
        {
            Console.Clear();
            Console.WriteLine(@"
5. Write a program in C# Sharp to count a total number of duplicate elements in an array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 1
element - 2 : 1
Expected Output :
Total number of duplicate elements found in the array is : 1 ");
            Console.WriteLine();

            Console.Write("Input the number of elements to be stored in the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] Array1 = new int[length];
            int[] Array2 = new int[length];
            int duplicates = 0;

            for (int i = 0; i < length; i++)
            {
                Array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                Array1[i] = Array2[i];
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (Array1[i] == Array2[j])
                    {
                        duplicates++;
                        Console.WriteLine(duplicates);
                    }
                }
            }

            Console.WriteLine($"Number of duplicates are: {duplicates}");
            Console.ReadLine();
        }
    }
}
