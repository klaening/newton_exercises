using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning29
    {
        /*Beräkna ankomsttiden för ett tåg.
        
        Mata in följande:
        tidpunkt i timma och minut för avgången, tex 12:41
        körtid i timma och minuter.
        Om minuter anges i 60 min eller mer, hantera det genom att lägga ett påslag på variabeln för timmar. */

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
        /*int arrHour, arrMin;
        
        public void TrainTime(int depHrs, int depMin, int travelHrs, int travelMin)
        {
            arrHour = depHrs + travelHrs;
            arrMin = depMin + travelMin;

            if (arrMin >= 60)
            {
                arrMin = arrMin - 60;
                arrHour = arrHour + 1;
            }
            //Du kan ha flera if och då kommer den gå in i de efter varandra
            if (arrHour >= 24)
            {
                arrHour = arrHour - 24;
                Console.WriteLine("Arrival NEXT DAY");
            }
            Console.WriteLine($"Arrival time: {arrHour}:{arrMin}");
        }
        public void Print()
        {
            Console.Write("Skriv in avgångstid, timmar först: ");
            int hrs = int.Parse(Console.ReadLine());

            Console.Write("Skriv in minuter: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Skriv in resetid, timmar först: ");
            int travHrs = int.Parse(Console.ReadLine());

            Console.Write("Skriv in minuter: ");
            int travMin = int.Parse(Console.ReadLine());

            TrainTime(hrs, min, travHrs, travMin);
            Console.ReadKey();
        }*/
    }
}
