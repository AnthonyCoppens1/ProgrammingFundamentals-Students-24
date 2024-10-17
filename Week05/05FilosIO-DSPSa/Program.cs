using System;
using System.IO;

namespace _05FilosIO_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating files and let's see where they appear
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("This is a test file."); //writes text, opens new line
            stream.Write("Hello"); //writes text, no new line
            stream.Write(" My name is Anthony");
            stream.Close();

            //first make sure that "test" folder exists in your c-drive (or macintosh hd)
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("Test file in different locations: c drive");
            stream.Close();

            //create a file and it on desktop
            string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if you want a different folder then desktop, change into eg images, documents, ...
            string path = Path.Combine(desktopfolder, "file.txt");
            stream = File.CreateText(path);
            stream.WriteLine("Hello desktop");
            stream.Close();

            //check if file exists, append if it does
            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("Testing more text");
                stream.WriteLine("EVEN MORE!");
                stream.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("Hellooooo");
                stream.Close();
            }

            //deleting files --> deleting created file
            string musicFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string pathOfMusic = Path.Combine(musicFolder, "file.txt");
            stream = File.CreateText(pathOfMusic);
            stream.Close();

            if (File.Exists(pathOfMusic))
            {
                File.Delete(pathOfMusic);
            }
        }
    }
}
