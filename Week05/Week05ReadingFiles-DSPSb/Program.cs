using System;
using System.IO;

namespace Week05ReadingFiles_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //opening a text file and reading through it
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);


            //print the content of the file again
            //reading through it line by line
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream) //as long as we have not reached the end of stream
            {
                /*string line = input.ReadLine();
                Console.WriteLine("-->" + line);*/

                Console.WriteLine("-->" + input.ReadLine());
            }
            input.Close();


            //read through text file char by char and add blank space
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //reading through file line by line
            //version foreach

            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("+=+" + item);
            }


            //reading through file char by char
            //version foreach
            foreach (char c in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write("-" + c);
            }
        }
    }
}
