using System;
using System.Diagnostics;

namespace Week10Methods_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            addition(5, 15);

            int number1 = 12;
            int number2 = 23;
            addition(number1, number2);

            int result = additionReturn(number1, number2) + 502;
            Console.WriteLine(result);

            Console.WriteLine(additionReturn(21, 51));

            int[] numbers = { 4, 5, 1, 0, 2, 3, 8, 6, 7, 9 };

            Print(numbers);
            Array.Sort(numbers);
            Print(numbers);

            int[] lilnumbers = { 0, 1, 2, 3 }; //length doesn't matter, foreach from start to finish
            Print(lilnumbers);
            Array.Reverse(lilnumbers);
            Print(lilnumbers);

            int[] nrs = Fill(15); 
            Print(nrs);
            Array.Sort(nrs);
            Print(nrs);

            int[] nrs2 = Fill();
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            string[] words = { "laptop", "dancing", "stars", "keyboard", "windows" };
            Print(words);
            Array.Sort(words);
            Print(words);

            char[] characters = { 'z', 'k', 'x', 't', 'o', 'b', 'p', 'a' };
            Print(characters);
            Array.Sort(characters);
            Print(characters);


            //pass by value vs pass by reference
            //VALUE
            int price = 499;
            Console.WriteLine($"PS5 price BEFORE 30% discount: {price}");
            BlackFriday(ref price);
            Console.WriteLine($"PS5 price AFTER 30% discount: {price}");

            /*int as a datatype has no memory location, it is considered a value type
             * while an array is a reference type and it sends over the actual memory location
             * by adding ref you make it into a reference type and send over its location
             * and can update both value and storage.*/


            //pass by reference
            int[] discounts = new int[1];
            discounts[0] = 299;
            Console.WriteLine($"PS5 price BEFORE 30% discount: {discounts[0]}");
            BlackFridayArray(discounts);
            Console.WriteLine($"PS5 price AFTER 30% discount: {discounts[0]}");


            //one more example of value vs ref type
            int first = 3;
            int second = 8;
            change(ref first,ref second);
            Console.WriteLine($"first: {first} and second: {second}");


            //old way of using out vs new
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


            //new way of using out, in combination with a method
            int subtract;
            int divide;
            SubtractAndDivide(50, 10, out subtract, out divide);
            Console.WriteLine(subtract);
            Console.WriteLine(divide);



            var returns = doubleReturn(5, 10);
            Console.WriteLine($"{returns.Item1} is the sum " +
                $"and {returns.Item2} is the multiplication " +
                $"and the char is: {returns.Item3}");

            //optional parameters
            Console.WriteLine(AddingValues(2));
            Console.WriteLine(AddingValues(2,6));
            Console.WriteLine(AddingValues(2, z: 12));


            //params keyword
            int[] myArray = { 5, 6, 7, 8, 9 };
            PrintArray(myArray);
            Console.WriteLine();
            PrintArray(3, 4, 2, 1, 4, 5, 6, 7, 8);

        }

        static void PrintArray(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + 5);
            }

        }

        static int AddingValues(int x, int y = 3, int z = 9)
        {
            int answer = x + y + z;
            return answer;
        }


        static void SubtractAndDivide(int a, int b, out int subtract, out int divide)
        {
            subtract = a - b;
            divide = a / b;
        }


        static (int, int, char) doubleReturn(int n1, int n2)
        {
            return (n1 + n2, Multiply(n1, n2), 'c');
        }
        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }




        static void change(ref int first,ref int second)
        {
            int storage = first;
            first = second;
            second = storage;
        }


        static void BlackFridayArray(int[] discounts)
        {
            discounts[0] = Convert.ToInt32(discounts[0] - (discounts[0] * 0.3));
        }

        static void BlackFriday(ref int price)
        {
            price = Convert.ToInt32(price - (price * 0.3));
        }

        static void Print(char[] chars)
        {
            foreach (var item in chars)
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


        static int[] Fill(int size = 8)
        {
            Random numbers = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = numbers.Next(0, 10);
            }
            return array;
            //Array.Sort(array); --> considered DEAD CODE!
        }


        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int additionReturn(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }


        static void addition(int number1, int number2)
        {
            int answer = number1 + number2;
            Console.WriteLine(answer);
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
