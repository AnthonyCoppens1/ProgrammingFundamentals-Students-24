using System;

namespace Week11_RecapMethods_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOutSomething();

            int a = 7;
            int b = 5;
            Console.WriteLine(Count(a, b));
            double c = 25;

            (int subtraction, double division) = subAndDiv(a, b, c);

            Console.WriteLine($"a:{a} and b:{b}");
            multi(ref a,ref b);
            Console.WriteLine($"a:{a} and b:{b}");

            int[] array = { 3, 2, 1, 5, 6, 7 };
            int sum;
            SumOfIndexes(array, out sum);
            Console.WriteLine(sum);

            changeArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }

        }

        static void changeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
                Console.Write(array[i] + " ");
            }
        }

        static void SumOfIndexes(int[] array, out int sum)
        {
            sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
        }


        static void multi(ref int a,ref int b)
        {
            a *= 2;
            b *= 2;
        }

        static (int, double) subAndDiv(int a, int b, double c)
        {
            int sub = a - b;
            double div = c / b;
            return (sub, div);
        }

        static int Count(int a, int b)
        {
            return a + b;
        }

        static void PrintOutSomething()
        {
            Console.WriteLine("Hello World!");
        }


    }
}
