using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions; //required for REGEX

namespace Week06RecapFiles_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*write a program that checks the original file line by line
             * Count lines and if the count exceeds the given amount of lines
             * it stops copying the lines from the original file. 
             Write the lines to a new file*/

            int lines = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            StreamWriter sw = File.CreateText($"Harry-{lines}.txt");
            foreach (string line in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (count <= lines)
                {
                    sw.WriteLine(count + " " + line);
                    count++;
                }
                else
                {
                    break;
                }
            }
            sw.Close();

            //option 2 - same code as above but with a while
            count = 0;

            StreamReader read = File.OpenText(@"Harry Potter and the Sorcerer.txt");
            StreamWriter write = File.CreateText($"Harry-{lines}-option2.txt");

            while (count <= lines)
            {
                write.WriteLine(count + " " + read.ReadLine());
                count++;
            }

            read.Close();
            write.Close();


        }
    }
}
