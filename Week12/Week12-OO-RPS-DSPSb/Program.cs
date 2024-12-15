using System;

namespace Week12_OO_RPS_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPS game = new RPS();
            string choice;
            Console.WriteLine($"Rock(0), Paper(1), Scissor(2), X to stop!");
            while ((choice = Console.ReadLine()) != "X")
            {
                string result;
                switch (choice)
                {
                    case "Rock":
                        game.Me = (Hand)0;
                        result = game.Turn();
                        Console.WriteLine(result);
                        Console.WriteLine(game);
                        break;
                    case "Paper":
                        game.Me = (Hand)1;
                        result = game.Turn();
                        Console.WriteLine(result);
                        Console.WriteLine(game);
                        break;
                    case "Scissor":
                        game.Me = (Hand)2;
                        result = game.Turn();
                        Console.WriteLine(result);
                        Console.WriteLine(game);
                        break;
                    default:
                        Console.WriteLine("Wrong non-existant choice, try again!");
                        break;
                }
            }

            Console.WriteLine($"Final score: {game}");
        }
    }
}
