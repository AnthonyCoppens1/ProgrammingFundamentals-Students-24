using System;

namespace Week12_OO_BSP_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BSS spel = new BSS();

            string antwoord;
            Dictionary<string, int> opties = new Dictionary<string, int> { { "Blad", 0 }, { "Steen", 1 }, { "Schaar", 2 } };
            Console.WriteLine($"Blad (0), Steen (1), Schaar (2), Stop om te stoppen!");
            while ((antwoord = Console.ReadLine()) != "Stop")
            {
                foreach (var pair in opties)
                {
                    if (antwoord == pair.Key)
                    {
                        spel.Mij = (Hand)pair.Value;
                    }
                }
                string resultaat = spel.Beurt();
                Console.WriteLine(resultaat);
            }

            Console.WriteLine($"Finale score: {spel}");
        }
    }
}
