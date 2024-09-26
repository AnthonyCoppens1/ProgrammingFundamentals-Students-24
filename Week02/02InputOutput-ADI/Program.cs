using System;

namespace _02InputOutput_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input en output
            //omzetten van datatypes
            Console.Write("Geef een naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine(naam);

            //omzettingen
            Console.Write("Geef een getal: ");
            string antwoord = Console.ReadLine();
            int getal = Convert.ToInt32(antwoord);
            Console.WriteLine(getal);

            //input conversion
            Console.Write("Geef een getal: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(g);

            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(b);

            short s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(s);

            //byte = byte / short = int16 / int = int32 / long = int64

            //impliciete en expliciete omzetting
            Console.WriteLine(s); //impliciet --> vanzelf
            Console.WriteLine(s.ToString()); //expliciet --> forceren
            Console.WriteLine(Convert.ToString(s));

            
            Console.WriteLine();
            //characters
            Console.Write("Geef een character: ");
            antwoord = Console.ReadLine();
            char c = Convert.ToChar(antwoord);
            Console.WriteLine(c);
            Console.WriteLine((int)c); //ascii waarde

            //int naamNaarGetal = (int)naam; --> werkt nooit
            //int stringGetal = (int)"89"; --> werkt ook nooit

            getal = (int)78.3456;
            Console.WriteLine(getal);
            double doubleGetal = (double)78;
            Console.WriteLine(doubleGetal);

        }
    }
}
