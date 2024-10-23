using System;

namespace Week06Array1D_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating arrays
            int[] intArray = new int[10]; //at this point all values are 0
            string[] stringArray = new string[4]; //at this point all values are 

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);
            int[] ints = { 1, 3, 8, 23, 99 };

            //getting values
            Console.WriteLine("First element of intArray: " + intArray[0]);
            Console.WriteLine($"Last element of doubles: {doubles[5]}");
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length - 1]}");
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");

            //^ starts counting from end --> ^1 is last element, ^2 is second to last, ...

            //assigning values
            stringArray[0] = "Dean";
            stringArray[1] = "Bob";
            stringArray[2] = "John";
            stringArray[3] = "Tom";
            //stringArray[4] = "New person"; --> index out of range, there can only be 4 elements
            
            Console.WriteLine($"\nLast element of doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");

            //looping through arrays

            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            //foreach is used if you have no idea of the index of an element
            //or don't know what's inside


            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }


            //for loop
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }

            Console.WriteLine();

            //while --> doubles has length of 6, indexes: 0, 1, 2, 3, 4, 5
            int index = 0;

            while(index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++;
            }


            //overwriting an array entirely
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8, 89 };
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();


            //filling an array with a for-loop
            //YOU WILL NEED THIS ALMOST EVERY TIME
            for (int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;
                Console.Write($"Enter a number for index {i}: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //filling an array with the split Method
            Console.WriteLine("Enter animals, separated by a space: ");
            //string answer = "cat elephant dog horse fox panther snake";
            string answer = Console.ReadLine();

            string[] animals = answer.Split(" ");

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //split on ;
            answer = Console.ReadLine();

            animals = answer.Split(";");

            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }


            //filling an array with numbers after split method
            Console.WriteLine("Enter some numbers split with a space: ");
            answer = "8 -7 3 1 2 5 27 13";
            string[] strArray = answer.Split(" ");
            int[] arrayOfInts = new int[strArray.Length];

            for (int i = 0; i < arrayOfInts.Length; i++) //or i < strArray.Length
            {
                arrayOfInts[i] = Convert.ToInt32(strArray[i]);
            }

            foreach (var item in arrayOfInts)
            {
                Console.WriteLine(item);
            }


            //or convert whole array in 1 go
            arrayOfInts = Array.ConvertAll(strArray, Convert.ToInt32);
            



        }
    }
}
