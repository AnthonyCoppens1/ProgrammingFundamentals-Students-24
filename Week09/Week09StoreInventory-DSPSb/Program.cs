using System;
using System.Collections.Generic;

namespace Week09StoreInventory_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string command = Console.ReadLine().ToLower();
            while (command != "checkinventory")
            {
                if (command == "addproduct")
                {
                    string[] S = Console.ReadLine().ToLower().Split(); // eggs 15
                    inventory.Add(S[0], Convert.ToInt32(S[1]));
                    command = Console.ReadLine().ToLower();
                }
                else if (command == "sale")
                {
                    string input = Console.ReadLine();
                    while (input != "x")
                    {
                        string[] S = input.ToLower().Split();
                        inventory[S[0]] -= Convert.ToInt32(S[1]);
                        input = Console.ReadLine();
                    }
                    command = Console.ReadLine().ToLower();
                }
                else if (command == "restock")
                {
                    string input = Console.ReadLine();
                    while (input != "x")
                    {
                        string[] S = input.ToLower().Split();
                        inventory[S[0]] += Convert.ToInt32(S[1]);
                        input = Console.ReadLine();
                    }
                    command = Console.ReadLine().ToLower();
                }
                else
                {
                    Console.WriteLine("Please provide a valid keyword!");
                    command = Console.ReadLine().ToLower();
                }
            }

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory.ElementAt(i));
            }
        }
    }
}
