using System;
using System.IO;

namespace Week08Recap_05MixAndMatch_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //option 1 without StreamReader
            string file1 = File.ReadAllText(Console.ReadLine());
            string file2 = File.ReadAllText(Console.ReadLine());

            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.Write(file1[i]);
                Console.Write(file2[i]);
            }

            Console.WriteLine();

            //option 2 WITH StreamReader
            StreamReader sr1 = File.OpenText(Console.ReadLine());
            StreamReader sr2 = File.OpenText(Console.ReadLine());

            amount = Convert.ToInt32(Console.ReadLine());
            /*int counter = 1;

            while (counter <= amount)
            {
                Console.Write((char)sr1.Read());
                Console.Write((char)sr2.Read());
                counter++;
            }*/

            for (int i = 0; i < amount; i++)
            {
                Console.Write((char)sr1.Read()); //reads the current char and goes to next
                Console.Write((char)sr2.Read());
            }

            sr1.Close();
            sr2.Close();

        }
    }
}
