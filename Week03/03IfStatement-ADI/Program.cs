using System;

namespace _03IfStatement_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statements - keuzes maken en dingen uitvoeren naargelang de keuze

            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal < 50)
            {
                Console.WriteLine("Getal is kleiner dan 50");
            }
            else if (getal == 50)
            {
                Console.WriteLine("Getal is 50");
            }
            else
            {
                Console.WriteLine("Getal is groter dan 50");
            }


            //if statement wordt gezien als een aparte entiteit, zorg dat je altijd werkt met vaste structuur
            Console.WriteLine();
            Console.WriteLine("testsituatie");
            if (getal < 50)
            {
                Console.WriteLine("Getal is kleiner dan 50");
            }
            if (getal == 50)
            {
                Console.WriteLine("Getal is 50");
            }
            else
            {
                Console.WriteLine("Getal is groter dan 50");
            }



            //optie 2 voor if-statement
            if (getal < 50)
            {
                Console.WriteLine("kleiner");
            }
            else
            {
                if (getal == 50)
                {
                    Console.WriteLine("gelijk");
                }
                else
                {
                    Console.WriteLine("groter");
                }
            }


            //optie 3 if-statement genest in if
            if (getal < 50 || getal == 50) //if (getal != 50)
            {
                if (getal == 50)
                {
                    Console.WriteLine("50");
                }
                else
                {
                    Console.WriteLine("KLEIN");
                }
            }
            else
            {
                Console.WriteLine("GROOT");
            }


            //combinaties maken en controleren.
            //controleren of een getal (niet) gelijk is aan 50

            //optie 1
            if (getal == 50)
            {
                Console.WriteLine("exact 50");
            }
            else
            {
                Console.WriteLine("NIET 50");
            }


            //optie 2
            if (getal < 50 || getal > 50)
            {
                Console.WriteLine("NIET 50");
            }
            else
            {
                Console.WriteLine("exact 50");
            }


            //optie 3
            if (getal != 50)
            {
                Console.WriteLine("NIET 50");
            }
            else
            {
                Console.WriteLine("exact 50");
            }

            
            //optie 4
            if (!(getal == 50))
            {
                Console.WriteLine("NIET 50");
            }
            else
            {
                Console.WriteLine("exact 50");
            }


            //optie 5
            if (!(getal > 50) && !(getal < 50))
            {
                Console.WriteLine("exact 50");
            }
            else
            {
                Console.WriteLine("NIET 50");
            }


            //optie 6
            getal = 50; 
            bool condition = getal != 50;

            if (condition) //als condition true bevat --> voert hij deze code uit, anders die van else.
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }
            else
            {
                Console.WriteLine("Getal is 50");
            }


            //optie 7
            if (!condition)
            {
                Console.WriteLine("Getal is 50");
            }
            else
            {
                Console.WriteLine("Getal is niet gelijk aan 50");
            }

        }
    }
}
