using System;
//Om du skriver den här koden så sliper du skriva Console varje gång:
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning6Algorythm
    {
        //Beräkna resultatet av funktionen ax^3+7. Variablerna a och x ska läsas in.
        /*double a, x;
        public double Calculation()
        {
            return (a * x * x * x) + 7;
        }

        public void Print()
        {
            Console.Write("Ange a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ange x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Beräkningen slutförd. Resultat: {0}", Calculation());
            Console.Write("Tryck på valfri tangent för att avsluta:");
            Console.ReadKey();
            
        }*/

        //Lösning Soheil

        //Har integer som argument i sin funktion
        /*public int Algo(int a, int x)
        {
            return (a * x * x * x) + 7;
        }

        public void PrintAlgo()
        {
            //Skapar int i sin metod och konverterar String till decimal
            Console.WriteLine("Ange värdet för a:");
            int a = (int)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ange värdet för x:");
            int x = (int)Convert.ToDecimal(Console.ReadLine());

            //Kallar på sin funktion, märk att argumenten kommer i samma följd
            Console.WriteLine("Svar: {0}", Algo((int)a, (int)x));
            Console.ReadKey();
            
        }*/

        public int Algo(int a, int x)
        {
            return (a * x * x * x) + 7;
        }

        public void Print()
        {
            Write("Ange värde för a: ");
            int a = (int)Convert.ToDecimal(ReadLine());
            Write("Ange värde som x: ");
            int x = (int)Convert.ToDecimal(ReadLine());

            WriteLine($"Resultatet av beräkningen är: {Algo(a, x)}");
            ReadKey();
        }
    }
}
