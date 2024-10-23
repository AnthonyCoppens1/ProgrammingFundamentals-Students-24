﻿using System;

namespace Week06JaggedArrays_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating jagged arrays
            int[][] ints = new int[3][];
            ints[0] = new int[] { 1, 2, 3, 4 };
            ints[1] = new int[] { 5 };
            ints[2] = new int[] { 6, 7, 8 };

            string[][] fruit = {new string[] {"apple", "avocado", "apricot"},
            new string[]{"banana", "berry", "breadfruit"},
            new string[]{"coconut"},
            new string[]{"dragonfruit", "durian"}};

            double[][] doubles = {new double[] {1.2, 5.6},
            new double[] {4, 5.8, 7}};

            //getting values
            Console.WriteLine(fruit[2][0]);
            Console.WriteLine(doubles[1][1]);

            doubles[1][1] = 6;
            Console.WriteLine(doubles[1][1]);
            
            //looping arrays
            for (int i = 0; i < fruit.Length; i++) //length is 4
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write(fruit[i][j] + " ");
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
