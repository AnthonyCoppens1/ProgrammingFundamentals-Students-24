using System;
using System.Data;

namespace Week11_HerhalingMethods_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDit();

            int a = 7;
            int b = 10;
            double c = 3.2;

            Console.WriteLine(Optellen(a, b));

            (int maal, double deling) = MaalEnDeel(a,b:b);
            Console.WriteLine(maal);
            Console.WriteLine(deling);

            Console.WriteLine($"a: {a} en b: {b}");
            Plus(ref a,ref b);
            Console.WriteLine($"a: {a} en b: {b}");

            int min;
            minus(a, b, out min);
            Console.WriteLine(min);

            int[] array = { 3, 7, 2, 9, 5 };
            PlusVijf(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            double[] D = { 3.2, 5.1, 8.3 };
            PlusVijf(D);
            foreach (var item in D)
            {
                Console.Write(item + " ");
            }


        }

        static void PlusVijf(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        static void PlusVijf(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        static void minus(int a, int b, out int aftreksom)
        {
            aftreksom = a - b;
        }

        static void Plus(ref int a,ref int b)
        {
            a += 3;
            b += 5;
        }

        static (int, double) MaalEnDeel(int a, double c = 2.8, int b = 1)
        {
            int maal = a * b;
            double deel = a / c;
            return (maal, deel);

        }


        static int Optellen(int a, int b)
        {
            int som = a + b;
            return som;
        }

        static void PrintDit()
        {
            Console.WriteLine("Dit wil ik printen");
        }
    }
}
