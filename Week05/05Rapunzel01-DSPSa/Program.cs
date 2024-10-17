using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _05Rapunzel01_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening a file and reading all content
            //version 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //version 2
            string text = File.ReadAllText("Rapunzel.txt");

            //count characters
            Console.WriteLine($"# characters: {text.Length}");

            //count lines
            Console.WriteLine($"# lines: {File.ReadAllLines("Rapunzel.txt").Length}");

            //another way of counting lines --> with a while
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lines = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lines++;
            }
            sr.Close();

            Console.WriteLine($"# of lines: {lines}");


            //counting A's and a's
            //version while
            int countA = 0;
            sr = File.OpenText("Rapunzel.txt");
            while (!sr.EndOfStream)
            {
                char character = (char)sr.Read();
                if (character == 'A' || character == 'a')
                {
                    countA++;
                }

                /*if ("Aa".Contains(character))
                {
                    countA++;
                }*/
            }
            sr.Close();
            Console.WriteLine($"# of A's and a's: {countA}");


            //counting A's and a's with a foreach
            //version foreach
            countA = 0;
            foreach (char item in text.ToLower())
            {
                if (item == 'a')
                {
                    countA++;
                }
            }
            Console.WriteLine($"# of A's and a's: {countA}");


            //counting A's and a's with a for-loop
            //version for-loop
            countA = 0;
            int counta = 0;
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == 65)
                {
                    countA++;
                }
                else if (text[i] == 97)
                {
                    counta++;
                }
            }
            Console.WriteLine($"# of A's: {countA} and a's: {counta}");



            //calculate amount of words in text
            //version foreach --> only this version

            int countWords = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    countWords++;
                }
            }
            Console.WriteLine($"# of words: {countWords}");
            //not correct, because first and last are ignored. What about special chars?


            //count word RAPUNZEL

            string word = "";
            int rapunzelCounter = 0;
            foreach (char c in text.ToLower()) //text refers to code line 17!
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        rapunzelCounter++;
                    }
                    word = "";
                }
            }
            Console.WriteLine($"amount of Rapunzels: {rapunzelCounter}");


            //WORKING WITH REGEX
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);

            //text is a ref to: string text = File.ReadAllText("Rapunzel.txt");
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"# of rapunzels: {matches.Count}");


            //using regex to find word
            regex = new Regex(@"\b\w+\b", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"# of words: {matches.Count}"); //beware of king's

            
            //replace all rapunzels
            regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            string s = regex.Replace(text, "Anthony");
            Console.WriteLine(s);
        }
    }
}
