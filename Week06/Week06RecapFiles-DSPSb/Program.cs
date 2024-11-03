using System;
using System.IO;

namespace Week06RecapFiles_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*read the harry potter file line by line (in 2 ways)
             * user selects a number of lines and only those lines
             * will be transferred to a new file of format: Harry-5.txt*/

            int lines = Convert.ToInt32(Console.ReadLine());
            int counter = 1; //counter should start at 1 to be equal in lines to the file

            StreamWriter sw = File.CreateText($"Harry-{lines}.txt");

            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (counter <= lines)
                {
                    sw.WriteLine(counter + " " + line);
                    counter++;
                }
                else break;
            }
            sw.Close();


            //option 2 while
            counter = 1;
            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"Harry-{lines}-option2.txt");

            while (counter <= lines)
            {
                write.WriteLine(counter + " " + read.ReadLine());
                counter++;
            }

            read.Close();
            write.Close();
        }
    }
}
