using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_Lesrooster_ADI
{
    public enum WeekDag
    {
        Maandag = 0,
        Dinsdag = 1,
        Woensdag = 2,
        Donderdag = 3,
        Vrijdag = 4,
        Zaterdag = 5,
        Zondag = 6
    }
    
    public class Vak
    {
        //naam, docent, lokaal, duur, weekdag, startuur
        public string Naam { get; set; }
        public Docent Lector { get; set; }
        public string Lokaal { get; set; }
        public int Duur { get; set; }
        public WeekDag Dag { get; set; }
        public Tijd Startuur { get; set; }

        public Vak(string naam, Docent lector, string lokaal, int duur,
            WeekDag dag, Tijd startuur)
        {
            Naam = naam;
            Lector = lector;
            Lokaal = lokaal;
            Duur = duur;
            Dag = dag;
            Startuur = startuur;
        }

        public override string ToString()
        {
            string s = "";
            s += $"Vak: {Naam}\n";
            s += $"- docent: {Lector.Naam}\n";
            s += $"- lokaal: {Lokaal}\n";
            s += $"- dag: {Dag}\n";

            Tijd Einduur = new Tijd(Startuur, Duur);

            s += $"- lestijden: {Startuur} --> {Einduur}\n";
            return s;

        }

    }

    public class Docent
    {
        public string Naam { get; set; }
        public DateOnly Geboortedatum { get; set; }

        public Docent(string naam, DateOnly geboortedatum)
        {
            Naam = naam;
            Geboortedatum = geboortedatum;
        }

        public void Print()
        {
            Console.WriteLine($"Hallo meneer/mevrouw {Naam}");
        }
    }

    public class Tijd
    {
        int UU;
        int MM;

        public int Uren //PROPERTY
        {
            get { return UU;  }
            set
            {
                if ((value >= 0) && (value <= 23))
                {
                    UU = value;
                }
            }
        }

        public int Minuten //PROPERTY
        {
            get { return MM; }
            set
            {
                if ((value >= 0) && (value <= 59))
                {
                    MM = value;
                }
            }
        }

        public Tijd(int u, int m)
        {
            Uren = u;
            Minuten = m;
        }

        public Tijd(Tijd t, int voegToe)
        {
            Uren = t.Uren + voegToe;
            Minuten = t.Minuten;
        }

        public override string ToString()
        {
            return $"{Uren}:{Minuten}";
        }

    }

    public class Student : Docent
    {
        public Vak[] Vakken { get; set; }
        public Student(string naam, DateOnly geboortedatum, Vak[] vakken) : base(naam, geboortedatum)
        {
            Vakken = vakken;
        }

        public override string ToString()
        {
            string s = $"Hallo beste student-kameraad: {Naam}, die blijkbaar " +
                $"geboren is op {Geboortedatum}, leuk voor jou! Hier is je rooster!\n";

            foreach (var vak in Vakken)
            {
                s += $"{vak}\n";
            }

            return s;

        }

    }





}
