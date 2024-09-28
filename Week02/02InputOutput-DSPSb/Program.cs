using System;

namespace _02InputOutput_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input and output of different datatypes
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //conversion to numbers
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);
            Console.WriteLine(number);

            short s = Convert.ToInt16(answer);
            long l = Convert.ToInt64(answer);
            Console.WriteLine(l);
            Console.WriteLine(s);

            byte b = Convert.ToByte(answer);

            //int = int32 / short = int16 / byte = byte / long = int64

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);


            //implicit and explicit conversion
            Console.WriteLine(s); //implicit conversion
            Console.WriteLine(s.ToString()); //explicit conversion

            //characters
            answer = Console.ReadLine();
            char c = Convert.ToChar(answer);

            Console.WriteLine(c);
            Console.WriteLine((int)c); //decimal ASCII value

            //int nameToNumber = (int)name; --> never works
            //int stringToNumber = (int)"89"; --> never works

            number = (int)78.903456;
            double numberD = (double)78;

            Console.WriteLine(number);
            Console.WriteLine(numberD);

            int no = (int)c;
            char ch = (char)number;

            Console.WriteLine(ch);


        }
    }
}
