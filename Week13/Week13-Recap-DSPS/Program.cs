using System;

namespace Week13_Recap_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string question = Console.ReadLine();
                Exercises recap = new Exercises();

                switch (question)
                {
                    case "Missing":
                        string sequence = Console.ReadLine();
                        recap.Missing(sequence);
                        break;

                    case "Calculator":
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        string operation = Console.ReadLine();
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        recap.Calculator(num1, operation, num2);
                        break;

                    case "Multiplication":
                        int[] str = Array.ConvertAll(Console.ReadLine().Replace(" ", "x").Split("x"), Convert.ToInt32);
                        recap.Multiplication(str);
                        break;

                    case "Abundant":
                        int[] boundaries = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
                        recap.Abundant(boundaries);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for the type");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index was out of range");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }            
        }
    }
}
