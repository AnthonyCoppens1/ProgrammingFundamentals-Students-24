using System;

namespace _02Variables_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //variables in different cases
            //whole numbers --> integers
            //strings and decimals

            string name = "Anthony";
            name = "something else";
            Console.WriteLine(name);

            char c = 'A';
            Console.WriteLine(c);

            int x, y; //declaring
            x = 5; //initialization
            y = 8;

            Console.WriteLine(x);

            byte b = 12;
            // b = 256;  --> limit min 0 max 255

            short s = 789;

            double doubleNumber = 45.897672;
            float floatNumber = 45.123f;

            doubleNumber = doubleNumber + floatNumber;
            Console.WriteLine(doubleNumber);
            Console.WriteLine(floatNumber);

            Console.WriteLine(name);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(y);


            //calculations with x and y
            //starting point of x and y
            Console.WriteLine();
            Console.WriteLine($"x = {x} and y = {y}");

            //addition and subtraction
            x++; //x = x + 1
            Console.WriteLine($"x = {x}");
            --x;
            Console.WriteLine($"x = {x}");

            //postfix and prefix
            Console.WriteLine($"x++ results in {x++}"); //5
            Console.WriteLine($"++x results in {++x}"); //7
            Console.WriteLine($"x-- results in {x--}"); //7
            Console.WriteLine(x);
            Console.WriteLine($"--x results in {--x}"); //5


            //arithmetic operator
            Console.WriteLine();
            Console.WriteLine($"x = {x} and y = {y}");

            Console.WriteLine($"x + y = {x + y}"); //13
            Console.WriteLine($"x - y = {x - y}"); //-3
            Console.WriteLine($"x * y = {x * y}"); //40
            Console.WriteLine($"x / y = {x / y}"); //0
            //--> division between 2 integers --> removes everything past decimal point (ignores rounding)
            Console.WriteLine($"5.0 / y = {5.0 / y}"); //0.625

            //modulo --> remainder after whole division
            Console.WriteLine($"10 % 9 = {10 % 9}"); //1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //2
            Console.WriteLine($"10 % 7 = {10 % 7}"); //3
            Console.WriteLine($"10 % 5 = {10 % 5}"); //0
            Console.WriteLine($"10 % 3 = {10 % 3}"); //1
            Console.WriteLine($"10 % 2 = {10 % 2}"); //0


            //modulo without % operator
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");


            //compound operator
            Console.WriteLine();
            Console.WriteLine($"x = {x}"); //5
            x += 10; //x = x + 10
            Console.WriteLine($"x = {x}"); //15
            x -= 7; //x = x - 7
            Console.WriteLine($"x = {x}"); //8
            x *= 4;
            Console.WriteLine($"x = {x}"); //32
            x /= 3;
            Console.WriteLine($"x = {x}"); //10
            x %= 5;
            Console.WriteLine($"x = {x}"); //0

            //compound operators with strings
            name = "Muniba";
            name += " Jahir"; //added behind
            Console.WriteLine(name);

            name = "Muniba";
            name = "Jahir " + name; //added up front
            Console.WriteLine(name);


            //comparisson operators
            Console.WriteLine($"x = {x} and y = {y}");
            Console.WriteLine($"x < y --> {x < y}"); //True
            Console.WriteLine($"x > y --> {x > y}"); //False
            Console.WriteLine($"x <= y --> {x <= y}"); //True
            Console.WriteLine($"x >= y --> {x >= y}"); //False
            Console.WriteLine($"x == y --> {x == y}"); //False
            Console.WriteLine($"x != y --> {x != y}"); //True

            //5.0 --> 5
            Console.WriteLine($"5.0 == 5 --> {5.0 == 5}"); //True
            Console.WriteLine();

            //VERY WEIRD STUFF! PAY ATTENTION!
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); //ascii value of '5' = 53 in decimal --> 53+5 = 58
            Console.WriteLine('a' + 10); //107
            Console.WriteLine('5' + '5'); //106
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); //10 --> () required to make calculation first

            Console.WriteLine('a' + 'b' + 'c'); //294


            //characters in a string
            //first character
            name = "Elizabeth";
            char firstChar = name[0];
            Console.WriteLine($"First character of {name} is {firstChar}");

            firstChar = name.ElementAt(0);
            Console.WriteLine($"First character of {name} is {firstChar}");


            //last character
            char lastChar = name[^1];
            Console.WriteLine($"Last character of {name} is {lastChar}");

            lastChar = name[name.Length - 1];
            Console.WriteLine($"Last character of {name} is {lastChar}");

            lastChar = name.ElementAt(^1);
            Console.WriteLine($"Last character of {name} is {lastChar}");

            lastChar = name.ElementAt(name.Length - 1);
            Console.WriteLine($"Last character of {name} is {lastChar}");


            //check if a number is > 10 and < 100 / next check if result after /10 >=1 and <= 10
            //lastly result after modulo --> < 100 and > 10

            int number = 96;
            Console.WriteLine(number > 10 && number < 100); //True
            int result = number / 10;
            Console.WriteLine(result >= 1 && result <= 10); //True
            int resultModulo100 = 100 % number;
            Console.WriteLine(resultModulo100 < 100 &&  resultModulo100 > 10); //False  
        }
    }
}
