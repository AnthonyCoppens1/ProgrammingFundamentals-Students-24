using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11OO_Persoon_ADI
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateOnly Geboortedatum { get; set; }
        public List<Huisdier> Huisdieren { get; set; } = new();

        public Persoon(string voornaam, string achternaam, DateOnly geboortedatum)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geboortedatum = geboortedatum;
        }

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam}";
        }
    }
    
    //Huisdier is een model voor eender welk type huisdier
    //indien abstract gemaakt, kunnen we geen huisdier aanmaken, wel een specifiek
    //huisdier
    //Duidelijk voorbeel van ABSTRACTION!!!

    public abstract class Huisdier
    {
        public string Voornaam { get; set; }
        public Huisdier(string voornaam)
        {
            Voornaam = voornaam;
        }

        public abstract string MaakGeluid();

        public override string ToString()
        {
            return $"{Voornaam} en ik ben een {GetType().Name}";
            //wanneer je konijn of kat aanmaakt, kent het vanzelf het type class
        }
    }

    public class Konijn : Huisdier //INHERITANCE
    {
        public Konijn(string voornaam) : base(voornaam)
        {
        }

        //MaakGeluid van Huisdier verplicht je om een MaakGeluid toe te voegen.
        //om dit correct te doen, moeten we de originele MaakGeluid van Huisdier overschrijven
        public override string MaakGeluid()
        {
            return "chuuu";
        }
        //of public string MaakGeluid() => "chuuu";
    }

    public class Kat : Huisdier
    {
        public Kat(string voornaam) : base(voornaam)
        {
        }

        public override string MaakGeluid() => "miauw";
    }
}
