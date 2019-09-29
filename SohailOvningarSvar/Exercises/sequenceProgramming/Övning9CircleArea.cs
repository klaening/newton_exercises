using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning9CircleArea
    {
        //Går att använda sig av en variabel av Pi isf i en const som betyder att den inte kan ändras om man inte ändrar i koden.

        /*Beräkna en cirkels diameter, omkrets, och area.Läs in cirkelns radie.
            Printa resultaten med string interpolation i en enda writeline metod.*/

            //Jag skapar en funktion som returnerar en beräkning för en cirkels diameter
        public double CalcCircleDiameter(double radius)
        {
            return radius * 2;
        }
        //Jag skapar en funktion som returnerar en beräkning för en cirkels omkrets
        public double CalcCircleCirc(double radius)
        {
            return CalcCircleDiameter(radius) * Math.PI;
        }
        //Jag skapar en funktion som returnerar en beräkning för en cirkels area
        public double CalcCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        //Min metod som hämtar input och skriver ut resultat på skärmen
        public void Print()
        {
            Console.Write("Ange radien på din cirkel: ");
            //Den tar min input av datatypen String och konverterar till datatypen double
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            //Min funktion CalcCircleDiameter tar min input (r) och returnerar ett värde som blir min diameter
            //Jag använder mig av String interpolation när jag skriver ut resultatet. 
            Console.WriteLine($"Cirkelns diameter är: {CalcCircleDiameter(r)}");
            Console.WriteLine();

            //Min funktion CalcCircleDiameter tar min input (r) och returnerar ett värde som blir min diameter
            //För att mitt resultat inte ska ha för många decimaler lägger jag till en .ToString("0.00") för att bestämma antalet decimaler
            Console.WriteLine($"Cirkelns omkrets är: {CalcCircleCirc(r).ToString("0.00")}");
            Console.WriteLine();

            //Min funktion CalcCircleDiameter tar min input (r) och returnerar ett värde som blir min diameter
            Console.WriteLine($"Cirkelns area är: {CalcCircleArea(r).ToString("0.00")}");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Tryck på valfri tangent för att avsluta:");
            Console.ReadKey();
        }
    }
}
