using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning10FahrToCelc
    {
        public double ConvertFToC(double fahr)
        {
            return (fahr - 32) / 1.8;
        }

        public void Print()
        {
            Console.Clear();
            Console.WriteLine("Läser in temperatur i Fahrenheit och konverterar till Celsius.");
            Console.WriteLine();

            Console.Write("Skriv in hur många grader i Fahrenheit du vill konvertera: ");
            double degrees = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"{degrees} grader Fahrenheit i Celsius är {ConvertFToC(degrees)}");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Tryck på valfri tangent för att avsluta programmet:");
            Console.ReadKey();
        }

    }
}
