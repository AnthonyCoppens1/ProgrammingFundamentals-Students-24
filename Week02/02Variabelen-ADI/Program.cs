using System;

namespace _02Variabelen_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //werken rond variabelen
            //declareren ervan
            //strings en characters
            string naam = "Muniba";
            naam = "iets anders";
            Console.WriteLine(naam);

            char c = 'a';
            Console.WriteLine(c);


            //getallen
            int x, y; //declareren
            x = 5;
            y = 8;
            Console.WriteLine(x);

            byte nummerByte = 12;
            //nummerByte = 256; --> max waarde 255, min waarde 0

            short nummerShort = 12000;

            long l = 29487329487329474;

            //kommagetallen
            double nummerDouble = 45.89673467; //max 15 getallen na komma
            float f = 45.32f;

            Console.WriteLine(naam);
            Console.WriteLine(c);
            Console.WriteLine(nummerByte);
            Console.WriteLine(nummerShort);
            Console.WriteLine(nummerDouble);
            Console.WriteLine(f);
            Console.WriteLine(l);


            //optellen en aftrekken ++ en --
            Console.WriteLine($"x = {x} en y = {y}");
            Console.WriteLine();

            x++; //x = x + 1
            Console.WriteLine($"x = {x}");
            --x;
            Console.WriteLine($"x = {x}");

            //prefix en postfix
            Console.WriteLine($"x++ geeft als resultaat {x++}"); //5
            Console.WriteLine(x); //eigenlijk 6 maar we zien 5 op de vorige regel
            Console.WriteLine($"++x geeft als resultaat {++x}"); //7
            Console.WriteLine($"x-- geeft als resultaat {x--}");
            Console.WriteLine($"--x geeft als resultaat {--x}");

            Console.WriteLine();

            //arithmetic operators
            Console.WriteLine($"x = {x} y = {y}"); //x = 5 en y = 8
            Console.WriteLine($"x + y = {x + y}"); //13
            Console.WriteLine($"x - y = {x - y}"); //-3
            Console.WriteLine($"x * y = {x * y}"); //40
            Console.WriteLine($"x / y = {x / y}"); //0
            //--> 2 gehele getallen delen toont enkel getal voor de komma, negeert afronding
            Console.WriteLine($"5.0 / y = {5.0 / y}"); //0.625

            //modulo
            Console.WriteLine($"10 % 9 = {10 % 9}"); //1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //2
            Console.WriteLine($"10 % 5 = {10 % 5}"); //0
            Console.WriteLine($"10 % 3 = {10 % 3}"); //1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //0
            Console.WriteLine($"10 % 1 = {10 % 1}"); //0

            //modulo zonder % operator
            int resultaatNaDeling = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultaatNaDeling * 3)}");


            //compound operators voor getallen
            Console.WriteLine("x start op " + x); //startpunt

            x += 10; //15
            Console.WriteLine($"x += 10 --> {x}");

            x -= 7; //8
            Console.WriteLine($"x -= 7 --> {x}");

            x *= 4; //32
            Console.WriteLine($"x *= 4 --> {x}");

            x /= 3; //10 --> 32/10 = 3.2 --> integer deling dus na komma negeren
            Console.WriteLine($"x /= 3 --> {x}");

            x %= 5; //0
            Console.WriteLine($"x %= 5 --> {x}");


            //compound operators --> strings
            naam = "Muniba ";
            naam += "Jahir"; //achteraan toegevoegd
            Console.WriteLine(naam);

            naam = "Muniba";
            naam = "Jahir " + naam;
            Console.WriteLine(naam);


            //vergelijkingsoperatoren (comparisson operators)
            Console.WriteLine($"x = {x} en y = {y}"); // x = 0 en y = 8
            Console.WriteLine($"x < y --> {x < y}"); //True
            Console.WriteLine($"x > y --> {x > y}"); //False
            Console.WriteLine($"x <= y --> {x <= y}"); //True
            Console.WriteLine($"x >= y --> {x >= y}"); //False
            Console.WriteLine($"x == y --> {x == y}"); //False
            Console.WriteLine($"x != y --> {x != y}"); //True


            //Rare toestanden!!! OPGELET
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //58 --> ascii waarde van '5' als symbool/cijfer = 53 
            Console.WriteLine('a' + 5); //102 --> decimale waarde van 'a' = 97 --> + 5 = 102
            Console.WriteLine('a' + 'b' + 'c'); //294 --> telt ascii decimale waarden op ipv 'abc' te tonen
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); //10 --> voor bewerking haakjes noodzakelijk


            //characters in strings
            naam = "Elisabeth";
            char eersteChar = naam[0];
            Console.WriteLine($"Eerste character van {naam} is {eersteChar}");

            eersteChar = naam.ElementAt(0);
            Console.WriteLine($"Eerste character van {naam} is {eersteChar}");

            char laatsteChar = naam[naam.Length-1];
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");

            laatsteChar = naam[^1];
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");

            laatsteChar = naam.ElementAt(^1);
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");

            laatsteChar = naam.ElementAt(naam.Length - 1);
            Console.WriteLine($"Laatste character van {naam} is {laatsteChar}");


            //voorwaarde controleren zonder IF
            //controleren of een getal > 10 en < 100 --> resultaat >= 1 en <= 10 als laatste of modulo < 100 en > 10

            int getal = 12;
            Console.WriteLine(getal > 10 && getal < 100); //True

            int resultaat = getal / 10;
            Console.WriteLine(resultaat >= 1 && resultaat <= 10); //True

            int resultaatNaModulo = 100 % getal;
            Console.WriteLine(resultaatNaModulo);
            Console.WriteLine(resultaatNaModulo < 100 && resultaatNaModulo > 10); //False --> niet groter dan 10




        }
    }
}
