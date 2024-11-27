using System;
using System.Collections.Generic;

namespace Week09StoreInventory_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower(); // thriller 213
            Dictionary<string, int> Store = new Dictionary<string, int>();
            
            while (input != "end")
            {
                string[] x = input.Split();
                if (Store.ContainsKey(x[0]))
                {
                    Store[x[0]] = Convert.ToInt32(x[1]);
                    input = Console.ReadLine().ToLower(); ;
                }
                else
                {
                    Store[x[0]] = Convert.ToInt32(x[1]);
                    input = Console.ReadLine().ToLower();
                }

            }

            for (int i = 0; i < Store.Count; i++)
            {
                Console.WriteLine(Store.ElementAt(i));
            }
        }
    }
}
