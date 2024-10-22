using System;
using System.IO;

namespace Week05HarryPotter03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //give all names of people in house Gryffindor
            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Gryffindor"))
                {
                    int firstIndex = item.IndexOf(';'); //saves index of first time we come across ;
                    string substring = item.Substring(firstIndex + 1);
                    int secondIndex = substring.IndexOf(';');
                    Console.WriteLine(substring.Substring(0, secondIndex));
                }
            }

            Console.WriteLine("------------");

            foreach (var item in File.ReadLines("Characters.csv"))
            {
                if (item.Contains("Slytherin"))
                {
                    int semicolonCounter = 0;
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] == ';')
                        {
                            semicolonCounter++;
                        }
                        if (semicolonCounter == 2)
                        {
                            break;
                        }
                        if (item[i] != ';' && semicolonCounter == 1)
                        {
                            Console.Write(item[i]);
                        }
                    }
                    semicolonCounter = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}
