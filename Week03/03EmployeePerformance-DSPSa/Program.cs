using System;

namespace _03EmployeePerformance_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This is an exercise to rate the performance of employees
             These are the following ranges:
            0 - 10: "Your lazy ass did nothing all year, as if you think you can still work here. YOU ARE FIRED"
            10 - 40: "Work harder, or we will cut your paycheck in HALF"
            40 - 60: "You're doing okay, but try to talk less.
            60 - 80: "Good job, you might become the star of the company one day.
            80 - 100: "YOU ARE THE SUPREME EMPLOYEE, YOU ARE AMAZING, BE GREAT, RUN FOR PRESIDENT.
            use tryparse to find invalid numbers*/

            string answer = Console.ReadLine();
            bool check = Int32.TryParse(answer, out int score);

            if (check)
            {
                if (score >= 0 && score <= 10)
                {
                    Console.WriteLine("Your lazy ass did nothing all year, " +
                        "as if you think you can still work here. YOU ARE FIRED");
                }
                else if (score > 10 && score < 41)
                {
                    Console.WriteLine("Work harder, or we will cut your paycheck in HALF");
                }
                else if (score > 40 && score <= 60)
                {
                    Console.WriteLine("You're doing okay, but try to talk less");
                }
                else if (score > 60 && score <= 80)
                {
                    Console.WriteLine("You're doing pretty well");
                }
                else if (score > 80 && score <= 100)
                {
                    Console.WriteLine("You're amazing");
                }
                else
                {
                    Console.WriteLine("Please enter a valid score");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
