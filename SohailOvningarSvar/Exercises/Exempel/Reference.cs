using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Exempel
{
    class Reference
    {
        public static void ReferenceExempel()
        {
            int i = 1;
            double d = 2;

            Console.WriteLine($"Före uppdateringen:    i={i} och d={d}");
            Console.WriteLine();

            Uppdatera(i, d);

            Console.WriteLine($"Efter uppdateringen:   i={i} och d={d}");
            Console.WriteLine("Dvs samma värden, uppdateringsmetoden medförde ingen ändring i ursprungliga variablerna utanför metoden.");
            Console.WriteLine();

            UppdateraInt(i);
            UppdateraDouble(d);
            Console.WriteLine($"Efter uppdateringen:   i={i} och d={d}");
            Console.WriteLine();

            Uppdatera(ref i, ref d);
            Console.WriteLine($"Efter uppdatering med referens:   i={i} och d={d}");
            Console.WriteLine("Uppdateringsmetoden har nu även ändrat värdena utanför metoden.");
            Console.ReadKey();
        }

        public static void Uppdatera(int i, double d)
        {
            i = 100;
            d = 200;
        }
        public static double UppdateraDouble(double d)
        {
            return d *= 200;
        }

        public static int UppdateraInt(int i)
        {
            return i *= 100;
        }

        public static void Uppdatera(ref int i, ref double d)
        {
            i = 100;
            d = 200;
        }
    }
}
