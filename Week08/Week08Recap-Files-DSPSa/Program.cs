using System;
using System.IO;

namespace Week08Recap_Files_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //option 1
            StreamReader sr = File.OpenText("Jake.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();

            //option 2
            string text = File.ReadAllText("Jake.txt");
            foreach (char c in text)
            {
                Console.Write(c + "T");
            }

            //option 3
            string[] T = File.ReadAllLines("Jake.txt");
            foreach (string s in T)
            {
                Console.WriteLine("++" + s);
            }
            Console.WriteLine();

            //WRITING
            StreamWriter SW = File.CreateText("Jake2.txt");
            string S = File.ReadAllText("Jake.txt");
            for (int i = S.Length-1; i >= 0; i--)
            {
                Console.Write(S[i]);
                SW.Write(S[i]);
            }

            SW.Close();


        }
    }
}
