using System;
using System.IO;

namespace Week08Recap_Testing_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int rows = Convert.ToInt32(Console.ReadLine());

            //string[][] array = new string[rows][];
            /* 9 12 -3
             * 5 2 18
             * 6 -7 19 
             */
            /*int counter = 0;
            while (counter < rows)
            {
                array[counter] = Console.ReadLine().Split(" ");
                counter ++;
            }

            foreach (var item in array)
            {
                foreach (var element in item)
                {
                    Console.Write(element + "-");
                }
                Console.WriteLine();
            }*/

            //option 1 files
            StreamReader sr = File.OpenText("paint.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();


            //option 2 files
            string[] text = File.ReadAllLines("BTS.txt");

            string T = File.ReadAllText("paint.txt");

            StreamWriter W = File.CreateText("BTS-1.txt");
            foreach (char c in T)
            {
                Console.WriteLine(c);
            }

            foreach (string s in text)
            {

                Console.WriteLine("--" + s);
                W.WriteLine("--" + s);
            }

            W.Close();


            foreach (var item in File.ReadAllLines("BTS.txt"))
            {
                for(int i = 0; i < item.Length; i++)
                {
                    if (item[i] == 'j')
                    {
                        Console.Write(999);
                    }
                    else
                    {
                        Console.Write(item[i]);
                    }
                }
            }





        }
    }
}
