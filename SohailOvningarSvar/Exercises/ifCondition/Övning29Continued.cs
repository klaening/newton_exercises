using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning29Continued
    {
        string arrivalTime;
        int ankHrs, ankMin;

        public string CheckTime(int hours, int minutes, int input1, int input2)
        {
            ankHrs = hours + input1;
            ankMin = minutes + input2;

            if (ankMin >= 60)
            {
                ankMin = ankMin - 60;
                ankHrs = ankHrs + 1;
                arrivalTime = $"{ankHrs}:{ankMin}";
            }
            if (ankHrs >= 24)
            {
                ankHrs = ankHrs - 24;
                arrivalTime = $"{ankHrs}:{ankMin} " + $"nästa dag";
            }
            else
            {
                arrivalTime = $"{ankHrs}:{ankMin}";
            }
            return arrivalTime;
        }
        public void Print()
        {
            Console.WriteLine("Skriv in avgångstid, timmar först: ");
            int hrs = int.Parse(Console.ReadLine());
            Console.Write("Skriv in minuter: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Hur lång är resan? Timmar först: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuter: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            CheckTime(hrs, min, input1, input2);
            Console.WriteLine($"Ankomsttiden är: {arrivalTime}");
            Console.ReadKey();
        }
    }
}
