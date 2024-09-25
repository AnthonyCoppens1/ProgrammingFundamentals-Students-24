using System;

namespace _02Variables_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            //declaring datatypes
            //strings
            string name = "Anthony";
            name = "something else";
            Console.WriteLine(name);

            //characters
            char c = 'a';
            Console.WriteLine(c);

            //numbers
            int x, y; //declaring numbers of the same datatype
            x = 5; //initialization --> giving it a value
            y = 8;

            short num = 9087;

            byte numberByte = 12;
            //numberByte = 256; --> not possible, max value is 255


            //decimal numbers
            double numberDouble = 45.897676352;
            //float numberFloat = numberDouble;  --> not enough space

            float numberFloat = 45.876f; //needs f to create a float

            Console.WriteLine(name);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberDouble);
            Console.WriteLine(numberFloat);
            Console.WriteLine(c);


            Console.WriteLine($"x = {x} and y = {y}"); //x = 5 and y = 8
            //addition and subtraction

            Console.WriteLine("x = " + x);
            x++; //x = x + 1
            Console.WriteLine("x = " + x);
            --x; //x = x - 1
            Console.WriteLine("x = " + x);


            //postfix and prefex
            Console.WriteLine($"x++ results in {x++}"); //postfix --> print first then calculate
            Console.WriteLine($"++x results in {++x}"); //prefix --> calculate first then print

            Console.WriteLine($"x-- results in {x--}");
            Console.WriteLine($"--x results in {--x}");


            //arthmetic operators
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}"); //integer division = no decimal part
            Console.WriteLine($"{5.0} / {y} = {5.0 / y}");
            Console.WriteLine($"{numberDouble / y}");


            //modulo --> remainder after division
            Console.WriteLine($"10 % 9 = {10 % 9}"); //10/9 = 1 + remainder = 1
            Console.WriteLine($"10 % 8 = {10 % 8}"); //10/8 = 1 + remainder = 2
            Console.WriteLine($"10 % 7 = {10 % 7}"); //10/7 = 1 + remainder = 3
            Console.WriteLine($"10 % 5 = {10 % 5}"); //10/5 = 2 + remainder = 0
            Console.WriteLine($"10 % 2 = {10 % 2}"); //10/2 = 5 + remainder = 0
            Console.WriteLine($"10 % 1 = {10 % 1}"); //10/1 = 10 + remainder = 0

            //modulo without % operator
            int resultAfterDivision = 10 / 3;
            Console.WriteLine($"10 % 3 = {10 - (resultAfterDivision * 3)}");

            //compound operators
            Console.WriteLine($"x starts at {x}"); //starting point
            x += 10;
            Console.WriteLine($"x += 10 --> {x}");
            x -= 7;
            Console.WriteLine($"x -= 7 --> {x}");
            x *= 4;
            Console.WriteLine($"x *= 4 --> {x}");
            x /= 3;
            Console.WriteLine($"x /= 3 --> {x}");
            x %= 5;
            Console.WriteLine($"x %= 5 --> {x}");


            //text based compound operators --> strings
            name = "Muniba";
            name += " Jahir";
            Console.WriteLine(name);

            name = "Muniba";
            name = "Jahir" + name; //only way to add up front
            Console.WriteLine(name);


            //comparisson operators
            x = 3;
            double z = 3.0;

            Console.WriteLine($"x {x} y {y}");
            Console.WriteLine($"x < y --> {x < y}");
            Console.WriteLine($"x > y --> {x > y}");
            Console.WriteLine($"x <= y --> {x <= y}");
            Console.WriteLine($"x >= y --> {x >= y}");
            Console.WriteLine($"x == y --> {x == y}");

            Console.WriteLine($"x != y --> {x != y}");
            Console.WriteLine($"z != x --> {z != x}");


            //weird things --> ATTENTION!
            Console.WriteLine(5 + 5); //10
            Console.WriteLine("5" + 5); //55
            Console.WriteLine('5' + 5); // 58 --> ascii decimal number for 5 is 53!
            Console.WriteLine('a' + 5); // 102 --> 97 + 5
            Console.WriteLine("" + 5 + 5); //55
            Console.WriteLine("" + (5 + 5)); // 10


            //characters in strings
            name = "Elisabeth";
            char firstChar = name[0];
            Console.WriteLine($"First character of {name} is {firstChar}");

            firstChar = name.ElementAt(0);
            Console.WriteLine($"First character of {name} is {firstChar}");

            char lastChar = name[name.Length - 1];
            Console.WriteLine($"Last character of {name} is {lastChar}");


            //check if a number is > 10 and < 100
            int number = 90;
            Console.WriteLine(number > 10 && number < 100); //combining multiple conditions using && or AND
            
            int result = number / 10;
            Console.WriteLine(result >= 1 && result <= 10);

            int resultModulo100 = 100 % number;
            Console.WriteLine(resultModulo100 < 100 && resultModulo100 > 10);





















        }
    }
}
