using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning3CalcHours
    {
        /*
        //double för att timmar kan anges i decimaler
        double input;
        double minutes = 60;
        double seconds = 3600;

        public double CalcToMin()
        {
            return input * minutes;
            //kan också skriva min *= 60
        }

        public double CalcToSec()
        {
            return input * seconds;
        }

        public void Print()
        {
            Console.Write("Ange hur många timmar: ");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("I minuter: {0} I sekunder: {1}", CalcToMin(), CalcToSec());
            //Console.WriteLine("I sekunder: {0}", CalcToSec());
            Console.ReadLine();
        }*/
        //Räkna ut antal timmar till minuter och sekunder

        public double CalcToMinutes(double hours)
        {
            return hours * 60;
        }

        public double CalcToSeconds(double hours)
        {
            return hours * 60 * 60;
        }


        public void Print()
        {
            Console.Write("Ange hur många timmar: ");
            double inputHrs = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dina timmar i minuter: {CalcToMinutes(inputHrs)}");
            Console.WriteLine($"Dina timmar i sekunder: {CalcToSeconds(inputHrs)}");
            Console.ReadKey();
        }
    }
}
