using System;

namespace Week06Array1D_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays aanmaken
            int[] intArray = new int[10]; //alle waarden zijn 0
            string[] stringArray = new string[4]; //alle waarden zijn ""

            byte[] b = { 2, 15, 205, 18 };
            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);
            int[] ints = { 1, 3, 8, 23, 99 };


            //waarden opvragen
            Console.WriteLine("Eerste waarde van intArray: " + intArray[0]); //intArray.ElementAt(0);
            Console.WriteLine("Laatste waarden van doubles: " + doubles[5]);
            Console.WriteLine("Laatste waarden van doubles: " + doubles[^1]);
            Console.WriteLine("Laatste waarden van doubles: " + doubles[doubles.Length-1]);

            //^1 telt vanaf de laatste index, ^2 is de voorlaatste waarde

            //waarden toekennen
            stringArray[0] = "Dean";
            stringArray[1] = "Tom";
            stringArray[2] = "Bob";
            stringArray[3] = "Karen";
            //stringArray[4] = "Rachel"; --> pas op, respecteer limiet van gedeclareerde array

            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            

            //door arrays loopen
            //foreach
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            //for-loop
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }


            //while
            int index = 0;
            while (index < doubles.Length)
            {
                Console.Write(doubles[index] + " ");
                index++; //indien niet aanwezig, infinite loop
            }

            Console.WriteLine();

            doubles = new double[] { 1, 3, 4, -1, -4, 55, 88, 8 };
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //array vullen aan de hand van een loop
            for (int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;
                Console.Write($"Geef een getal voor index {i}: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            foreach(var item in intArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            //array vullen adhv .Split()
            Console.WriteLine("Geef een aantal dieren in, gesplitst met een spatie: ");
            string antwoord = Console.ReadLine(); //kat hond dino konijn zebra dolfijn hamster

            string[] dieren = antwoord.Split(" ");
            foreach (var item in dieren)
            {
                Console.Write(item + "+");
            }

            Console.WriteLine();
            antwoord = Console.ReadLine();
            dieren = antwoord.Split(";");
            
            foreach (var item in dieren)
            {
                Console.Write(item + " ");
            }



            //vullen en omzetten van arrays met split methode
            Console.WriteLine($"Geef een aantal getallen, gesplitst met een spatie: ");
            antwoord = Console.ReadLine();

            string[] strArray = antwoord.Split(" ");
            int[] arrayOfInts = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++) //of i < arrayOfInts.Length
            {
                arrayOfInts[i] = Convert.ToInt32(strArray[i]);
            }

            //of in 1 lijn
            arrayOfInts = Array.ConvertAll(strArray, Convert.ToInt32);


        }
    }
}
