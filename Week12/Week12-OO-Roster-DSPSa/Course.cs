using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_Roster_DSPSa
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Teacher
    {
        public string Name { get; set; }
        public DateOnly Birthday { get; set; }

        public Teacher(string name, DateOnly birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }

    public class Student : Teacher
    {
        public List<Course> Courses { get; set; }

        public Student(string name, DateOnly birthday, List<Course> courses) : base(name, birthday)
        {
            Courses = courses;
        }

        public override string ToString()
        {
            string s = $"Hello dearest student {Name} who happens to be born on {Birthday}\n";
            foreach (var course in Courses)
            {
                s += $"{course}\n\n";
            }

            return s;

        }
    }


    public class Course
    {
        public string Name { get; set; }
        public Teacher Lector { get; set; }
        public string Room { get; set; }
        public int Duration { get; set; }
        public TimeOnly StartTime { get; set; }
        public Days DayOfWeek { get; set; }
        public TimeOnly EndTime { get; set; }

        public Course(string name, Teacher lector, string room, int duration, 
            TimeOnly starttime, Days dayofweek)
        {
            Name = name; Lector = lector; Room = room; Duration = duration;
            StartTime = starttime; DayOfWeek = dayofweek;

            EndTime = starttime.AddHours(duration);
        }

        public override string ToString()
        {
            string s = $"{Name}\n";
            s += $"- Day: {DayOfWeek}\n";
            s += $"- Starts at: {StartTime}\n";
            s += $"- Ends after {Duration} hours at: {EndTime}\n";
            s += $"- Taught by: {Lector}\n";
            s += $"- In room: {Room}\n";
            return s;
        }

    }
}
