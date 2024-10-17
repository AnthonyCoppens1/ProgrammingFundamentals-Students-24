using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05HarryPotterCharacter03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int first = item.IndexOf(';'); //first index of ;
                    string substring = item.Substring(first + 1);
                    int second = substring.IndexOf(';'); //first index of ; in substring
                    Console.WriteLine(substring.Substring(0, second));
                }
            }
        }
    }
}
