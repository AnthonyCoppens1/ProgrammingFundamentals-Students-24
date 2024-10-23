using System;

namespace Week06Arrays2D_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating 2D arrays
            int[,] ints = new int[4, 7];
            string[,] fruit = { {"apple", "banana", "starfruit", "lemon"},
            {"lime", "mango", "kiwi", "strawberry" },
            {"peach", "melon", "grapefruit", "pineapple" }};

            //get values
            //keep in mind we start at (0,0)
            Console.WriteLine($"element row 1 col 1: {fruit[0, 0]}");
            Console.WriteLine($"Grapefruit? {fruit[2, 2]}");

            fruit[2, 1] = "watermelone";
            Console.WriteLine(fruit[2, 1]);


            //looping through 2D arrays
            Console.WriteLine(fruit.Length); //all elements combined
            Console.WriteLine("# rows: " + fruit.GetLength(0));
            Console.WriteLine("# cols: " + fruit.GetLength(1));

            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + " ");
                }
                Console.WriteLine();
            }

            //filling a 2D array with random numbers
            Random ran = new Random();
            
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = ran.Next(0, 21);
                    Console.Write(ints[i,j] + "\t"); // \t is a tab
                }
                Console.WriteLine();
            }

            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine(sum);


            /*
             * CAREFUL, loops over string and the inner loop goes over character by character
            foreach (string item in fruit)
            {
                foreach (string element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }*/
            

        }
    }
}
