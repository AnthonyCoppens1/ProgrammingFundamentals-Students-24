using System;

namespace Week07ExceptionBeforeAndAfter_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OLD WAY
            Console.Write("enter filename: ");
            string file = Console.ReadLine();

            Console.WriteLine("Enter a line number: ");
            if (!Int32.TryParse(Console.ReadLine(), out int linenr))
            {
                Console.WriteLine("Not a valid linenumber! We stop!");
                return;
            }

            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (linenr > text.Length || linenr < 0)
                {
                    Console.WriteLine("Linenumber is too big or too small! We Stop!");
                    return;
                }
                else
                {
                    Console.WriteLine(text[linenr]);
                }
            }
            else
            {
                Console.WriteLine("Not a valid file! We stop!");
                return;
            }



            //NEW WAY WITH EXCEPTION HANDLING
            try
            {
                Console.Write("Enter filename: ");
                string f = Console.ReadLine();
                Console.Write("Enter a linenumber: ");
                int L = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(f);
                Console.WriteLine(text[L]);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File was not found!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Linenumber is in wrong format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too big!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number is negative, give a correct one.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other problem!");
            }


            Console.WriteLine();
            try
            {
                int N = Convert.ToInt32(Console.ReadLine());
                if (N > 0 && N < 20)
                {
                    Console.WriteLine(N);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Problem with number");
            }




            Console.WriteLine();
            bool check = true; 
            /*forcefully keeps the loop going
             * as long as we keep on typing mistakes or making them
             * it will keep on rerunning the code until you have fixed your issues
             * then it ends by itself and changes check into false, because you've
             * managed to print out the actual line.
             */
            while (check)
            {
                try
                {
                    Console.Write("Enter filename: ");
                    string f = Console.ReadLine();
                    Console.Write("Enter a linenumber: ");
                    int L = Convert.ToInt32(Console.ReadLine());
                    string[] text = File.ReadAllLines(f);
                    Console.WriteLine(text[L]);
                    check = false;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("File was not found!");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Linenumber is in wrong format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too big!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number is negative, give a correct one.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Other problem!");
                }
            }

        }
    }
}
