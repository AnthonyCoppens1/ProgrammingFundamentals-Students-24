using System;

namespace _04Week3Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a programme that asks for a month based on a number
             * output-> month's name
             * e.g. 1 -> January / 2 -> February / 8 -> August
             * Use TryParse to check if the input is a valid number
             * check if the number is a valid month number (1-12) 
             * use switch case to show month names
             crazy input if other number or other input*/

            bool succes = Int32.TryParse(Console.ReadLine(), out int month);
            if (succes)
            { //valid
                if (month > 0 && month < 13)
                {
                    switch(month)
                    {
                        case 12: Console.WriteLine("December");
                            break;
                        case 11: Console.WriteLine("November");
                            break;
                        case 10: Console.WriteLine("October");
                            break;
                        case 9: Console.WriteLine("September");
                            break;
                        case 8:
                            Console.WriteLine("August");
                            break;
                        case 7:
                            Console.WriteLine("July");
                            break;
                        case 6:
                            Console.WriteLine("June");
                            break;
                        case 5:
                            Console.WriteLine("May");
                            break;
                        case 4:
                            Console.WriteLine("April");
                            break;
                        case 3:
                            Console.WriteLine("March");
                            break;
                        case 2:
                            Console.WriteLine("Febrary");
                            break;
                        default:
                            Console.WriteLine("January");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Crazy input");
                }
            }
            else
            {
                Console.WriteLine("Crazy input");
            }
        }
    }
}
