using System;

namespace Week10_Oefeningen_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* opdracht 1: maaltafel
             * print een maaltafel uit van een gegeven getal, gebruik hiervoor een methode
             * input: geheel getal
             * output: 
             * 0 * 2 = 0
             * 1 * 2 = 2
             * ...
             * 10 * 2 = 20
             * 
             * opdracht 2: kwadraat en vierkantswortel
             * Bereken het kwadraat en de vierkantswortel van een gegeven getal
             * gebruik round()
             * input: geheel getal
             * output:
             * "Het kwadraat van ... is ..."
             * "De vierkantswortel van ... is ..."
             * 
             * 
             * opdracht 3: sum van elementen in array
             * tel de som van gegeven array op (kan eender welk datatype zijn)
             * enkel ints of doubles
             * 
             * input: string van getallen, gesplitst met een ' '
             * output:
             * som van de gegeven getallen in de array
             * 
             */

            string input = Console.ReadLine();
            switch (input)
            {
                case "opdracht 1":
                    int getal = Convert.ToInt32(Console.ReadLine());
                    PrintMaaltafel(getal);
                    break;
                case "opdracht 2":
                    int getalletje = Convert.ToInt32(Console.ReadLine());
                    int kwadraat;
                    double vierkantswortel;
                    KwadraatVierkantsWortel(getalletje, out kwadraat, out vierkantswortel);
                    Console.WriteLine(kwadraat);
                    Console.WriteLine(vierkantswortel);
                    break;

                case "opdracht 3":
                    string getallen = Console.ReadLine();
                    Sum(SplitArray(getallen));
                    break;
            }
        }
        static int[] SplitArray(string input)
        {
            int[] ints = Array.ConvertAll(input.Split(), Convert.ToInt32);
            return ints;
        }

        static void Sum(int[] array)
        {
            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];    
            }
            Console.WriteLine(som);
        }

        static void KwadraatVierkantsWortel(int getal, out int kwadraat, out double vierkantswortel)
        {
            kwadraat = getal * getal;
            vierkantswortel = Math.Sqrt(getal);
        }


        static void PrintMaaltafel(int getal)
        {
            for (int i = 0; i <= 10; i++)
            {
                int uitkomst = i * getal;
                Console.WriteLine($"{getal} * {i} = {uitkomst}");
            }
        }
    }
}
