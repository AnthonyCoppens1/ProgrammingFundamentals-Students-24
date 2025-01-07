using System;

namespace Week13_EindeSemester_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Oefeningen recap = new Oefeningen();
                switch (Console.ReadLine())
                {
                    case "Missing":
                        string cijfers = Console.ReadLine();
                        recap.Missing(cijfers);
                        break;

                    case "Calculator":
                        double getal1 = Convert.ToDouble(Console.ReadLine());
                        string symbool = Console.ReadLine();
                        double getal2 = Convert.ToDouble(Console.ReadLine());
                        recap.Calculator(getal1, symbool, getal2);
                        break;

                    case "Multiplication":
                        string dimensies = Console.ReadLine();
                        dimensies = dimensies.Replace(" ", "x");
                        Console.WriteLine(dimensies);
                        string[] str = dimensies.Split("x"); //4x2 2x4
                        if (str[1] != str[2])
                        {
                            Console.WriteLine("wrong dimensions");
                        }
                        recap.Multiplication(str);
                        break;

                    case "Abundant":
                        string input = Console.ReadLine();
                        recap.Abundant(input);
                        break;

                    default:
                        Console.WriteLine("crazy input");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }


    }
}
