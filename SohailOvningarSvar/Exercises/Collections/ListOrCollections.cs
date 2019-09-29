using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohailOvningar.Exercises.Collections
{
    class ListOrCollections
    {
        //I Collection samlingen så finns: array, arraylist, list
        //En array har bestämt antal indexplatser, en list är som en dynamisk array, du kan lägga till och ta bort platser
        
        public void ArrayListExample1()
        {
            //En dynamisk array
            //Du kan blanda datatyper i en array list
            //Du kan bara hämta "objekt" från en array list.
            //Inga matematiska beräkningar

            ArrayList medical = new ArrayList();
            medical.Add("Sohail");
            medical.Add(52);
            medical.Add(175);
            medical.Add(26.4f);

            //måste skriva "object" eftersom i en array list så behandlas indexplatsernas information som objekt och inte som datatyper
            foreach (object info in medical)
            {
                Console.WriteLine(info);
            }
            Console.ReadLine();
        }

        public void ListExample1()
        {
            //En dynamisk array som tar av samma datatyper
            // Kan göra matematiska beräkningar
            //List<datatyp>
            //Tex om vi vill ha en lista på alla våra köpval och summera priserna

            List<int> Groceries = new List<int>();
            Groceries.Add(34);
            Groceries.Add(134);
            Groceries.Add(41);
            Groceries.Add(304);
            Groceries.Add(56);

            int sum = 0;

            foreach (int grocery in Groceries)
            {
                sum += grocery;
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.ReadLine();
        }

        public static void RunMedical()
        {
            ListOrCollections ex1 = new ListOrCollections();
            ex1.ArrayListExample1();

            ListOrCollections ex2 = new ListOrCollections();
            ex2.ListExample1();
        }
    }
}
