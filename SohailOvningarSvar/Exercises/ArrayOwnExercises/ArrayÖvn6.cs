using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class ArrayÖvn6
    {
        public void Print()
        {
            Console.WriteLine(@"
6. Write a program in C# Sharp to print all unique elements in an array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5 ");
            Console.WriteLine();

            Console.Write("Skriv in längd: ");
            int length = int.Parse(Console.ReadLine());
            int[] intArray = new int[length];
            int counter = 0;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"element - {i} : ");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                counter = 0;

                for (int j = 0; j < i - 1; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        counter++;
                    }
                }

                for (int k = i+1; k < length; k++)
                {
                    if (intArray[i] == intArray[k])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine($"Unique numbers: {intArray[i]}");
                }
                counter = 0;
            }

            Console.ReadKey();
        }
    }
}
