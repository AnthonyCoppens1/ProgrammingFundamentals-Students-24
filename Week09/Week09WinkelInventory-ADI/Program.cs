using System;
using System.Collections.Generic;

namespace Week09WinkelInventory_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string key = Console.ReadLine().ToLower();

            while (key != "x")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (!inventory.ContainsKey(key))
                {
                    inventory.Add(key, value);
                }
                else
                {
                    inventory[key] = value; //hoeveelheid overschrijven
                }
                key = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory.ElementAt(i));
            }

        }
    }
}
