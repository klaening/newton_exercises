using System;
namespace SohailOvningar.Exercises.Loops
{
    public class Övning35
    {
        //Beräkna och skriv ut kvadraten för talen 1 till 9
        //Resultet ska skrivas i formen som "Kvadraten för 1 är: 1"

        public void Print()
        {
            int resultat;

            for (int i = 1; i <= 9; i++)
            {
                resultat = i * i;
                Console.WriteLine($"Kvadraten för {i} är: {resultat}");
            }
            Console.ReadKey();
        }
    }
}
