using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.ArrayOwnExercises
{
    class Övning5Restart
    {
        public void Print()
        {
            Console.Write("Hur många platser i din array? ");
            int length = int.Parse(Console.ReadLine());

            int[] intArray = new int[length];
            int[] intArray2 = new int[length];
            int[] intArray3 = new int[length];
            int occurances = 1;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"element {i}: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            intArray.CopyTo(intArray2, 0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (intArray[i] == intArray2[j])
                    {
                        intArray3[i] = occurances;
                        occurances++;
                    }
                }
                occurances = 1;
            }

            /*for (int i = 0; i < length; i++)
            {
                if (intArray3)
                {

                }
            }

            Console.WriteLine($"There are {duplicates} duplicates.");
            Console.ReadLine();*/
        }
    }
}
