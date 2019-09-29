using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.sequenceProgramming
{
    class Övning8RectangleArea
    {
        /*Läs in sidorna av en rektangel, beräkna och skriv ut arean och omkretsen.*/
        public double CalcRectArea(double height, double width)
        {
            return width * height;
        }

        public double CalcRectCirc(double height, double width)
        {
            return (width * 2) + (height * 2);
        }

        public void Print()
        {
            Console.Write("Ange höjden på rektangeln: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ange bredden på rektangeln: ");
            double w = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Arean på rektangeln är: {CalcRectArea(h, w)}");
            Console.WriteLine();
            Console.WriteLine($"Omkretsen på rektangeln är: {CalcRectCirc(h, w)}");
            Console.ReadKey();
        }
    }
}
