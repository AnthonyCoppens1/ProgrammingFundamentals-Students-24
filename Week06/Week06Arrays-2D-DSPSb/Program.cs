using System;

namespace Week06Arrays_2D_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating 2D arrays
            int[,] ints = new int[4, 5];

            string[,] fruit = { {"apple", "lemon", "banana", "orange", "kiwi", "starfruit" },
            {"lime", "mango", "cherry", "strawberry", "watermelon", "pommegranate" },
            {"peach", "grapefruit", "pineapple", "durian", "grape", "pear" } };

            //get values
            //keep in mind we start at 0,0
            Console.WriteLine($"first element first row: {fruit[0, 0]}"); //apple
            Console.WriteLine($"getting strawberry: {fruit[1, 3]}"); //strawberry
            Console.WriteLine($"last element: {fruit[2, 5]}");

            fruit[2, 5] = "kakifruit";
            Console.WriteLine($"last element: {fruit[2, 5]}");


            //looping through arrays
            Console.WriteLine(fruit.Length);
            Console.WriteLine($"# of rows: {fruit.GetLength(0)}");
            Console.WriteLine($"# of columns: {fruit.GetLength(1)}");

            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t");
                }
                Console.WriteLine();
            }


            /*BEWARE, foreach treats the 2D arrays as 1 big string, looks at words separated
             * inner foreach loop then checks char by char
             * 
             * foreach (var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/


            //filling an array with random numbers
            Random rd = new Random();
            for (int i = 0; i < ints.GetLength(0); i++) //rows
            {
                for (int j = 0; j < ints.GetLength (1); j++) //columns
                {
                    ints[i, j] = rd.Next(0,21);
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }


            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
