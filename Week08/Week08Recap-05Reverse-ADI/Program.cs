using System;
using System.IO;

namespace Week08Recap_05Reverse_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            string reversed = "";
            foreach (var line in File.ReadAllLines(filename))
            {
                reversed = line + "\n" + reversed;
            }

            Console.WriteLine(reversed);

            //optie 1
            StreamWriter W = File.CreateText($"reverse_{filename}");
            W.WriteLine(reversed);
            W.Close();

            //optie 2
            using(StreamWriter sw = File.CreateText($"reverse_{filename}"))
            {
                sw.WriteLine(reversed);
            }
        }
    }
}
