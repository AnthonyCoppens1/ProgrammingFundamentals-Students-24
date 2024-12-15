using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Ziekenhuis_ADI
{
    public class Persoon
    {
        public string Naam { get; set; }
        private long Rijksregisternummer { get; set; }
        private DateOnly Geboortedatum { get; set; }
        public string Bloedgroep { get; set; }
        public string Rol { get; set; }

        public Persoon() //constructor
        {
            Naam = "Sinan De Wever";
            Rijksregisternummer = 48930711120;
            Geboortedatum = new DateOnly(2002, 11, 17);
            Bloedgroep = "A+";
            Rol = "Patient";
        }

        public Persoon(string naam, long rijk, DateOnly geb, string bg, string rol)
        {
            Naam = naam;
            Rijksregisternummer = rijk;
            Geboortedatum = geb;
            Bloedgroep = bg;
            Rol = rol;
        }

        public Persoon(string naam, DateOnly geboortedatum)
        {
            Naam = naam;
            Geboortedatum = geboortedatum;
        }

        public override string ToString() => $"{Naam} is een {Rol}";
       
    }


    public class Patient : Persoon
    {
        public string Probleem { get; set; }
        public string Behandeling { get; set; }

        public Patient(string naam, DateOnly geboortedatum, string probleem) : base(naam,geboortedatum) 
        {
            Probleem = probleem;
            Behandeling = "GEEN, DIKKE PECH";
        }

        public override string ToString()
        {
            return $"{Naam} - {Probleem} - {Behandeling}";
        }
        //public override string ToString() => $"{Naam} - {Probleem} - {Behandeling}";
    }

    public enum Specialisatie
    {
        GeenIdee,
        Voeten,
        Dermatologie,
        Neurologie,
        Radiologie,
        Cardiologie,
        PlastischeChirurgie
    }


    public class Dokter : Persoon
    {
        public Specialisatie SP { get; set; }

        public Dokter(string naam, DateOnly geboortedatum, Specialisatie specialisatie) : base(naam,geboortedatum)
        {
            SP = specialisatie;
        }

        public override string ToString()
        {
            return $"{Naam} - {SP}";
        }
        //public override string ToString() => $"{Naam} - {Specialisatie}";
    }


    public class Ziekenhuis
    {
        public string Naam { get; set; }

        public List<Persoon> Personen { get; private set; }

        public Ziekenhuis(string naam)
        {
            Naam = naam;
            Personen = new List<Persoon>();
        }

        public Ziekenhuis(string naam, List<Persoon> personen)
        {
            Naam = naam;
            Personen = personen;
        }

        public void VoegPersoonToe(Persoon p)
        {
            Personen.Add(p);
        }

        public List<Patient> ZoekPatienten()
        {
            List<Patient> Patienten = new List<Patient>();
            foreach (Persoon p in Personen) //IEDERE PERSOON IN ORIGINELE LIJST
            {
                if (p is Patient)
                {
                    Patienten.Add((Patient)p);
                }
            }
            return Patienten;
        }

        public List<Dokter> ZoekDokters()
        {
            List<Dokter> Dokters = new List<Dokter>();
            foreach (Persoon p in Personen) //IEDERE PERSOON IN ORIGINELE LIJST
            {
                if (p is Dokter)
                {
                    Dokters.Add((Dokter)p);
                }
            }
            return Dokters;
        }

        public override string ToString()
        {
            string s = $"ZIEKENHUIS: {Naam}\n";

            foreach (Persoon p in Personen)
            {
                s += $"- {p}\n";
            }
            return s;
        }


    }
}
