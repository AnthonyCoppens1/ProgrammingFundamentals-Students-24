using System;
using System.Collections.Immutable;

namespace Week06Array1D_EX_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5 };

            //easy way --> find sum, min, average, max, sort and reverse
            Console.WriteLine("sum: " + array.Sum());
            Console.WriteLine("min: " + array.Min());
            Console.WriteLine("average: " + array.Average());
            Console.WriteLine("max: " + array.Max());

            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Array.Reverse(array); //if after .Sort() --> reverses the sorted one
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //algorithmic way
            //creating sum and average

            array = new int[]{ 1, 8, -3, 6, 9, 2, 3, -4, 5 };
            //get original order back --> overwrite elements
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; //sum = sum + array[i]
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("average: " + sum/array.Length);

            //find minimum
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min: " + min);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //sorting algorithm
            //https://en.wikipedia.org/wiki/Bubble_sort
            //checks from start each adjacent pair of numbers,
            //if 2nd is bigger then first it swaps, if not, moves 1 spot, checks again
            //until whole array is sorted

            for (int i = 0; i < array.Length; i++)
            { //checks multiple times for max all elements times
                for (int j = 0; j < array.Length-1; j++)
                { //checks array
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j]; 
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();




            //reversing:
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
