namespace _04Week3Recap_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*write a programme that will ask the user for a number
             * this number is directly linked to the name of the corresponding month
             * eg. -> 1 -> January / 2 -> February / 6 -> June
             * Need to TryParse
             * At least 1 if-statement
             * At least 1 switch-case
             * switch ( )
             * {
             *      case 12: ...
             *          break;
             *      default: ...
             *          break;
             * }
             */


            bool check = Int32.TryParse(Console.ReadLine(), out int month);

            if (check) //true if managed to properly convert
            {
                switch (month)
                {
                    case 12: Console.WriteLine("December");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 1:
                        Console.WriteLine("January");
                        break;
                    default:
                        Console.WriteLine("crazy input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
