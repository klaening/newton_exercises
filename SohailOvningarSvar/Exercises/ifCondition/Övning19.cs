using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning19
    {

        /*En anställd som har timlön får, när arbetstiden överstiger 40 timmar per  vecka, 
         * övertidsbetalning för tiden utöver 40 timmar med en och halv timme  Läs in timlön och en veckas arbetstid.  
         * Den totala veckolönen beräkans och skrivs ut.*/


        /*public double CalcSalary(double wage, double hours)
        {
            double salary = wage * hours;
            if (hours > 40)
            {
                salary = wage * hours + (1.5 * wage);
            }
            return salary;
        }*/
        double ob = 0.5;

        public void Print()
        {
            Console.Write("Vad är din timlön: ");
            double wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Skriv in hur många timmar du har jobbat den här veckan: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Din veckolön: {CalcSalary(wage, hours)}");
            Console.ReadKey();
        }

        public double CalcSalary(double wage, double hours)
        {
            double salary = wage * hours;
            if (hours > 40)
            {
                /*double ob = (hours - 40) * wage * 0.5;
                salary = salary + ob;*/
                salary = ((hours - 40) * ob * wage) + salary;
            }
            return salary;
        }
    }
}
