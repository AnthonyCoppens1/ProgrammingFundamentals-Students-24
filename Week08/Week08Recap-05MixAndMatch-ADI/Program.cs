using System;
using System.IO;

namespace Week08Recap_05MixAndMatch_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();

            int hoeveel = Convert.ToInt32(Console.ReadLine());
            string F1 = File.ReadAllText(file1);
            string F2 = File.ReadAllText(file2);

            for (int i = 0; i < hoeveel; i++)
            {
                Console.Write("" + F1[i] + F2[i]);
            }
        }
    }
}
