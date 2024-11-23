using System;
using System.Collections.Generic;

namespace _09StudentDatabase_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actie = Console.ReadLine().ToUpper();
            List<string> naam = new List<string>();
            List<int> leeftijd = new List<int>();
            List<DateTime> geboortedatum = new List<DateTime>();

            int index = 1;

            while (actie != "END")
            {
                switch (actie)
                {
                    case "ADD":
                        Console.Write("Naam: "); naam.Add(Console.ReadLine());
                        Console.Write("Leeftijd: "); leeftijd.Add(int.Parse(Console.ReadLine()));
                        Console.Write("B-day: "); geboortedatum.Add(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write($"De student heeft de nummer: {index}\n\n");
                        index++;
                        actie = Console.ReadLine();
                        break;

                    case "DUMPSTERFIRE":
                        Console.Write("Welke student wil je trashen? "); 
                        int N = Convert.ToInt32(Console.ReadLine());
                        if (N <= naam.Count && !(N < 0))
                        {
                            naam.RemoveAt(N - 1);
                            leeftijd.RemoveAt(N - 1);
                            geboortedatum.RemoveAt(N - 1);
                            Console.Write($"De info van student {N} is verwijderd\n\n");
                            actie = Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Het opgegeven getal is geen correcte studentennummer!");
                            actie = Console.ReadLine();
                        }
                        break;

                    case "EDIT":
                        Console.Write("Welke student wil je wijzigen? ");
                        int nummer = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Naam: "); naam[nummer - 1] = Console.ReadLine();
                        Console.Write("Leeftijd: "); leeftijd[nummer - 1] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Geboortedatum: "); 
                        geboortedatum[nummer - 1] = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine();
                        actie = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Ben je nu echt zo incapabel dat je geen enkel van de 3 woorden juist kan typen? ");
                        actie = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Sessie is afgerond! Dit zijn de studenten: \n");
            for (int i = 0; i < naam.Count; i++)
            {
                Console.Write(naam[i] + " " + leeftijd[i] + " " + DateOnly.FromDateTime(geboortedatum[i]));
                Console.WriteLine();
            }
        }
    }
}
