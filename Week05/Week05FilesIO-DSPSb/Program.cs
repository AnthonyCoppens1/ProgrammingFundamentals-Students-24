using System;
using System.IO;

namespace Week05FilesIO_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writing files
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("This is a test file"); //write text and open a new line
            stream.Write("Hello"); //write text and NOT open new line
            stream.Write(" my name is Anthony");
            stream.Close();


            //lets's make text files in different locations
            //folder 'test' has to exist on c-drive to run and create this file
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("text file in different location");
            stream.Close();


            //create a file on a special folder (eg desktop, images, downloads, ...)
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopFolder, "file.txt");
            stream = File.CreateText(path);
            stream.WriteLine("HELLO");
            stream.Close();
            
            if (File.Exists(path)) //check if file exists on desktop
            {
                stream = File.AppendText(path);
                stream.WriteLine("Testing more text");
                stream.WriteLine("EVEN MORE!");
                stream.Close();
            }


            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("TEST");
                stream.Close();
            }


            //deleting files from a certain folder
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string PathToMusic = Path.Combine(musicFolder, "fileThatShouldntBeHere.txt");
            stream = File.CreateText(PathToMusic);
            stream.Close();

            if (File.Exists(PathToMusic))
            {
                File.Delete(PathToMusic);
            }


            //imagine file doesn't exist yet, create it and write to it.
            if (!File.Exists("file.txt"))
            {
                stream = File.CreateText("file.txt");
                stream.WriteLine("This is a test file"); //write text and open a new line
                stream.Write("Hello"); //write text and NOT open new line
                stream.Write(" my name is Anthony");
                stream.Close();
            }



        }
    }
}
