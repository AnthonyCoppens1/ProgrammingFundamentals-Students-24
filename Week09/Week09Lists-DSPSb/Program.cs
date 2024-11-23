using System;
using System.Collections.Generic;

namespace Week09Lists_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D array --> set length
            int[] array = new int[5];
            array[0] = 5;
            array[1] = 10;
            array[2] = 15;
            array[3] = 20;
            array[4] = 25;


            //lists with variable length! Depending on the amount of elements inside at the moment

            List<int> ints = new List<int>();
            ints.Add(5);
            ints.Add(10);
            ints.Add(15);
            ints.Add(20);
            ints.Add(25);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();


            //insert numbers into chosen spot
            ints.Insert(2, 12); //5 10 12 15 20 25

            //insert same number same spot 
            ints.Insert(4, 18);
            ints.Insert(4, 19); //careful for positioning of numbers in order

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //add multiple elements at end of list --> from array
            int[] numbers = { 7, 8, 9 };
            ints.AddRange(numbers); //5 10 12 15 19 18 20 25 7 8 9

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //multiple numbers at specific index
            ints.InsertRange(1, numbers);

            //5 7 8 9 10 12 15 19 18 20 25 7 8 9

            //print the list
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //getting rid of specific numbers
            //789 is appearing twice in the list

            ints.Remove(7);
            ints.Remove(8);
            ints.Remove(9);

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ints.Add(5);
            ints.RemoveAt(0); //remove at index

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //removing a range from an index
            ints.RemoveRange(7, 4);

            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //new list + more ways of adding elements to a list
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            // 1 5
            for (int i = 0; i < N.Count; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();

            //use for-loop to make --> 1 2 3 4 5
            for (int i = 4; i > 1; i--)
            {
                N.Insert(1, i);
            }

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            N.RemoveRange(1, 3);
            
            for (int i = 2; i <= 4; i++)
            {
                N.Insert(i - 1, i);
            }

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //list of strings
            List<string> str = new List<string> {"one", "two", "three"};

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            str.Add("four");
            str.Add("five");

            str.Insert(0, "-one");
            str.Remove("two");
            str.RemoveAt(4);

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str.Add("one");

            //find index of a word
            int index = str.IndexOf("one");
            Console.WriteLine(index);

            int last = str.LastIndexOf("one");
            Console.WriteLine(last);


            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            //add word to list, check if it is there and make adjustments
            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //list to array
            string[] strings = str.ToArray();

            //array to a list
            double[] doubles = { 1.2, 3.4, 2.3, 5.7 };
            List<double> D = doubles.ToList();

            //other examples of possibilities
            List<bool> B = new List<bool> { true, false, false, true, true, true, false };
            List<double> DD = new List<double> { 4.1, 4.2, 4.3 };
            List<byte> BB = new List<byte> { 1, 2, 254, 3, 7 };


        }
    }
}
