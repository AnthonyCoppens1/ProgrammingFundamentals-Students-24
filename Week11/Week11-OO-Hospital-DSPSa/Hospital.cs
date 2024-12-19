using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Hospital_DSPSa
{
    public class Hospital
    {
        //need people / location / name 
        public List<Person> People { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        public Hospital(string name, string location)
        {
            People = new List<Person>();
            Name = name;
            Location = location;
        }
        public Hospital(string name, string location, List<Person> people)
        {
            Name = name;
            Location = location;
            People = people;
        }

        public void AddPerson(Person p)
        {
            People.Add(p);
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            foreach (var p in People)
            {
                if (p is Patient)
                {
                    patients.Add((Patient)p);
                }
            }

            return patients;
        }

        public List<Person> GetStaff()
        {
            List<Person> staff = new List<Person>();
            foreach (var p in People)
            {
                if (p is not Patient)
                {
                    staff.Add(p);
                }
            }

            return staff;
        }

        public override string ToString()
        {
            string s = $"HOSPITAL: {Name} in {Location}\n";
            foreach (Person p in People)
            {
                s += $"* {p}\n";
            }
            return s;
        }
    }
}
