using System;
using System.Collections.Generic;

namespace Week09Dictionaries_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dictionary of strings linked to numbers
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "hello");
            strings.Add(3, "my");
            strings.Add(2, "name");
            strings.Add(66, "is");
            strings.Add(17, "Fabrizio");

            //print keys
            foreach (int key in strings.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            //print values
            foreach (string value in strings.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            //printing pairs
            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            //printing pairs and seeing what's actually inside
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i));
            }



            strings[88] = "Gomez";
            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            //removing elements
            strings.Remove(88);
            strings.Remove(17, out string name);
            Console.WriteLine(name);

            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //checking for value linked to key if it exists
            if (strings.ContainsKey(3))
            {
                Console.WriteLine(strings[3]);
            }
            Console.WriteLine();

            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();



            //dictionary with string keys linked to doubles
            Dictionary<string, double> doubleD = new Dictionary<string, double> { { "a", 7.2},
                {"b", 3.9 }, {"c", 4.5}};

            doubleD.Add("hello", 99.9);
            doubleD.Add("newNumber", 567.8);

            foreach (var pair in doubleD)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            //doubleD.Add("a", 3.2); --> cannot create same key twice!!!
            doubleD["a"] = 2.7;
            doubleD["doesntexistyet"] = 6.47;

            foreach (var pair in doubleD)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            doubleD.Remove("b");
            doubleD.Remove("newNumber", out double removedDouble);

            Console.WriteLine(removedDouble);
            foreach (var pair in doubleD)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            Dictionary<int, int> III = new Dictionary<int, int>();
            III.Add(2, 3);
            III.Add(9, 4);
            III.Add(1, 23);

            foreach (var pair in III)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();



            //analyse and split a string into a dictionary and count the characters
            string S = Console.ReadLine();
            Dictionary<char, int> characterCounter = new Dictionary<char, int>();

            foreach (char c in S)
            {
                if (characterCounter.ContainsKey(c))
                {
                    characterCounter[c]++;
                }
                else
                {
                    characterCounter[c] = 1;
                }
            }

            foreach (var pair in characterCounter)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }


            int[] array = { 7, 12, -3, 5, 2 };
            Array.Sort(array);
            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }


            string[] animals = { "beer", "baviaan", "aap", "arend"};
            Array.Sort(animals);
            Array.Reverse(animals);
            foreach (string i in animals)
            {
                Console.Write(i + " ");
            }
        }
    }
}
