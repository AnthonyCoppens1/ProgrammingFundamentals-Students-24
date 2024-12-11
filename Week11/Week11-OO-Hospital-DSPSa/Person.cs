using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Hospital_DSPSa
{
    public abstract class Person
    {
        public string Name { get; set; }
        private DateOnly Birthday { get; set; }

        public Person()
        {
            Name = "Steve";
            Birthday = new DateOnly(2000, 01, 01);
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
    }

    public class Patient : Person
    {
        public string Sickness { get; set; }

        public Patient(string name, DateOnly birthday, string sickness) : base(name, birthday)
        {
            Sickness = sickness;
        }
        public override string ToString()
        {
            return $"PATIENT: {Name} has a problem with {Sickness}";
        }
    }

    public class Doctor : Person
    {
        public string FieldOfStudy { get; set; }

        public Doctor(string name, DateOnly birthday, string fieldofstudy) : base(name, birthday)
        {
            FieldOfStudy = fieldofstudy;
        }
        public override string ToString()
        {
            return $"DOCTOR: Doctor {Name} is specialized in {FieldOfStudy}";
        }
    }

    public class Nurse : Person
    {
        public string Department { get; set; }

        public Nurse(string name, DateOnly birthday, string department) : base(name, birthday)
        {
            Department = department;
        }
        public override string ToString()
        {
            return $"NURSE: Nurse {Name} is a nurse at {Department}";
        }
    }

    public class AmbulanceDriver : Person
    {
        public char LicenseType { get; set; }

        public AmbulanceDriver(string name, DateOnly birthday, char licensetype) : base(name, birthday)
        {
            LicenseType = licensetype;
        }
        public override string ToString()
        {
            return $"AMBULANCEDRIVER: {Name} is amazing at driving {LicenseType}";
        }
    }
}
