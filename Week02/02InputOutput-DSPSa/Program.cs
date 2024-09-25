using System;

namespace _02InputOutput_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input and output
            Console.Write("Enter your name: ");
            Console.ReadLine();

            //conversion
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            Console.WriteLine(number + number);

            Console.Write("Enter a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + n);

            //conversion of other datatypes
            Console.Write("Enter a byte: ");
            answer = Console.ReadLine();

            byte b = Convert.ToByte(answer);
            Console.Write(b + b);

            Console.Write("Enter a short: ");
            answer = Console.ReadLine();
            short s = Convert.ToInt16(answer);
            Console.Write(s + s);

            //int16 = short / int32 = int / int64 = long

            //conversion implicit and explicit
            Console.WriteLine(s); //--> implicit conversion
            Console.WriteLine(s.ToString()); // --> explicit conversion

            Console.Write("Enter a character: ");
            answer = Console.ReadLine();
            char c = Convert.ToChar(answer);

            Console.WriteLine(c);
            Console.WriteLine((int)c); //ascii value

            //int nameToNumber = (int)name; --> never works
            //int stringNumber = (int)"89"; --> never works

            number = (int)78.8989;
            double doubleNumber = (double)78;
            Console.WriteLine(number);
            Console.WriteLine(doubleNumber);







            
        }
    }
}
