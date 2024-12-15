using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Hospital_DSPSb
{
    public abstract class Person
    {
        public string Name { get; set; }
        private DateOnly Birthday { get; set; } //DateOnly, to only get date
        //if DateTime, but not provided a time, it is midnight (00:00:00)

        public Person()
        {
            Name = "Steve Jobs";
            Birthday = new DateOnly(2001, 01, 01);
        }

        public Person(string name, DateOnly birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - {Birthday}");
        }

        public override string ToString()
        {
            return $"{Name} is a {GetType().Name}";
        }
    }

    public class Patient : Person
    {
        public string Problem { get; set; }
        public string Treatment { get; set; }

        public Patient(string name, DateOnly birthday, string problem) : base(name, birthday)
        {
            Problem = problem;
            Treatment = "None, bad luck!";
        }

        public override string ToString()
        {
            return $"The problem of patient {Name}: {Problem}";
        }
    }

    public class Doctor : Person
    {
        public Spec Specialty { get; set; }

        public Doctor(string name, DateOnly birthday, Spec specialty) : base(name, birthday)
        {
            Specialty = specialty;
        }
        public override string ToString()
        {
            return $"Doctor {Name} is specialised in: {Specialty}";
        }
    }

    public enum Spec
    {
        Feet,
        Eyes,
        Teeth,
        Back,
        Hip,
        Cardiovascular,
        DisabledRappers
    }

    public class Nurse : Person
    {
        public Dep Department { get; set; }

        public Nurse(string name, DateOnly birthday, Dep department) : base(name, birthday)
        {
            Department = department;
        }
        public override string ToString()
        {
            return $"You can find Nurse {Name} in {Department}";
        }
    }

    public enum Dep
    {
        Cardiology,
        Neurology,
        Geriatrics,
        Pediatrics,
        Emergency

    }
}
