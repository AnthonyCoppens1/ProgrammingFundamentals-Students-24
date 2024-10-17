using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace _05FilesIO_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //files aanmaken
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("Dit is een tekst file."); //schrijft tekst, opent nieuwe lijn
            stream.Write("Hallo"); //schrijft tekst, geen nieuwe lijn
            stream.Write(" Mijn naam is Anthony");
            stream.Close();

            //files op andere locaties
            stream = File.CreateText(@"C:\test\file.txt");
            stream.WriteLine("tekst file in mijn andere locatie.");
            stream.Close();


            //file op desktop
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // desktopfolder is een string van pad naar desktop
            string path = Path.Combine(desktopFolder, "file.txt");
            stream = File.CreateText(path);
            stream.WriteLine("TEST OP HET BUREAUBLAD");
            stream.Close();

            if (File.Exists(path)) //checkt of file bestaat op bureaublad (file.txt)
            {
                stream = File.AppendText(path); //tekst toevoegen aan bestaande tekst in file
                stream.WriteLine("Nog meer testen");
                stream.WriteLine("NOG MEER");
                stream.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("HALLOOOO");
                stream.Close();
            }


            string muziekFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string padVanMuziek = Path.Combine(muziekFolder, "file.txt");
            stream = File.CreateText(padVanMuziek);
            stream.WriteLine("TEST");
            stream.Close();

        
            if (File.Exists(padVanMuziek))
            {
                File.Delete(padVanMuziek);
            }
        }
    }
}
