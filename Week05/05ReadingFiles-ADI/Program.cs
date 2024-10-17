using System;
using System.IO;

namespace _05ReadingFiles_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //openen en lezen van een file. 
            //eerst sluiten dan printen
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();

            Console.WriteLine(text);

            Console.WriteLine();
            //opnieuw tonen van bestand
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                //string line = input.ReadLine();
                //Console.WriteLine("-->" + line);

                Console.WriteLine("-->" + input.ReadLine());
            }
            input.Close();


            //char per char lezen door tekst en we voegen een spatie toe
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //foreach gebruiken om door tekst te gaan
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("+=+" + item);
            }

            //foreach om door characters te lopen
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(c + "%");
            }
        }
    }
}
