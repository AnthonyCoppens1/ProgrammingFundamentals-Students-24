using System;
using System.IO;

namespace Week08Recap_05Reverse_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();

            string[] text = File.ReadAllLines(filename);

            StreamWriter W = File.CreateText($"reverse_{filename}");

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(text[i]);
                W.WriteLine(text[i]);
            }

            W.Close();
        }
    }
}
