using System;

namespace _02ValidAge_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int legaleBerekening = leeftijd / 2 + 7;
            Console.WriteLine($"Je leeftijd is {leeftijd} en je mag " +
                $"zeker en vast iemand daten vanaf {legaleBerekening}");
        }
    }
}
