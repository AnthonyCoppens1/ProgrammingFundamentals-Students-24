using System;

namespace Week12_OO_Roster_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher Anthony = new Teacher("Anthony Coppens", new DateOnly(1995, 07, 31));
            Teacher Marie = new Teacher("Marie Labuga", new DateOnly(1988, 02, 16));
            Teacher Bilal = new Teacher("Bilal Ozden", new DateOnly(1997, 05, 01));

            Course PF = new Course("Programming Fundamentals", new Time(10, 45), 4, "C 3.06",
                Anthony, Week.Friday);
            Course DigitalSkills = new Course("Digital Skills", new Time(8, 30), 3, "Z 2.09",
                Marie, Week.Thursday);
            Course Databases = new Course("Databases", new Time(13, 45), 3, "C 3.11",
                Bilal, Week.Monday);

            Student Pascal = new Student("Pascal", new DateOnly(2000, 12, 25),
                new List<Course> { PF, DigitalSkills, Databases });

            Console.WriteLine(Pascal);
        }
    }
}
