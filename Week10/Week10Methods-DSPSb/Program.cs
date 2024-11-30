using System;
using System.Data;

namespace Week10Methods_DSPSb
{
    internal class Program
    {
        //static int[] numbers = { 4, 5, 1, 0, 2, 3 }; 
        //if you make this inside internal class program, but outside of any method
        //this array is usable by ANY of your methods!

        static void Main(string[] args)
        {
            HelloWorld();
            Console.WriteLine();

            Add(5, 10);
            Add(201, 99);

            int N1 = 68;
            int N2 = 495;

            Add(N1, N2);
            Console.WriteLine();

            Console.WriteLine(AddAndReturn(20, 30));

            int supersum = AddAndReturn(20, 30) + 17;
            Console.WriteLine(supersum);
            Console.WriteLine();

            int[] numbers = { 4, 5, 1, 0, 2, 3 };

            Print(numbers);
            Array.Sort(numbers);
            Print(numbers);
            Console.WriteLine();

            int[] nrs2 = { 2, 4, 6, 8, 9, 10, 1, 2, 5, 7, 9, 12, -3 };
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);
            Console.WriteLine();

            int[] nrs3 = Fill(); //e.g. --> {99, 67, 21, 0, 13, 25, 77, 18, 32, 51}
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            Console.WriteLine();
            int[] nrs4 = Fill(25);
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);
            Console.WriteLine();

            string[] words = { "banana", "pear", "apple" };
            Print(words);
            Array.Sort(words);
            Print(words);
            Console.WriteLine();

            double[] doubles = { 1.2, 9.8, 2.7, 3.5, 5.2 };
            Print(doubles);
            Array.Sort(doubles);
            Print(doubles);


            //pass by value
            int studentGrade = 75;
            Console.WriteLine($"Student's grade BEFORE extra credits: {studentGrade}");
            GiveExtraCredits(ref studentGrade);
            Console.WriteLine($"Student's grade AFTER extra credits: {studentGrade}");

            /* int has no memory location, but is a value type!
             * An array for example is a reference type and contains locations to specific
             * indexes, therefore sends over each location instead of just the values stored             * 
             */

            //pass by reference
            int[] grades = new int[1];
            grades[0] = 80;
            Console.WriteLine($"Student's grade BEFORE extra credits: {grades[0]}");
            GiveExtraCreditsARRAY(grades);
            Console.WriteLine($"Student's grade AFTER extra credits: {grades[0]}");


            int a = 6;
            int b = 8;
            Console.WriteLine($"a: {a} and b: {b}");
            Swap(ref a,ref b);
            Console.WriteLine($"a: {a} and b: {b}");
            Console.WriteLine();

            //using OUT in the old known way
            Console.Write("Enter an array size: ");
            string answer = Console.ReadLine();
            int size;
            int[] array;
            if (Int32.TryParse(answer, out size))
            {
                array = Fill(size);
            }
            else
            {
                array = Fill();
            }
            Print(array);

            int add;
            int multiply;
            AddAndMultiply(5, 10,out add,out multiply);
            Console.WriteLine(add + " " + multiply);
            Console.WriteLine();

            AddValues(5);
            AddValues(5, 12);
            AddValues(5, z: 25);
            AddValues(5, 2, 7);

            // AddValues(, 2, 3); x NEEDS to be provided! if arguement is surrounded by [] 
            // it isn't necessary to be provided.

            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);

            PrintArray(4, 3, 2, 1, 5, 4, 3, 2, 6, 8, 90, 21, 23, 54, 12, 16);

        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void AddValues(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }


        static void AddAndMultiply(int a, int b, out int A, out int M)
        {
            A = a + b;
            M = a * b;
        }


        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void GiveExtraCreditsARRAY(int[] grades)
        {
            grades[0] += 3;
        }

        static void GiveExtraCredits(ref int studentGrade)
        {
            studentGrade += 3;
        }

        static void Print(double[] doubles)
        {
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static void Print(string[] words)
        {
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] Fill(int size = 10)
        {
            int[] array = new int[size];
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(0, 101);
            }
            return array;
            //Array.Sort(array); --> DEAD CODE, after the return, doesn't trigger anymore.
        }

        static void Print(int[] N)
        {
            foreach (var item in N)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        static int AddAndReturn(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }


        static void Add(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(answer);
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
