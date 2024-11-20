using System;

namespace Week08Recap_04MixItUp_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    Console.Write(first[i]);
                    Console.Write(second[i]);
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    Console.Write(first[i]);
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    Console.Write(second[i]);
                    Console.Write(first[i]);
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    Console.Write(second[i]);
                }
            }
        }
    }
}
