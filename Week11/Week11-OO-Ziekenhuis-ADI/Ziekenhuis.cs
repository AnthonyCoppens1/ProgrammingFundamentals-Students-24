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
            return $"{Naam} - {Probleem} - {Behandeling}: ";
        }
        //public override string ToString() => $"{Naam} - {Probleem} - {Behandeling}";
    }

    public class Dokter : Persoon
    {
        public string Specialisatie { get; set; }

        public Dokter(string naam, DateOnly geboortedatum, string specialisatie) : base(naam,geboortedatum)
        {
            Specialisatie = specialisatie;
        }

        public override string ToString()
        {
            return $"{Naam} - {Specialisatie}";
        }
        //public override string ToString() => $"{Naam} - {Specialisatie}";
    }
}
