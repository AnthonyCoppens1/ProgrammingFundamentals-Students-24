using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week08Recap_05MeMyselfandI_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Regex rx = new Regex(name.ToLower());

            string text = File.ReadAllText(name.Replace(" ", "") + ".txt");

            MatchCollection matches = rx.Matches(text);
            Console.WriteLine($"{matches.Count} occurrences of {name}");
        }
    }
}
