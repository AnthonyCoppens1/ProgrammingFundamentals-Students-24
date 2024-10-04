using System;

namespace _03Switch_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //info about dates and using time
            int weekday = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

            string dayInWords = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dayInWords);

            Console.WriteLine(DateTime.Now);

            //creating your own datetime
            DateTime yesterday = new DateTime(2024, 10, 03);
            Console.WriteLine(yesterday);
            Console.WriteLine(yesterday.Month);
            Console.WriteLine(yesterday.Year+3);

            if (weekday == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("Thursday");
            }
            else
            {
                Console.WriteLine("WOHOO FRIDAY OR WEEKEND");
            }

            
            //switch statement
            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                default: Console.WriteLine("WOHOOO IT IS FRIDAY OR WEEKEND");
                    break;
            }

            DateTime birth = new DateTime(1995, 07, 31);
            switch (birth.Day)
            {
                case 31: Console.WriteLine("Middle of summer, amazing day!");
                    break;
                case 13: Console.WriteLine("If you were born on a Friday, you already give up. it's BAD");
                    break;
                case 29: Console.WriteLine("Just not February!");
                    break;
                case 1: Console.WriteLine("If you were born in April, you're a walking joke.");
                    break;
                case 25: Console.WriteLine("Merry Christmas");
                    break;
                default: Console.WriteLine("YOUR DAY SUCKS!");
                    break;
            }


            //TryParsing, getting rid of early problems
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            //avoid it with an if
            Console.WriteLine("x = ");
            string answer = Console.ReadLine();

            bool succes = Int32.TryParse(answer, out x);
            if (succes)
            {
                if (x > y)
                {
                    Console.WriteLine("x is greater than y");
                }
                else
                {
                    Console.WriteLine("x is smaller than y");
                }
            }
            else
            {
                Console.WriteLine("Crazy input");
            }



            Console.Write("Give me a temperature: ");
            string answerTemp = Console.ReadLine();
            double temp;
            bool checkTemp = Double.TryParse(answerTemp, out temp);

            if (checkTemp)
            {
                if (temp > 20)
                {
                    Console.WriteLine("Wow it's getting hotter by the minute.");
                }
                else
                {
                    Console.WriteLine("Freezing?");
                }
            }
            else
            {
                Console.WriteLine("Crazy input, wrong format.");
            }



            Console.Write("What was your result out of 20? ");
            bool checkResult = Int32.TryParse(Console.ReadLine(), out int result);
            if (checkResult)
            {
                switch (result)
                {
                    case 20: Console.WriteLine("Amazing , top student");
                        break;
                    case 16: Console.WriteLine("Doing pretty well");
                        break;
                    case 10: Console.WriteLine("Close call");
                        break;
                    default: Console.WriteLine("Pretty shitty test");
                        break;
                }
            }
            else
            {
                Console.WriteLine("CRAZY INPUT, WRONG FORMAT");
            }





        }
    }
}
