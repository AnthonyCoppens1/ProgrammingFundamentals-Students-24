using System;

namespace Week12_OO_Voorbeeld_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oefeningen Week9 = new Oefeningen();

            string vraag = Console.ReadLine();
            switch (vraag)
            {
                case "A1":
                    string woord1 = Console.ReadLine();
                    string woord2 = Console.ReadLine();
                    Week9.SumOfChars(woord1, woord2);
                    break;

                case "B1":
                    int getalFib = Convert.ToInt32(Console.ReadLine());
                    Week9.IsFibonacci(getalFib);
                    break;

                case "C1":
                    string zin = Console.ReadLine();
                    Console.WriteLine(Week9.ReverseCase(zin));
            }
            
        }
    }
}
