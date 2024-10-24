using System;

namespace Week06Arrays2D_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aanmaken van 2D arrays
            int[,] ints = new int[4, 5];
            string[,] fruit = { { "appel", "banaan", "staranijs", "avocado", "mango"},
            {"aardbei", "druif", "ananas", "limoen", "citroen" },
            {"perzik", "appelsien", "mandarijn", "veenbes", "braambes" }};


            //waarden krijgen
            //onthoud, we starten bij 0,0
            Console.WriteLine($"1e rij 2e element: {fruit[0, 1]}");
            Console.WriteLine($"Laatste rij, laatste element: {fruit[2, 4]}");

            fruit[2, 4] = "peer";
            Console.WriteLine($"Laatste rij, laatste element: {fruit[2, 4]}");


            //erdoor loopen
            Console.WriteLine(fruit.Length);
            Console.WriteLine($"# rijen: {fruit.GetLength(0)}");
            Console.WriteLine($"# kolommen: {fruit.GetLength(1)}");

            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + " ");
                }
                Console.WriteLine();
            }

            //toont alles in 1 rij na mekaar
            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }

            /* LET OP, ziet 2D array als 1 gigantische, buitenste loop bekijkt woord per woord
             * binnenste bekijkt char per char
            foreach(var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }*/
            Console.WriteLine();

            //array opvullen met random getallen
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rd.Next(0, 21);
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int som = 0;
            foreach (var item in ints)
            {
                som += item;
            }

            Console.WriteLine(som);


        }
    }
}
