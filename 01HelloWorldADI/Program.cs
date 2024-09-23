using System;

namespace _01HelloWorldADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam? ");

            string naam = Console.ReadLine();

            //optie 1
            Console.WriteLine("Hello " + naam);

            //optie 2
            naam = Console.ReadLine();

            Console.WriteLine($"Hello {naam}!");


            //optie 3
            naam = Console.ReadLine();

            Console.WriteLine("Hello {0}!", naam);

            string x = "Jan";
            string y = "Jean";
            string z = "Marie";

            Console.WriteLine("Hello {0} {1} {2}!", x, y, z);

            /*dan kan je in principe
             * op enter duwen
             * en regels blijven typen
             * van commentaar*/

        }
    }
}
