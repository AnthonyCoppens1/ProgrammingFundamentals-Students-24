using System;

namespace Week12_OO_Roster_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher Anthony = new Teacher("Anthony Coppens", new DateOnly(1995, 07, 31));
            Course PF = new Course("Programming Fundamentels", Anthony, "C2.23", 4,
                new TimeOnly(13, 45), Days.Wednesday);

            Teacher Bilal = new Teacher("Bilal Ozden", new DateOnly(1999, 09, 09));
            Course Databases = new Course("Databases", Bilal, "C2.15", 3, new TimeOnly(9, 30), Days.Monday);

            Course CF = new Course("Computing Fundamentals", Anthony, "C2.02", 2, new TimeOnly(13, 45), Days.Monday);

            Student JeanPhillip = new Student("Jean-Phillip Le Coquille", new DateOnly(2002, 09, 09), new List<Course> { PF, Databases, CF });

            Console.WriteLine(JeanPhillip);


        }
    }
}
