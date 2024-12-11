using System;

namespace Week11_RecapMethods_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOut();

            int a = 6;
            int b = 8;
            double c = 2.3;

            Console.WriteLine(AddedUp(a, b));

            (int sub, double div) = SubAndDivide(a, b, c);
            Console.WriteLine(sub);
            Console.WriteLine(div);

            Console.WriteLine($"a: {a} and b: {b}");
            AddFive(ref a,ref b);
            Console.WriteLine($"a: {a} and b: {b}");

            Console.WriteLine(AddedUp(a, b));

            int subtract;
            int multiplication;
            SubAndMultiply(a, b, out subtract, out multiplication);
            Console.WriteLine(subtract);
            Console.WriteLine(multiplication + subtract);

            int[] array = { 3, 2, 5, 4, 1 };
            Print(array);

            double[] doubles = { 3.2, 5.1, 1.2 };
            Print(doubles);

            AddFiveToArray(array);
            Print(array);

            Console.WriteLine($"{a} {b} {c}");
            SubAndDivide(a, c: 27);

        }

        static void AddFiveToArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        static void Print(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void SubAndMultiply(int a, int b, out int subtract, out int multiplication)
        {
            subtract = a - b;
            multiplication = a * b;
        }

        static void AddFive(ref int a,ref int b)
        {
            a += 5;
            b += 5;
        }

        static (int, double) SubAndDivide(int a, int b = 12, double c = 8)
        {
            int subtraction = a - b;
            double divide = a / c;
            return (subtraction, divide);
        }

        static int AddedUp(int a, int b)
        {
            int sum = a + b;
            return sum;
        }


        static void PrintOut() //void executes something, but doesn't return
        {
            Console.WriteLine("Hello");
        }
    }
}
