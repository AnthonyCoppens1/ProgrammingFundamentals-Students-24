using System;

namespace Week06Array1D_EX_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculations with arrays in 2 ways, easy and algorithmically

            //easy way --> find sum, average, min, max, sort, reverse
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5};

            Console.WriteLine($"sum: {array.Sum()}");
            Console.WriteLine($"average: {array.Average()}");
            Console.WriteLine($"min: {array.Min()}");
            Console.WriteLine($"max: {array.Max()}");

            Array.Sort(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //algorithmic way
            //creating the sum and average

            array = new int[] { 1, 8, -3, 6, 9, 2, 3, -4, 5};
            //get original back --> overwrite elements

            int sum = 0; 
            //if you want to see the decimal, sum has to be a double to show average as x,...
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"average: {sum / array.Length}");


            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"min: {min}");



            //sorting algorithm
            //https://en.wikipedia.org/wiki/Bubble_sort
            //checks the current index and the adjacent one. if the 2nd one is bigger than
            //the first, nothing happens, if the first is bigger than the second, they swap positions
            //then we move on to the next set

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
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
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
