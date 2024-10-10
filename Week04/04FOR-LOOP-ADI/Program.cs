using System;

namespace _04FOR_LOOP_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maaltafel van een getal
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            //IDIOTE VERSIE
            Console.WriteLine($"{getal} * 1 = {getal * 1}");
            Console.WriteLine($"{getal} * 2 = {getal * 2}");
            Console.WriteLine($"{getal} * 3 = {getal * 3}");
            Console.WriteLine($"{getal} * 4 = {getal * 4}");

            
            //BETERE VERSIE
            Console.WriteLine("\nFOR LOOP i = 0, i <= 10");
            for (int i = 0; i <= 10; i++) //i = i + 1
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 1, i <= 10");
            for (int i = 1; i <= 10; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 0, i <= 10, stepsize 2");
            for (int i = 0; i <= 10; i+=2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }

            

            Console.WriteLine("\nFOR LOOP i = 1, i <= 10, stepsize 2");
            for (int i = 1; i <= 10; i += 2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            Console.WriteLine("\nFOR LOOP i = 1, i <= 10, stepsize  * 2");
            for (int i = 1; i <= 10; i *= 2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            /*Console.WriteLine("\nFOR LOOP i = 0, i <= 10, stepsize  * 2");
            for (int i = 0; i <= 10; i *= 2)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            } PAS OP VOOR INFINITE LOOP!*/


            Console.WriteLine("\nFOR LOOP i = 10, i >= 0, i--"); //i = i - 1
            for (int i = 10; i >= 0; i--)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }


            /* PAS OP VOOR INFINITE LOOP, 10 11 12 bereikt nooit 0.
             * Console.WriteLine("\nFOR LOOP i = 10, i >= 0, i--");
            for (int i = 10; i >= 0; i++)
            {
                int resultaat = getal * i;
                Console.WriteLine($"{getal} * {i} = {resultaat}");
            }*/

            //print 3 6 9 12 15 18 ... 100
            Console.WriteLine("\nversie 1: 3 6 9 12");
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }

            //optie 2 van versie 1
            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " "); // Console.Write($"{i} ");
                }
            }



            //for loops nesten: for loop in for loop
            Console.Write("\n\nGeef x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nGeef y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\ntabel van j's (waarde)");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\ntabel van sterren");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\ntabel van i's (waarde)");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }


            //Piramides
            Console.WriteLine("Hier start de piramide");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



        }
    }
}
