using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning4Sum
    {
        /*double average;
        double sum;

        public double CalcAverage(double input1, double input2, double input3)
        {
            sum = input1 + input2 + input3;
            Console.WriteLine();
            Console.WriteLine($"Summan är: {sum}");
            return average = sum / 3;
        }

        public void Print()
        {
            Console.Write("Ange ett tal: ");
            double inp1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange andra talet: ");
            double inp2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ange tredje talet: ");
            double inp3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Medeltal: {0}", CalcAverage(inp1, inp2, inp3));
            Console.ReadLine();
        }*/

        public double CalcSum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public double CalcAverage(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }

        public void Print()
        {
            Console.WriteLine("Skriv in tre tal och så räknar jag ut summan och medeltalet");
            Console.WriteLine();

            Console.Write("Första talet: ");
            double input1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Andra talet: ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tredje talet: ");
            double input3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            #region Colour
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            #endregion
            Console.WriteLine($"Summan av talen är: {CalcSum(input1, input2, input3)}!");
            Console.WriteLine($"Medeltalet är: {CalcAverage(input1, input2, input3).ToString("0.00")}!");
            #region Colour
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            #endregion
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tack för idag!");
            Console.Write("Tryck på valfri tangent för att avsluta: ");
            Console.ReadKey();
        }
    }
}
