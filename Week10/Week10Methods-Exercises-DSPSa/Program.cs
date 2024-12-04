using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace Week10Methods_Exercises_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1: you get a string from the user
             * return with a method all of the characters that appear more than 1 time
             * ignore upper case and lower case
             * 
             * INPUT:
             * "We are. listening very carefully."
             * 
             * OUTPUT:
             * . aeilnry
             * 
             * 
             * Ex2:
             * Squared and cubed
             * First read in a number, return the number squared and cubed 
             * 
             * INPUT:
             * 3
             * --> 3² / 3³
             * OUTPUT:
             * 9
             * 27
             * 
             * 
             * Ex 3:
             * read in a string array of numbers, split by a space
             * calculate the multiplication of all elements within the array
             * 
             * INPUT:
             * 4 5 6
             * 
             * OUTPUT:
             * 120
             * 
             */


            string exercise = Console.ReadLine();

            switch (exercise)
            {
                case "1":
                    int line = Convert.ToInt32(Console.ReadLine());
                    Method1(line);
                    break;
                case "2":

                    break;
                case "3":

                    break;

                default:
                    break;
            }

        }

        static void Method1(int line)
        {
            string[] text = File.ReadAllLines("mystery_story_wyndale_cleaned.txt");
            string storage = text[line - 1];
            Dictionary<char, int> D = new Dictionary<char, int>();

            for (int i = 0; i < text[line-1].Length; i++)
            {
                if (!D.ContainsKey(storage[i]))
                {
                    D.Add(storage[i], 1);
                }
                else
                {
                    D[storage[i]]++;
                }
            }
            string[] ss = LoopAndCheckD(D).ToArray();
            Array.Sort(ss);
            foreach (var item in ss)
            {
                Console.Write(item);
            }
             //or don't convert and do LoopAndCheckD(D).Sort();

            
        }

        static List<string> LoopAndCheckD(Dictionary<char,int> D)
        {
            List<string> L = new List<string>();
            foreach(var item in D)
            {
                if (item.Value > 1)
                {
                    L.Add(Convert.ToString(item.Key));
                }
            }

            return L;
        }

    }
}
