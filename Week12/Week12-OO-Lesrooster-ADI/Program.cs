namespace Week12_OO_Lesrooster_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docent Collin = new Docent("Collin Van der Vorst", new DateOnly(1991, 04, 16));
            Docent Anthony = new Docent("Anthony Coppens", new DateOnly(1995, 07, 31));
            Docent Elke = new Docent("Elke Boonen", new DateOnly(1980, 04, 23));
            
            Vak PF = new Vak("Programming Fundamentals", Anthony, "T 2.09", 4,
                WeekDag.Donderdag, new Tijd(8, 30));
            Vak Web = new Vak("Web", Collin, "C 3.08", 2,
                WeekDag.Donderdag, new Tijd(4,0));
            Vak PA = new Vak("Programming Advanced", Elke, "C 1.24", 3,
                WeekDag.Vrijdag, new Tijd(13,45));

            Vak[] vakken = { PF, Web, PA };

            Student Anass = new Student("Anass", new DateOnly(2002, 08, 18), vakken);
            Console.WriteLine(Anass);
        }
    }
}
