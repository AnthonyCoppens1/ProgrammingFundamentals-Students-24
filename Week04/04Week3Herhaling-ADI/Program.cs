namespace _04Week3Herhaling_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*schrijf een programma dat gebaseerd op de nummer van de maand
             * de effectieve naam van de maand toont.
             * TryParse gebruiken
             * verplicht nesten
             * verplicht switch-case gebruiken
             * 
             * alles dat geen valide maandnummer is, crazy input!
             * 
             * switch ( )
             * {
             *      case ... :
             *          code;
             *          break;
             *      default:
             *          code;
             *          break;
             * 
             * }*/



            bool check = Int32.TryParse(Console.ReadLine(), out int n);

            if (check)
            {
                if (n > 0 && n < 13) //(n >= 1 && n <= 12)
                {
                    switch (n)
                    {
                        case 12:
                            Console.WriteLine("december");
                            break;
                        case 11:
                            Console.WriteLine("november");
                            break;
                        case 10:
                            Console.WriteLine("oktober");
                            break;
                        case 9:
                            Console.WriteLine("september");
                            break;
                        case 8:
                            Console.WriteLine("augustus");
                            break;
                        case 7:
                            Console.WriteLine("juli");
                            break;
                        case 6:
                            Console.WriteLine("juni");
                            break;
                        case 5:
                            Console.WriteLine("mei");
                            break;
                        case 4:
                            Console.WriteLine("april");
                            break;
                        case 3:
                            Console.WriteLine("maart");
                            break;
                        case 2:
                            Console.WriteLine("februari");
                            break;
                        default:
                            Console.WriteLine("januari");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Crazy input");
                }
            }
            else
            {
                Console.WriteLine("Crazy input");
            }
        }
    }
}

