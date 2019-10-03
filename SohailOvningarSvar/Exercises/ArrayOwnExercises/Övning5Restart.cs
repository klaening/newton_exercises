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
            int[] arrOccurances = new int[length];
            int occurances = 1;
            int duplicates = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"element {i}: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        arrOccurances[j] = occurances;
                        occurances++;
                    }
                }
                occurances = 1;
            }

            foreach (int element in arrOccurances)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < length; i++)
            {
                if (arrOccurances[i] == 2)
                {
                    duplicates++;
                }
            }

            Console.WriteLine($"There are {duplicates} duplicates.");
            Console.ReadLine();
        }
    }
}
