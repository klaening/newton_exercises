using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.ifCondition
{
    class Övning24
    {
        //Läs in kropptempraturen, skriv “VARNING!!“” om temp är mindre än 35, och  om temp överstiger 42.
        public void CheckTemp(double temp)
        {
            if (temp < 35 || temp > 42)
            {
                Console.WriteLine("VARNING!!");
            }
        }

        public void Print()
        {
            Console.Write("Skriv in din temperatur: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            CheckTemp(temp);
            Console.ReadKey(); 
        }
    }
}
