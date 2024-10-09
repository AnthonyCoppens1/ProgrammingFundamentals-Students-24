using System;

namespace _04MagicalNumber_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            double sum;

            while (number >= 10)
            {
                if (number > 99)
                {
                    sum = Math.Pow(number / 100, 2) + Math.Pow((number % 100) / 10, 2) + Math.Pow(number % 10, 2);
                    Console.WriteLine($"{number / 100}^2 + {(number % 100) / 10}^2 + {number % 10}^2 = {sum}");
                }
                else
                {
                    sum = Math.Pow(number / 10, 2) + Math.Pow(number % 10, 2);
                    Console.WriteLine($"{number / 10}^2 + {number % 10}^2 = {sum}");
                }
                number = (int)sum;
            }
        }
    }
}
