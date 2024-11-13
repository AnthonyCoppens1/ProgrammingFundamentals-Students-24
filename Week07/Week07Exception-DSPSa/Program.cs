using System;
using System.IO;

namespace Week07Exception_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of lines: ");
            int nr;

            string answer = Console.ReadLine();
            if (Int32.TryParse(answer, out nr))
            {
                try //tests code for problems and runs the code
                {
                    StreamReader file = File.OpenText("engli.txt");

                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                catch //finding problems
                {
                    Console.WriteLine("Oops there's a problem!");
                }
                finally //runs without checking for problems in code in here
                {
                    Console.WriteLine("Code has been terminated!");
                }

            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
                
                

        }
    }
}
