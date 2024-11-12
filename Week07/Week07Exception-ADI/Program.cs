using System;

namespace Week07Exception_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Geef een aantal lijnen in: ");
            int nr = Convert.ToInt32(Console.ReadLine());

            StreamReader file = File.OpenText("english.txt");
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(file.ReadLine());
            }*/

            Console.WriteLine("Geef een aantal lijnen: ");
            string antwoord = Console.ReadLine();

            if (Int32.TryParse(antwoord, out int nr))
            {
                StreamReader file = File.OpenText("english.txt");
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Verkeerd getal");
            }


            //EXCEPTION HANDELING
            Console.WriteLine();
            Console.WriteLine("Geef een aantal lijnen: ");
            antwoord = Console.ReadLine();
            if (Int32.TryParse(antwoord, out nr))
            {
                try
                {
                    StreamReader f = File.OpenText("englih.txt");
                    for (int i = 0; i < nr; i++)
                    {
                        Console.WriteLine(f.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oeps: " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Verkeerd getal");
            }



        }
    }
}
