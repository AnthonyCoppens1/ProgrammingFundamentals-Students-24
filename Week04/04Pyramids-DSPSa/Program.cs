namespace _04Pyramids_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *
            // * *
            // * * *
            // * * * *

            int x = 4;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            // * * * *
            // * * *
            // * *
            // *

            for (int i = 0; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            
            for (int i = x; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            // + + + *
            // + + * *
            // + * * *
            // * * * *
            Console.WriteLine("Pyramid 3");
            for (int i = 1; i <= x; i++)
            {
                for (int j = x; j > i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            // * * * *
            // + * * *
            // + + * *
            // + + + *

            Console.WriteLine("Pyramid 4");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = x; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
