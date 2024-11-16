using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week08Recap_05MeMyselfandI_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine();
            Regex rx = new Regex(filename.ToLower());

            string text = File.ReadAllText(filename.Replace(" ", "") + ".txt");
            MatchCollection matches = rx.Matches(text);

            Console.WriteLine($"{matches.Count} occurrences of {filename}");
        }
    }
}
