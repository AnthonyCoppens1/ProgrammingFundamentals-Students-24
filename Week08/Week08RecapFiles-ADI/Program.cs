using System;
using System.IO;

namespace Week08RecapFiles_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //optie 1
            StreamReader sr = File.OpenText("Khalid.txt");
            string text = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine(text);
            Console.WriteLine("\n\n\n\n");

            //optie 2
            string textVanFile = File.ReadAllText("Maroon5.txt");
            Console.WriteLine(textVanFile);

            Console.WriteLine("\n\n\n\n");

            //optie 3
            StreamReader S = File.OpenText("Eminem.txt");
            while (!S.EndOfStream)
            {
                Console.WriteLine("++" + S.ReadLine());
            }
            S.Close();
            /*
            hallo mijn naam is ...
            mijn dag is vandaag goed gestart
            naam
            is
            bart*/

            //optie 4
            string[] T = File.ReadAllLines("KatyPerry.txt");
            foreach (var line in T)
            {
                Console.WriteLine("--" + line);
            }


            //optie 5
            string textInChar = File.ReadAllText("JustinBieber.txt");
            Console.WriteLine(textInChar);

            foreach (char c in textInChar)
            {
                if (c == 'i')
                {
                    Console.Write("999");
                }
                else
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine("\n\n\n\n");

            //optie 6
            string TT = File.ReadAllText("LadyGaga.txt");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(TT[^i]);
            }


            //schrijven naar files
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("dit is een test");
            stream.Close();
          




        }
    }
}
