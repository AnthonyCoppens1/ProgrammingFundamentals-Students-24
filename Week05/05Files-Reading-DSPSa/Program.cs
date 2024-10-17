using System;
using System.IO;

namespace _05Files_Reading_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open text file and read through the whole thing. either 
            //print out text then close or close then print
            //NO CONSOLE.WRITELINE or WRITE!!! --> WE DONT SEE ANYTHING

            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);



            Console.WriteLine();
            //start to print doc again
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.WriteLine("->" + input.ReadLine());

                //string line = input.ReadLine();
                //Console.WriteLine(line);
            }
            input.Close();



            Console.WriteLine();
            //reading through a text char by char and we'll add a blank space behind each
            //with a WHILE
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //foreach --> read through text
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("-->+" + item);
            }

            
            //foreach --> char by char
            foreach (char character in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(character + "-");
            }
        }
    }
}
