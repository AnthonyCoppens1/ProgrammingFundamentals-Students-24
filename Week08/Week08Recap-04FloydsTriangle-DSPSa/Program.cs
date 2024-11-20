using System;

namespace Week08Recap_04FloydsTriangle_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(p + " ");
                    p++;
                }
                Console.WriteLine();
            }
        }
    }
}
