using System;
using System.Collections.Generic;

namespace Week09Lists_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D arrays --> set length
            int[] nrArray = new int[5];
            nrArray[0] = 5;
            nrArray[1] = 10;
            nrArray[2] = 15;
            nrArray[3] = 20;
            nrArray[4] = 25;

            //list --> variable length depending on the # elements inside at the moment
            List<int> ints = new List<int>();
            ints.Add(5);
            ints.Add(10);
            ints.Add(15);
            ints.Add(20);
            ints.Add(25);

            //print out the list
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();

            //current list: 5 10 15 20 25
            //insert number in chosen spot! --> old pos moves up 1
            ints.Insert(2, 12);

            //print out the list
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();

            //same index, different number
            // 5 10 12 15 20 25
            ints.Insert(4, 21);
            ints.Insert(4, 22);

            //5 10 12 15 22 21 20 25

            //adding multiple elements at the end of an array
            int[] numbers = { 7, 8, 9 };
            ints.AddRange(numbers);

            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //5 10 12 15 22 21 20 25 7 8 9

            //insert it at specific index
            ints.InsertRange(1, numbers);


            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //789 is duplicate, let's remove
            ints.Remove(7);
            ints.Remove(8);
            ints.Remove(9);

            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ints.Add(5);
            ints.RemoveAt(0); //removes at index

            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //10 12 15 22 21 20 25 7 8 9 5
            ints.Insert(8, 7);

            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ints.Remove(7);

            //print with foreach
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //more ways of adding numbers/elements to a list
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);

            for (int x = 2; x < 5; x++)
            {
                N.Insert(x-1, x);
            }

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            List<int> Q = new List<int>();
            Q.Add(1);
            Q.Add(5);

            for (int i = 4; i > 1; i--)
            {
                Q.Insert(1, i);
            }

            foreach (int i in Q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //list of strings
            List<string> str = new List<string> { "one", "two", "three" };

            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            str.Add("four");
            str.Add("five");
            str.Insert(0, "-one"); //adds it at index 0, rest moves back
            // -one one two three four five
            str.Remove("two");
            // -one one three four five
            str.RemoveAt(4);
            // -one one three four

            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();


            //find index of a word
            int index = str.IndexOf("three");
            Console.WriteLine(index);

            str.Add("one");
            //-one one three four one
            int last = str.LastIndexOf("one");
            Console.WriteLine(last);

            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //add words to list, check if it's there and make adjustments
            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //list to array
            string[] strings = str.ToArray();

            //array to list
            double[] doubles = { 1.2, 2.3, 4.9, 3.8 };
            List<double> doublesList = doubles.ToList();


            //other list examples
            List<bool> B = new List<bool> { true, false, false, true, true, true, false };
            List<char> C = new List<char> { 'c', 'a', 'h', 'd', 't' };

            string[] input = Console.ReadLine().Split();
            List<int> output = Array.ConvertAll(input, Convert.ToInt32).ToList();
            foreach (int i in output)
            {
                Console.Write((i+i) + " ");
            }
            Console.WriteLine();


        }
    }
}

