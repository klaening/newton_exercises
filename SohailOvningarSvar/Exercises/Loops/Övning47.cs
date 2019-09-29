using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Loops
{
    class Övning47
    {
        public void Print()
        {
            Console.WriteLine(
@"Beräkna och skriv ut produkten av dem ojämna heltalen mellan 1 till 
15. 
a.
dvs, 1*3*5*... *15");
            Console.WriteLine();
            int sum = 1;

            for (int i = 1; i <= 15; i += 2)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
