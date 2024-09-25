using System;

namespace _02ValidAge_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //sum of 3 decimal numbers printed as an integer

            double whateveryouwant = Convert.ToDouble(Console.ReadLine());
            double dec2 = Convert.ToDouble(Console.ReadLine());
            double itsalmost6oclock = Convert.ToDouble(Console.ReadLine());

            double sum = whateveryouwant + dec2 + itsalmost6oclock;

            
            double sumInt = Math.Floor(sum);
            int s = (int)sumInt;
            Console.WriteLine(s);
        }
    }
}
