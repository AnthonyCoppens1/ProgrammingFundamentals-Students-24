﻿using System;

namespace Week11_OO_Ziekenhuis_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dokter Noa = new Dokter("Noa Lebegge", new DateOnly(2005, 06, 28), Specialisatie.GeenIdee);
            Patient Anthony = new Patient("Anthony Coppens", new DateOnly(1995, 07, 31), "Drankverslaving");
            Patient Elke = new Patient("Elke Boonen", new DateOnly(1980, 04, 23), "Intoxicatie dmv Gin");
            Dokter Collin = new Dokter("Collin Van der Vorst", new DateOnly(1991, 04, 16), Specialisatie.Voeten);

            Console.WriteLine(Collin.Naam);
            Console.WriteLine($"Elke: {Elke.Rol}: {Elke.Bloedgroep}");
            Console.WriteLine(Anthony.Naam + " " + Noa.Naam);
            
            /*Jamey.Naam = "Bart De Wever";
            Console.WriteLine(Jamey.Naam);*/

            Console.WriteLine(Anthony);

            Patient Yorbe = new Patient("Yorbe", new DateOnly(2005, 12, 07), "Snus");
            Console.WriteLine(Yorbe.Probleem);

            List<Patient> patienten = new List<Patient>();
            patienten.Add(Anthony);
            patienten.Add(Elke);
            patienten.Add(Yorbe);

            foreach (var patient in patienten)
            {
                Console.Write(patient);
                foreach (var probleem in patient.Probleem)
                {
                    Console.Write(probleem);
                }
                Console.WriteLine();
            }

            List<Persoon> mensen = new List<Persoon>();
            mensen.Add(Anthony);
            mensen.Add(Elke);
            mensen.Add(Collin);
            mensen.Add(Yorbe);
            mensen.Add(Noa);


            Ziekenhuis AZSintMaarten = new Ziekenhuis("AZ Sint-Maarten", mensen);
            Dokter Bea = new Dokter("Bea", new DateOnly(1975, 11, 12), Specialisatie.Dermatologie);
            AZSintMaarten.VoegPersoonToe(Bea);

            Console.WriteLine(AZSintMaarten);
            


        }
    }
}
