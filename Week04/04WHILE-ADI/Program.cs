using System;

namespace _04WHILE_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("START! druk op y om verder te gaan");
            string antwoord = Console.ReadLine();

            while (antwoord == "y")
            {
                Console.Write("druk op y om verder te gaan");
                antwoord = Console.ReadLine();
            }

            Console.WriteLine("KLAAR");



            Console.WriteLine("Geef je wachtwoord: ");
            string check = Console.ReadLine();

            while (check != "VIS")
            {
                Console.WriteLine("Foutief wachtwoord, try again.");
                check = Console.ReadLine();
            }

            Console.WriteLine("Je bent aangemeld.");


            Random random = new Random();
            int getal = random.Next(1, 20);

            Console.Write("Geef een getal: ");
            int gok = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            while (getal != gok && count < 10)
            {
                Console.Write("Gok opnieuw: ");
                gok = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            Console.WriteLine($"Het getal was {getal}");

            //reeks 3 9 27 81 273 ... Int16.MaxValue
            int i = 3;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= 3;
            }

            Console.WriteLine();
            //belangrijk: VOLGORDE VAN CODE
            //reeks 3 9 27 81 273 ... Int16.MaxValue
            i = 1;
            while (i < Int16.MaxValue)
            {
                i *= 3;
                Console.Write(i + " ");
            }

            //reeks2
            Console.WriteLine("\nreeks 2");
            int x = Convert.ToInt32(Console.ReadLine());

            i = x;
            while (i < Int16.MaxValue)
            {
                i *= x;
                Console.Write(i + " ");
            }

            Console.WriteLine();
            i = x;
            while (i < Int16.MaxValue)
            {
                Console.Write(i + " ");
                i *= x;
            }


            //do while -- gaat altijd op z'n minst 1 keer loopen
            //volgorde van code hier ook belangrijk is
            Console.WriteLine("\nreeks 3");
            i = x;

            do
            {
                Console.Write(i + " ");
                i *= x;
            }while(i < Int16.MaxValue);

            //volgorde gewisseld
            Console.WriteLine("\nreeks 3");
            i = x;

            do
            {
                i *= x;
                Console.Write(i + " ");

            } while (i < Int16.MaxValue);





        }
    }
}
