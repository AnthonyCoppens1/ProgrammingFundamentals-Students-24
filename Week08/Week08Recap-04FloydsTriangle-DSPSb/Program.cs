using System;
namespace Week08Recap_04FloydsTriangle_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }

        }
    }
}
