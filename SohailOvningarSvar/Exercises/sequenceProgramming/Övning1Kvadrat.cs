using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning1Kvadrat
    {
        //Min funktion CalcInput returnerar mitt argument number som är av datatypen double i kvadrat
        public double CalcInput(double number)
        {
            return number * number;
        }

        public void Print()
        {
            Console.Write("Skriv in ett tal så räknar vi ut kvadraten av det talet: ");
            //Det jag anger som String i programmet konverteras till en double och värdet instanseras i min variabel input
            double input = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Kvadraten av ditt tal är: {CalcInput(input)}");

            Console.WriteLine();
            Console.Write("Tryck på valfri tangent för att avsluta:");
            Console.ReadKey();
        }
    }
}
