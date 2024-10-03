using System;

namespace _03Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //informatie over DateTime

            int weekdag = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekdag);

            string DagInWoorden = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(DagInWoorden);

            int minuten = (int)DateTime.Now.Minute;
            Console.WriteLine(minuten);

            DateTime gisteren = new DateTime(2024, 10,02);
            Console.WriteLine(gisteren);

            DateTime geboorte = new DateTime(1995, 07, 31);
            Console.WriteLine(geboorte.Year); //toont enkel het jaar


            if (weekdag == 1)
            {
                Console.WriteLine("Maandag");
            }
            else if (weekdag == 2)
            {
                Console.WriteLine("Dinsdag");
            }
            else if (weekdag == 3)
            {
                Console.WriteLine("Woensdag");
            }
            else if (weekdag == 4)
            {
                Console.WriteLine("Donderdag");
            }
            else
            {
                Console.WriteLine("WOHOOO vrijdag of weekend");
            }


            //Switch
            switch (weekdag)
            {
                case 1: Console.WriteLine("maandag");
                    break;
                case 2: Console.WriteLine("dinsdag");
                    break;
                case 3: Console.WriteLine("woensdag");
                    break;
                case 4: Console.WriteLine("donderdag");
                    break;
                default: Console.WriteLine("WOHOOO vrijdag of weekend");
                    break;
            }

            switch (geboorte.Day)
            {
                case 31: Console.WriteLine("Wat een geweldige dag, midden in de zomer");
                    break;
                case 13: Console.WriteLine("Moest je geboren zijn op een vrijdag, zeker pech, vooral jij!");
                    break;
                case 1: Console.WriteLine("Ben je geboren in april, dan ben je een wandelende mop!");
                    break;
                case 7: Console.WriteLine("Lucky number 7");
                    break;
                case 5: Console.WriteLine("Je bent beter dan 4");
                    break;
                default: Console.WriteLine("Schijt aan alle andere dagen, sorry not sorry");
                    break;
            }



            //TryParse --> fouten ontwijken
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            if (x > y)
            {
                Console.WriteLine("x is groter dan y");
            }


            //ontwijken met een if-statement

            Console.Write("x = ");
            string antwoord = Console.ReadLine();
            bool succes = Int32.TryParse(antwoord, out x);

            if (succes)
            {
                if (x > y)
                {
                    Console.WriteLine("x is GROOT");
                }
                else
                {
                    Console.WriteLine("x is KLEIN");
                }
            }
            else
            {
                Console.WriteLine("CRAZY INPUT");
            }


            Console.Write("z = ");
            bool check = Int32.TryParse(Console.ReadLine(), out int z);
            if (check)
            {
                Console.WriteLine("Gelukt om om te zetten");
            }
            else
            {
                Console.WriteLine("EPIC FAIL");
            }


        }
    }
}
