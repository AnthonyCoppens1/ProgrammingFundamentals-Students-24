using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Week13_Recap_DSPS
{
    public class Exercises
    {
        public void Abundant(int[] boundaries)
        {
            //{1, 133} {278, 5}
            Array.Sort(boundaries);
            if (boundaries[0] < 0 || boundaries[1] < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Dictionary<char, List<int>> numbers = new Dictionary<char, List<int>>();
            for (int i = boundaries[0]; i <= boundaries[1]; i++)
            {
                //check if abundant
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (!numbers.ContainsKey(i.ToString()[0]) && sum > i)
                {
                    numbers.Add(i.ToString()[0], new List<int> { i });
                }
                else if (numbers.ContainsKey(i.ToString()[0]) && sum > i)
                {
                    numbers[i.ToString()[0]].Add(i);
                }
            }

            foreach (var keypair in numbers)
            {
                foreach (var v in keypair.Value)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine();
            }
        }


        public void Multiplication(int[] str)
        {
            if (str[1] != str[2])
            {
                Console.WriteLine("wrong dimensions");
            }
            else
            { //imagine for 4x2 2x4
                int[][] str1 = new int[str[0]][]; //4
                int[][] str2 = new int[str[2]][]; //2

                FillAndConvert(str1);
                FillAndConvert(str2);

                int multiplication = 0;

                for (int i = 0; i < str[0]; i++)
                {
                    for (int j = 0; j < str[0]; j++)
                    {
                        for (int k = 0; k < str[1]; k++)
                        {
                            multiplication += str1[i][k] * str2[k][j];
                        }
                        Console.Write(multiplication + " ");
                        multiplication = 0;
                    }
                    Console.WriteLine();
                }
            }
        }

        public int[][] FillAndConvert(int[][] I)
        {
            //convert and create all elements in 1st array
            for (int i = 0; i < I.Length; i++)
            {
                I[i] = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            }
            return I;
        }


        public void Calculator(double N1, string symbol, double N2)
        {
            double result;

            switch (symbol)
            {
                case "+":
                    result = N1 + N2;
                    break;
                case "-":
                    result = N1 - N2;
                    break;
                case "*":
                    result = N1 * N2;
                    break;
                case "/":
                    if (N2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = N1 / N2;
                    break;
                case "%":
                    if (N2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = N1 % N2;
                    break;
                default:
                    throw new Exception();
                    break;
            }
            Console.WriteLine($"Result: {result}");
        }



        public void Missing(string sequence)
        {
            //9 3 6 1 7 5 2 4 8
            string[] numbers = sequence.Split(" ");
            int total = 45;

            for (int i = 0; i < 800; i++)
            {
                total -= Convert.ToInt32(numbers[i]); 
                //total = total - Convert.ToInt32(numbers[i]);
            }

            /*foreach (var n in numbers)
            {
                total -= Convert.ToInt32(n);
            }*/

            if (total == 0)
            {
                Console.WriteLine("There is no missing link");
            }
            else
            {
                Console.WriteLine(total);
            }


        }
    }
}
