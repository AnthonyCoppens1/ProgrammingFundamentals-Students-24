using System;

namespace Week11OO_Persoon_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon Anthony = new Persoon("Anthony", "Coppens", new DateOnly(1995, 07, 31));
            Persoon Elke = new Persoon("Elke", "Boonen", new DateOnly(1980, 4, 23));

            List<Persoon> mensen = new List<Persoon> { Anthony, Elke };
            Anthony.Huisdieren.Add(new Kat("Yuki"));
            Anthony.Huisdieren.Add(new Kat("Mops"));

            Elke.Huisdieren.Add(new Konijn("Jules"));

            foreach (var persoon in mensen)
            {
                Console.WriteLine($"{persoon}");
                foreach (var huisdier in persoon.Huisdieren)
                {
                    Console.WriteLine($"     {huisdier}");
                }
            }

            Console.WriteLine(mensen.Count);

            
        }
    }
}
