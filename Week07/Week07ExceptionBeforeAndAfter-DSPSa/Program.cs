using System;
using System.IO;

namespace Week07ExceptionBeforeAndAfter_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OLD WAY
            Console.Write("Enter filename: ");
            string file = Console.ReadLine();

            Console.Write("Enter linenumber: ");
            int linenr; 

            if (!Int32.TryParse(Console.ReadLine(), out linenr))
            {
                Console.WriteLine("Not a valid linenumber! We stop!");
                return;
            }
            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length || linenr < 0)
                {
                    Console.WriteLine("Linenr is too big or below 0, we stop!");
                    return;
                }
                Console.WriteLine(text[linenr - 1]);
            }
            else
            {
                Console.WriteLine("File doesn't exist! We stop!");
                return;
            }

            Console.WriteLine();
            //NEW WAY WITH EXCEPTION HANDLING
            try
            {
                Console.Write("Enter filename: ");
                file = Console.ReadLine();
                Console.Write("Enter linenr: ");
                linenr = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[linenr - 1]);
            }
            catch (FormatException) //linenr = 3.5
            {
                Console.WriteLine("Linenumber was in a different datatype!");
            }
            catch (FileNotFoundException) //filename = ENG.txt
            {
                Console.WriteLine("Wrong filename!");
            }
            catch (IndexOutOfRangeException ex) //linenr = -7
            {
                Console.WriteLine("Index was too high or negative!");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too big!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("test");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            Console.WriteLine();
            try
            {
                int nr = Convert.ToInt32(Console.ReadLine());
                if (nr > 0 && nr < 20)
                {
                    Console.WriteLine(nr);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too BIG!");
            }
            catch (Exception)
            {
                Console.WriteLine("Oops, a problem!");
            }



        }
    }
}
