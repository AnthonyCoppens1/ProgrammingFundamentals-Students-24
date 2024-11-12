using System;

namespace Week07Exception_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of lines: ");
            int nr = Convert.ToInt32(Console.ReadLine());

            StreamReader file = File.OpenText("english.txt");
            for (int i = 0; i > nr; i++)
            {
                Console.WriteLine(file.ReadLine());
            }
            file.Close();


            //AVOIDING RUN-TIME ERRORS
            Console.WriteLine("Enter a number of lines: ");
            string answer = Console.ReadLine();
            
            if (Int32.TryParse(answer, out nr))
            {
                file = File.OpenText("english.txt");
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Wrong format for the lines!");
            }

            Console.WriteLine();

            //WITH EXCEPTION HANDLING
            Console.WriteLine("Enter a number of lines: ");
            answer = Console.ReadLine();
            if (Int32.TryParse(answer, out nr))
            {
                try
                {
                    file = File.OpenText("englih.txt");
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(file.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Oops, possible problem");
                }
            }
            else
            {
                Console.WriteLine("Wrong format for the lines!");
            }

        }
    }
}
