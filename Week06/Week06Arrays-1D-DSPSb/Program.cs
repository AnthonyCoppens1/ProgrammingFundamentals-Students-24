using System;
using System.Transactions;

namespace Week06Arrays_1D_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create arrays
            int[] intArray = new int[10]; //every value is currently 0
            string[] stringArray = new string[4]; // they are all filles ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);
            int[] ints = { 1, 3, 8, 23, 99 };
            //byte[] b = { 0, 1, 2, -3, 300 }; --> values inside array have to follow rules of datatype


            //get values
            Console.WriteLine($"First element of intArray: {intArray[0]}");
            Console.WriteLine($"Last element of doubles: {doubles[5]}");
            Console.WriteLine($"Last element of doubles: {doubles[^1]}");
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length-1]}");

            //^1 starts at last index, ^2 is second to last one


            //assigning values
            stringArray[0] = "Dean";
            stringArray[1] = "Jessica";
            stringArray[2] = "Tom";
            stringArray[3] = "Karen";
            //stringArray[4] = "Bob"; --> index out of bounds, max 4 elements (index 0 - 3)

            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length - 1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Last element of doubles: {doubles[doubles.Length - 1]}");


            //looping through arrays
            //foreach
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (string name in stringArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //for-loop
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.WriteLine(doubles[i]);
            }
            Console.WriteLine();

            //while
            int index = 0;
            while (index < doubles.Length)
            {
                Console.Write(doubles[index] + " ");
                index++;
            }
            Console.WriteLine();


            //overwriting the entire array
            doubles = new double[] { 1, 3, 4, -1, -4, 55, 8, 89 };
            foreach (var item in doubles)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //filling an array with a for-loop
            //using this line from up top --> int[] intArray = new int[10];
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



            //filling an array with the split method
            Console.WriteLine("Enter animals, separated by a space: ");
            string answer = Console.ReadLine(); //cat dog elephant mouse rat pigeon

            string[] animals = answer.Split(' ');
            foreach (var item in animals)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            Console.WriteLine("Enter animals, separated by a ; : ");
            answer = Console.ReadLine(); //cat;dog;elephant;mouse;rat;pigeon

            animals = answer.Split(';');
            foreach (var item in animals)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //filling and converting an array
            Console.WriteLine("Enter numbers, separated by a space: ");
            string input = Console.ReadLine(); // "73 18 -59 12 3 0"

            string[] s = input.Split(' ');
            int[] arrayOfInts = new int[s.Length];

            for (int i = 0; i < arrayOfInts.Length; i++) //can also use i < s.Length
            {
                arrayOfInts[i] = Convert.ToInt32(s[i]);
            }

            foreach (var item in arrayOfInts)
            {
                Console.Write((item + 5) + " ");
            }
            Console.WriteLine();




            //or convert whole array in 1 go
            arrayOfInts = Array.ConvertAll(s, Convert.ToInt32);





        }
    }
}
