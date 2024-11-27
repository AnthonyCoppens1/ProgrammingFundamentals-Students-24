using System;
using System.Collections.Generic;

namespace Week09Dictionaries_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings linked to numbers
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "hello");
            strings.Add(3, "my");
            strings.Add(2, "name");
            strings.Add(66, "is");
            strings.Add(17, "Elfa");
            strings.Add(987231, "!");

            //print keys
            foreach (int key in strings.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            //print values
            foreach (string s in strings.Values)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();


            //print pairs
            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }

            //print pairs with ElementAt
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i));
            }
            Console.WriteLine();

            //more ways of adding elements to a dictionary
            strings[8] = "Toedeloe"; //reset value of existing key

            strings[88] = "Darkness"; //if key isn't in dictionary yet, add it and its value

            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i));
            }


            //removing elements
            strings.Remove(88);
            strings.Remove(987231, out string st); //removes the key+value from dictionary and saves value
            Console.WriteLine(st);

            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }

            if (strings.ContainsKey(3))
            {
                Console.WriteLine(strings[3]);
            }
            
            foreach (var pair in strings)
            {
                if (pair.Value == "is")
                {
                    Console.WriteLine(pair.Key);
                }
            }


            Dictionary<string, double> D = new Dictionary<string, double> { { "a", 3.2},
                {"b", 7.2 }, {"c", 9.9}};

            D.Add("hello", 17.5);
            D.Add("newNumber", 5678.9);

            foreach (var pair in D)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            //D.Add("a", 12.1); --> can never have same key in dictionary
            D.Add("A", 12.1);
            D["doesntexistyet"] = 6.47;
            D["a"] = 8;

            foreach (var pair in D)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            D.Remove("b");
            D.Remove("newNumber", out double removedDouble);
            Console.WriteLine(removedDouble);

            foreach (var pair in D)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //can also match same datatype for key and value
            Dictionary<char, char> C = new Dictionary<char, char>();
            C.Add('z', 'o');
            C.Add('b', 'x');
            C.Add('a', 'p');



        }
    }
}
