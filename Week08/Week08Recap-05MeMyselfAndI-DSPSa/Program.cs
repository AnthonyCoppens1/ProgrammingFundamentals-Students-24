using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week08Recap_05MeMyselfAndI_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); //Ed Sheeran --> EdSheeran.txt
            string text = File.ReadAllText(name.Replace(" ", "") + ".txt");

            //StreamReader sr = File.OpenText(name.Replace(" ", "") + ".txt");
            Regex rg = new Regex(name.ToLower());

            MatchCollection matches = rg.Matches(text);
            Console.WriteLine($"{matches.Count} occurences of {name}");


        }
    }
}
