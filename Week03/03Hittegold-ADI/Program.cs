using System;

namespace _03Hittegold_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*hittegolf calculator
             * 5 opeenvolgende dagen temp > 25
             * 3 van die 5 dagen > 30  --> moeten niet opeenvolgend zijn*/

            double dag1 = Convert.ToDouble(Console.ReadLine());
            double dag2 = Convert.ToDouble(Console.ReadLine());
            double dag3 = Convert.ToDouble(Console.ReadLine());
            double dag4 = Convert.ToDouble(Console.ReadLine());
            double dag5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("test");
            Console.Write("hello");
            Console.WriteLine("2e test");


            if (dag1 >= 25 && dag2 >= 25 && dag3 >= 25 && dag4 >= 25 && dag5 >= 25)
            {
                
                
            }

        }
    }
}
