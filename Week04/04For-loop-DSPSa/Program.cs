using System;

namespace _04For_loop_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //multiply a given by 1 --> ...
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //IDIOT VERSION
            Console.WriteLine($"{number} * 1 = {number * 1}");
            Console.WriteLine($"{number} * 2 = {number * 2}");
            Console.WriteLine($"{number} * 3 = {number * 3}");
            Console.WriteLine($"{number} * 4 = {number * 4}");
            Console.WriteLine($"{number} * 5 = {number * 5}");

            //better version
            Console.WriteLine("\nFOR LOOP i = 0 i <= 10");
            
            for (int i = 0; i <= 10; i++) //same as saying i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 1 i <= 10");
            for (int i = 1; i <= 10; i++) //same as i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            //compound operators: += -= *= /= %=

            Console.WriteLine("\nFOR LOOP i = 0 i <= 10 STEPSIZE 2");
            for (int i = 0; i <= 10; i += 2) //same as i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 0 i <= 10 STEPSIZE multiply by 2");
            //BEWARE OF INFINTE LOOP --> start at 1
            for (int i = 1; i <= 10; i *= 2) //same as i < 11
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }


            Console.WriteLine("\nFOR LOOP i = 10; i >= 0; i--");
            //be careful for: for (int i = 10; i <= 0; i--) 10 is not smaller or equal to 0
            //skips the whole for-loop

            /*for (int i = 10; i >= 0; i++)
            {
                Console.WriteLine("Hello");
            } --> infinite loop because it goes 10 11 12 13, never reaching 0*/
            
            for (int i = 10; i >= 0; i--)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            //print 3 6 9 12 15 18 21 ... 33
            Console.WriteLine("\nversion 3 6 9 ... 33");
            for (int i = 3; i < 34; i += 3)
            {
                Console.Write(i + " ");
            }

            //print 3 6 9 ... 100
            Console.WriteLine("\nversion 3 6 9 ... 100");
            for (int i = 3; i <= 100; i += 3)
            {
                Console.Write(i + " ");
            }


            //print 3 6 9 12 ... 
            Console.WriteLine("\nversion 3 6 9... but not incrementing with 3");
            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            //nesting for-loops --> loop in a loop
            Console.Write("\n\nEnter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTable of j's");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();//needs to be here, otherwise everything prints on 1 line
            }


            Console.WriteLine("\ntable of stars");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); //needs to be here, otherwise everything prints on 1 line
            }


            Console.WriteLine("\n table of i's"); //the value of i
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n Pyramid");
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
