using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Week13_EindeSemester_ADI
{
    public class Oefeningen
    {
        public void Abundant(string input)
        {
            int[] startEnEinde = Array.ConvertAll(input.Split(" "), Convert.ToInt32);
            Array.Sort(startEnEinde);

            if (startEnEinde[0] < 0 || startEnEinde[1] < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Dictionary<char, List<int>> getallen = new Dictionary<char, List<int>>();
            for (int i = startEnEinde[0]; i <= startEnEinde[1]; i++)
            {
                //check of het abundant is
                if (checkAbundant(i))
                {
                    if (!getallen.ContainsKey(i.ToString()[0]))
                    {
                        getallen.Add(i.ToString()[0], new List<int> { i });
                    }
                    else if (getallen.ContainsKey(i.ToString()[0]))
                    {
                        getallen[i.ToString()[0]].Add(i);
                    }
                }
            }

            foreach (var keypair in getallen)
            {
                foreach (var v in keypair.Value)
                {
                    Console.Write(v + " ");
                }
                Console.WriteLine();
            }
        }

        public bool checkAbundant(int ints)
        {
            int som = 0;
            for (int i = 1; i < ints; i++)
            {
                if (ints % i == 0)
                {
                    som += i;
                }
            }

            if (som > ints)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void Multiplication(string[] str)
        {
            try
            {
                int[][] str1 = new int[int.Parse(str[0])][];
                int[][] str2 = new int[int.Parse(str[2])][];

                //jagged array van str1 invullen adhv user input en omzetten naar gehele getallen
                for (int i = 0; i < str1.Length; i++)
                {
                    str1[i] = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                }

                //jagged array van str2 invullen adhv user input en omzetten naar gehele getallen
                for (int i = 0; i < str2.Length; i++)
                {
                    str2[i] = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                }

                int vermenigvuldiging = 0;

                for (int i = 0; i < int.Parse(str[0]); i++)
                {
                    for (int j = 0; j < int.Parse(str[0]); j++)
                    {
                        for (int k = 0; k < int.Parse(str[2]); k++)
                        {
                            vermenigvuldiging += str1[i][k] * str2[k][j];
                        }
                        Console.Write(vermenigvuldiging + " ");
                        vermenigvuldiging = 0;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }


        public void Calculator(double getal1, string symbool, double getal2)
        {
            try
            {
                double resultaat;
                switch (symbool)
                {
                    case "+":
                        resultaat = getal1 + getal2;
                        break;
                    case "-":
                        resultaat = getal1 - getal2;
                        break;
                    case "*":
                        resultaat = getal1 * getal2;
                        break;
                    case "/":
                        if (getal2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        resultaat = getal1 / getal2;
                        break;
                    case "%":
                        resultaat = getal1 % getal2;
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }


        }

        public void Missing(string cijfers)
        {
            try
            {
                //9 3 6 1 7 5 2 4 8
                int[] getallen = Array.ConvertAll(cijfers.Split(" "), Convert.ToInt32);
                int totaal = 45;

                for (int i = 0; i < getallen.Length; i++)
                {
                    totaal -= getallen[i];
                }

                if (totaal == 0)
                {
                    Console.WriteLine("There is no missing link!");
                }
                else
                {
                    Console.WriteLine(totaal);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
            
        }

    }
}
