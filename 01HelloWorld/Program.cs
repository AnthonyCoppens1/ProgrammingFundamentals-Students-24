using System;

namespace _01HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writing a program to say hello a person
            Console.WriteLine("What's your name? ");

            string name = Console.ReadLine(); //input from user saved under the variable name

            //option 1
            Console.WriteLine("Hello " + name + "!");

            //option 2
            Console.WriteLine($"Hello {name}!");

            //option 3
            Console.WriteLine("Hello {0}!", name);


            string x = "jan";
            string y = "thomas";
            string z = "jean";

            Console.WriteLine("Hello {0} {1} {2}!", x, y, z);

            /* the only way to do multiple lines
             * is through this way
             * */
            

        }
    }
}
