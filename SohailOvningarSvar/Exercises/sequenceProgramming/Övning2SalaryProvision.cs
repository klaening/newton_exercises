using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning2SalaryProvision
    {
        /*//Jag skapar en double som ska bli det som användaren ger som input//
        double number;

        //Det här är en funktion eftersom den returnerar något
        public double CalcDouble()
        {
            double salary = 8000;
            //Min funktion CalcDouble()//
            //Här skriver jag vad som ska hända med det talet via return//
            return number * 0.09 + salary;
        }

        public void Print()
        {
            //Min metod Print()//
            //Här skriver jag metoden så att man kan printa ut det på skärmen

            Console.Write("Ange vad du sålde för den här månaden: ");
            //Den tar min input som string och konverterar den till en integer, man läser från höger till vänster//
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            //Konsollen använder min funktion CalcDouble och multiplicerar med 0.09//
            Console.WriteLine("Din provision blir: {0}", CalcDouble());
            Console.WriteLine();
            //Konsollen använder CalcDouble och adderar sen grundlönen på 8000//
            Console.WriteLine("Din totala lön blir: {0}", CalcDouble());
            Console.WriteLine();
            Console.Write("Tryck på valfri tangent för att avsluta ");
            //En sista ReadLine för att hinna se resultatet/
            Console.ReadLine();
        }*/


        //En anställd får 8000:- i grundlön + 9% provision på allt hen säljer. Användaren ger sin totala försäljning som input
        //Räkna ut slutlönen och skriv ut på skärmen.

        //Jag gör en funktion av typen double eftersom den kommer att returnera decimaler
        int salary = 8000;

        public double CalcProvision(double provision)
        {
            return salary + provision * 0.09;
        }

        public void Print()
        {
            Console.Write("Skriv in din försäljning för den här månaden: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Din totala slutlön blir: {CalcProvision(input).ToString("0.00")}");
            Console.WriteLine();

            Console.Write("Tryck på valfri tangent för att avsluta programmet:");
            Console.ReadKey();
        }
    }
}
