using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week05Rapunzel01_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open the file and read all content
            //version 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //version 2
            string text = File.ReadAllText("Rapunzel.txt");


            //count characters
            Console.WriteLine($"# of characters: {text.Length}");


            //count lines
            Console.WriteLine($"# of lines: {File.ReadAllLines("Rapunzel.txt").Length}");

            //count lines in a different way
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();

            Console.WriteLine($"# of lines with while: {lines}");


            //count small a's
            //version while
            int countSmallA = 0;
            int countBigA = 0;
            sr = File.OpenText("Rapunzel.txt");
            
            while (!sr.EndOfStream)
            {
                char a = (char)sr.Read();
                if (a == 'a')
                {
                    countSmallA++;
                }
                else if (a == 'A')
                {
                    countBigA++;
                }
            }
            sr.Close();

            Console.WriteLine($"# of small a's: {countSmallA} and big a's: {countBigA}");



            //count A's and a's
            //version foreach
            int countA = 0;
            foreach (char c in text.ToLower()) //ref to string text = File.ReadAllText("Rapunzel.txt");
            {
                if ("aA".Contains(c))
                {
                    countA++;
                }
            }
            Console.WriteLine($"# of A's: {countA}");


            //count A's and a's
            //version for
            countA = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 97 || text[i] == 65) // a || A
                {
                    countA++;
                }
            }
            Console.WriteLine($"# of A's: {countA}");


            //count words
            //version foreach
            int countWords = 0;
            foreach (var item in text)
            {
                if (item == ' ')
                {
                    countWords++;
                }
            }
            Console.WriteLine($"# of words: {countWords}");
            //BEWARE, COUNT IS TOO HIGH, INCLUDES TOO MUCH



            //count rapunzels
            string word = "";
            int countRapunzels = 0;

            foreach (char c in text.ToLower())
            {
                if (c >= 97 && c <= 122)
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countRapunzels++;
                    }
                    word = "";
                }
            }

            Console.WriteLine($"# of rapunzels: {countRapunzels}");


            //rapunzels counted with regex
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine($"# of rapunzels: {matches.Count}");



            //using regex to count words
            regex = new Regex(@"\b\w+(?:’\w+)?\b", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"# of words: {matches.Count}");
            
        }
    }
}
