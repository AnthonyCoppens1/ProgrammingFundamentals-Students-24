using System;

namespace Week06Arrays_Jagged_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aanmaken van jagged arrays
            int[][] ints = new int[3][];
            ints[0] = new int[] { 1, 2, 3, 4 };
            ints[1] = new int[] { 5 };
            ints[2] = new int[] { 6, 7 };

            string[][] fruit = {new string[] {"appel", "avocado", "abrikoos"},
            new string[] {"banaan", "bes", "kiwi"},
            new string[] {"kokosnoot"},
            new string[] {"durian", "dragonfuit"} };

            double[][] doubles = {new double[] {1.2, 5.8},
            new double[] {4, 5.7, 9}};



            //waarden oproepen
            Console.WriteLine(fruit[2][0]);
            Console.WriteLine(doubles[1][1]);
            doubles[1][1] = 6;
            Console.WriteLine(doubles[1][1]);


            //loopen door jagged arrays
            for (int i = 0; i < fruit.Length; i++)
            {
                for (int j = 0; j < fruit[i].Length; j++)
                {
                    Console.Write(fruit[i][j] + " ");
                }
                Console.WriteLine();
            }



            foreach (var item in fruit)
            {
                foreach (var element in item)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
