using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_Roster_DSPSb
{
    public class Course
    {
        public string Name { get; set; }
        public Time StartTime { get; set; }
        public int Duration { get; set; }
        public string Room { get; set; }
        public Teacher Lector { get; set; }
        public Week DayOfWeek { get; set; }


        public Course(string name, Time starttime, int duration, string room, 
            Teacher lector,Week dayofweek)
        {
            Name = name;
            StartTime = starttime;
            Duration = duration;
            Room = room;
            Lector = lector;
            DayOfWeek = dayofweek;
        }

        //name, lector, day, starttime, endtime, room
        public override string ToString()
        {
            string s = $"COUSE: {Name}\n";
            s += $"This class is taught by {Lector.Name}\n";
            s += $"You have it on {DayOfWeek}\n";

            Time EndTime = new Time(StartTime, Duration);

            s += $"It starts at {StartTime} and ends at {EndTime}\n";
            s += $"In room: {Room}\n\n";

            return s;
        }

    }

    public enum Week
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
            return $"Hello lovely sir {Name} who is apparently born on {Birthday}";
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
            string s = $"Hello dearest amazing student with the name: {Name}\n" +
                $"This is your roster:\n";
            
            foreach(var course in Courses)
            {
                s += $"{course}";
            }

            return s;

        }
    }


    public class Time
    {
        int HH;
        int MM;

        //property for hours
        public int Hours 
        {
            get
            {
                return HH;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    HH = value;
                }
            } 
        
        }

        //property for minutes
        public int Minutes
        {
            get
            {
                return MM;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    MM = value;
                }
            }
        }

        //constructor for Time --> starttime
        public Time(int h, int m)
        {
            Hours = h;
            Minutes = m;
        }

        //constructor for Time --> endtime
        public Time(Time start, int duration)
        {
            Hours = start.Hours + duration;
            Minutes = start.Minutes;
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}";
        }

    }


}
