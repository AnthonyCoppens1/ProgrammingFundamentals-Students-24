using System;

namespace Week08Recap_04BigOrSmallPond_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= depth; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("0 ");
                }
                for (int k = depth; k > i; k--)
                {
                    Console.Write("~ ");
                }
                for (int l = depth; l > i; l--)
                {
                    Console.Write("~ ");
                }
                for (int m = 0; m < i; m++)
                {
                    Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
