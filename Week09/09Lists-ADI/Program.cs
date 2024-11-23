using System;
using System.Collections.Generic;

namespace _09Lists_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D arrays -> vaste lengte
            int[] array = new int[5];
            array[0] = 5;
            array[1] = 10;
            array[2] = 15;
            array[3] = 20;
            array[4] = 25;

            //list met variabele lengte, afhankelijk van het aantal elementen op dat moment
            List<int> ints = new List<int>();
            ints.Add(5);
            ints.Add(10);
            ints.Add(15);
            ints.Add(20);
            ints.Add(25);

            //print de lijst
            for(int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();

            //getallen toevoegen op bepaalde plaats --> oude plaats schuift 1 op
            ints.Insert(2, 12); //5 10 12 15 20 25

            //bepaalde getallen blijven invoeren op zelfde index
            ints.Insert(4, 21);
            ints.Insert(4, 22); // 5 10 12 15 22 21 20 25

            //meerdere getallen in 1 keer toevoegen
            int[] getallen = { 7, 8, 9 };

            ints.AddRange(getallen); //1 argument

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
            //5 10 12 15 22 21 20 25 7 8 9



            //range op een gekozen plaats
            ints.InsertRange(1, getallen);
            //5 7 8 9 10 12 15 22 21 20 25 7 8 9


            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //Dingen verwijderen, want 789 staat er 2 keer in
            ints.Remove(7);
            ints.Remove(8);
            ints.Remove(9);

            //uitprinten
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ints.Add(5);
            ints.RemoveAt(0); //verwijderen op specifieke index

            //uitprinten
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //Nog meer manieren om getallen toe te voegen aan een list
            List<int> N = new List<int>();
            N.Add(1);
            N.Add(5);


            //getallen 4 3 2 toevoegen met een loop
            //telkens op dezelfde index
            for (int i = 4; i > 1; i--)
            {
                N.Insert(1, i);
            }

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //insert op correcte plaats, correcte volgorde, telkens nieuwe index
            for (int i = 2; i < 5; i++)
            {
                N.Insert(i - 1, i);
            }

            foreach (int i in N)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //list van strings
            List<string> str = new List<string> {"één", "twee", "drie"};

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str.Add("vier");
            str.Add("vijf");

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            //insert, remove, removeat
            str.Insert(0, "-één");
            str.Remove("twee");
            str.RemoveAt(4);

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            //zoek naar index van een woord
            int index = str.IndexOf("drie");
            Console.WriteLine(index);

            //als 2 keer exact zelfde woord in list staat, keert 1e index terug
            //in deze code   -één != één
            index = str.IndexOf("één");
            Console.WriteLine(index);


            //woord toevoegen aan list, check of het er in voorkomt en maak wijzigingen
            str.Add("more");
            if (str.Contains("more"))
            {
                index = str.IndexOf("more");
                str.Insert(index, "thomas");
            }

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();


            str.Add("één");
            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == "één")
                {
                    str.RemoveAt(i);
                }
            }

            Console.WriteLine("TEST");
            foreach (string s in str)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();





            //list naar array
            string[] strings = str.ToArray();

            //array naar list
            double[] doubles = { 1.2, 3.4, 5.8, 4.5 };
            List<double> doubleList = doubles.ToList();


            //andere voorbeelden van lists
            List<bool> B = new List<bool> { true, true, false, true, false };
            List<double> D = new List<double> { 3.2, 1.5, 7.8 };



            List<int> G = new List<int>();

            int[] iii = Array.ConvertAll(Console.ReadLine().Split(),Convert.ToInt32);
            /*foreach (int i in iii)
            {
                G.Add(i);
            }*/

            G.AddRange(iii);

            foreach (int i in G)
            {
                Console.WriteLine(i);
            }


        }
    }
}
