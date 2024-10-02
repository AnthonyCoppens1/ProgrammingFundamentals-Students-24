using System;

namespace _03Switch_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //info dates
            int weekday = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

            DateTime yesterday = new DateTime(2024, 10, 01);
            DateTime birth = new DateTime(1995, 07, 31);
            string day = yesterday.DayOfWeek.ToString();

            Console.WriteLine(day);
            Console.WriteLine(yesterday.DayOfYear);

            int hours = (int)DateTime.Now.Hour;
            Console.WriteLine(hours);
            //uses actual time and date from timezone.

            //SWITCH STATEMENT
            //Done with if first
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
            else if (weekday == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (weekday == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("WOHOO SUNDAY!");
            }


            //SWITCH STATEMENT
            //without if
            switch (weekday)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                default: Console.WriteLine("WOHOOO FRIDAY OR ALMOST WEEKEND");
                    break;
            }


            //test lucky birthdays
            switch (birth.Day)
            {
                case 14: Console.WriteLine("You have a lucky birthday");
                    break;
                case 1: Console.WriteLine("If you were born in April, you are a walking joke");
                    break;
                case 13: Console.WriteLine("If you were born on a Friday, BEWARE!");
                    break;
                case 31: Console.WriteLine("You were born in the middle of the summer");
                    break;
                default: Console.WriteLine("Your birthday sucks!");
                    break;
            }


            //avoiding errors with tryparsing
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;

            if (x > y) //as long as you enter an integer there is no problem!
            {
                Console.WriteLine("x is greater than y");
            }


            //avoid with an if 
            Console.Write("z = ");
            string answer = Console.ReadLine();
            int z;
            bool succes = Int32.TryParse(answer, out z);

            if (succes)
            {
                if (z > y)
                {
                    Console.WriteLine("x is greater than y");
                }
            }
            else
            {
                Console.WriteLine("Oops, crazy input");
            }


            //tryparse part 2
            Console.WriteLine("Give me a temperature: ");
            answer = Console.ReadLine();

            if (Int32.TryParse(answer,out int temp))
            {
                if (temp < 0)
                {
                    Console.WriteLine("Brrrr it's freezing");
                }
                else
                {
                    Console.WriteLine("A little frisky");
                }
            }
            else
            {
                Console.WriteLine("Crazy input");
            }

        }
    }
}
