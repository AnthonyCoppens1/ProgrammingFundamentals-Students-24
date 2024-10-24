using System;
using System.IO;
using System.Xml.Schema;

namespace Week06HerhalingFiles_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*file inlezen, lijn per lijn en dan de gebruiker gebruiker laten kiezen hoeveel lijnen
             * we lezen en uiteindelijk overschrijven naar een nieuwe file in format Harry-502.txt*/

            int amount = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            StreamWriter sr = File.CreateText($"Harry-{amount}.txt");
            

            foreach (string lijn in File.ReadLines(@"Harry Potter and the Sorcerer.txt"))
            {
                if (counter <= amount)
                {
                    sr.WriteLine(counter + " " + lijn);
                    counter++;
                    
                }
                else break; //meest innerlijke loop wordt met break; vroegtijdig gestopt
            }

            sr.Close();


            //optie 2
            StreamWriter schrijf = File.CreateText($"Harry-{amount}-optie2.txt");
            StreamReader lees = File.OpenText(@"Harry Potter and the Sorcerer.txt");

            counter = 0;

            while (counter <= amount)
            {
                schrijf.WriteLine(counter + " " + lees.ReadLine());
                counter++;
            }

            lees.Close();
            schrijf.Close();



        }
    }
}
