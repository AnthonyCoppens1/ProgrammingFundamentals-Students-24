using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _09Dictionaries_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings linken aan getallen
            Dictionary<int, string> strings = new Dictionary<int, string>();
            strings.Add(8, "hallo");
            strings.Add(3, "mijn");
            strings.Add(2, "naam");
            strings.Add(66, "is");
            strings.Add(17, "Fabrizio");

            //print keys
            foreach (int key in strings.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();


            //print values /waarden
            foreach (string values in strings.Values)
            {
                Console.WriteLine(values);
            }
            Console.WriteLine();


            //print pair en volgende op nieuwe lijn
            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value);
                Console.WriteLine();
            }

            //print pair adhv index
            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings.ElementAt(i));
            }
            Console.WriteLine();


            //nog een manier om elementen toe te voegen
            strings[8] = "Hellow";
            strings[88] = "Alfonso";

            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //elementen verwijderen
            strings.Remove(88);
            strings.Remove(17, out string name);
            Console.WriteLine(name);

            foreach (var pair in strings)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //values printen gelinkt aan key als die bestaat
            if (strings.ContainsKey(3))
            {
                Console.WriteLine(strings[3]);
            }


            //dictionaries van andere datatypes
            Dictionary<string, double> doubles = new Dictionary<string, double> { { "a", 7.2},
                {"b", 3.9 }, {"c", 4.5}};

            doubles.Add("hello", 99.9);
            doubles.Add("NieuwGetal", 567.8);

            foreach (var pair in doubles)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //doubles.Add("a", 3.2); --> nooit 2x dezelfde key gebruiken om iets toe te voegen
            doubles["a"] = 2.7;
            doubles["bestaatnogniet"] = 6.47;

            foreach (var pair in doubles)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            //verwijderen van keys en opslaan van een verwijderde value
            doubles.Remove("b");
            doubles.Remove("NieuwGetal", out double verwijderdeDouble);

            foreach (var pair in doubles)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();

            Console.WriteLine(verwijderdeDouble);


            //kan ook key value pair zijn van zelfde datatype
            Dictionary<double, double> D = new Dictionary<double, double>();
            D.Add(2.7, 3.8);
            D.Add(9.1, 4.7);
            D.Add(8.2, 19.3);

            foreach (var pair in D)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();


            string zin = Console.ReadLine();
            Dictionary<char, int> telling = new Dictionary<char, int>();

            for (int i = 0; i < zin.Length; i++)
            {
                if (!telling.Keys.Contains(zin[i]))
                {
                    telling.Add(zin[i], 1);
                }
                else
                {
                    telling[zin[i]]++;
                }
            }

            foreach (var pair in telling)
            {
                Console.Write(pair.Key + " " + pair.Value + "\n");
            }
            Console.WriteLine();



        }
    }
}
