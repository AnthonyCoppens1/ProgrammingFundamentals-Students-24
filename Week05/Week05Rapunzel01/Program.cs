using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week05Rapunzel01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //file openen en content lezen en er iets mee doen
            //versie 1
            /*StreamReader sr = File.OpenText("Rapunzel.txt");
            string textCheck = sr.ReadToEnd();
            sr.Close();*/

            //versie 2
            string text = File.ReadAllText("Rapunzel.txt"); //leest char per char


            //characters tellen
            Console.WriteLine($"# characters: {text.Length}");


            //lijnen tellen
            //versie 1
            StreamReader sr = File.OpenText("Rapunzel.txt");
            int lijnen = 0;

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                lijnen++;
            }

            sr.Close();
            Console.WriteLine($"# lijnen: {lijnen}");


            //lijnen tellen
            //versie 2
            Console.WriteLine($"# lijnen: {File.ReadAllLines("Rapunzel.txt").Length}");


            //tel de L'en en l'en
            //versie while
            int countL = 0;
            int countl = 0;

            sr = File.OpenText("Rapunzel.txt");

            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                
                if (c == 'L')
                {
                    countL++;
                }
                else if (c == 'l')
                {
                    countl++;
                }

                //if ("Ll".Contains(c))
                
            }
            sr.Close();
            Console.WriteLine($"Aantal L'en {countL} en l'en: {countl}");




            //tel de L'en en l'en
            //versie foreach
            countL = 0;
            foreach ( char item in text.ToLower())
            {
                if (item == 'l')
                {
                    countL++;
                }
            }
            Console.WriteLine($"# L'en: {countL}");



            //tel de L'en en l'en
            //versie for

            countL = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 76 || text[i] == 108)
                {
                    countL++;
                }
            }
            Console.WriteLine($"# L'en: {countL}");



            //woorden tellen
            //foreach

            int telWoorden = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    telWoorden++;
                }
            }
            Console.WriteLine($"# woorden: {telWoorden}");



            //aantal Rapunzels tellen in de tekst
            string woord = "";

            int rapunzelteller = 0;

            foreach (char c in text.ToLower()) //ref naar: string text = File.ReadAllText("Rapunzel.txt");
            {
                if ("azertyuiopmlkjhgfdsqwxcvbn".Contains(c))
                {
                    woord += c;
                }
                else
                {
                    if (woord == "rapunzel")
                    {
                        rapunzelteller++;
                    }
                    woord = "";
                }
            }
            Console.WriteLine($"Aantal rapunzels: {rapunzelteller}");



            //werken met REGEX
            Regex regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine($"# rapunzels: {matches.Count}");


            //woorden tellen met regex
            regex = new Regex(@"\b\w+(?:'\w+)?\b", RegexOptions.IgnoreCase);
            matches = regex.Matches(text);
            Console.WriteLine($"# woorden: {matches.Count}");
            //pas op voor woorden met ' --> king's


            //Rapunzel vervangen
            regex = new Regex("rapunzel", RegexOptions.IgnoreCase);
            string s = regex.Replace(text, "Anthony");
            Console.WriteLine(s);
        }
    }
}
