using System;

namespace _01HelloWorld_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writing a program to tell hello in combination with a name
            

            Console.WriteLine("What's your name? ");

            string name = Console.ReadLine();

            //option 1
            Console.WriteLine("Hello " + name);


            //option 2
            name = Console.ReadLine();
            Console.Write($"Hello {name}");

            //option 3
            name = Console.ReadLine();
            Console.Write("Hello {0}", name);

            string x = "Bobby";
            string y = "Thomas";
            string z = "Anthony";

            Console.Write("Hello {0} {1} {2} {3}", x, y, z, "Philip");


            /*this is the way to type comments
             * in multiple lines
             * and every time I press enter
             * it keeps going. */
        }
    }
}
