using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Hospital_DSPSb
{
    public class Hospital
    {
        //prop + tab
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Person> People { get; set; }

        public Hospital(string name, string location)
        {
            Name = name;
            Location = location;
            People = new List<Person>();
        }

        //ctor + tab
        public Hospital(string name, string location, List<Person> people)
        {
            Name = name;
            Location = location;
            People = people;
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public override string ToString()
        {
            string s = $"HOSPITAL: {Name}\n";
            foreach (Person person in People)
            {
                s += $"- {person}\n";
            }

            return s;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            foreach (var person in People)
            {
                if (person is Patient) //is the variable of the class Patient?
                {
                    patients.Add((Patient)person);
                }
            }
            return patients;
        }

        public List<Person> GetStaff()
        {
            List<Person> staff = new List<Person>();
            foreach (var person in People)
            {
                if (person is not Patient) //is the variable of the class Patient?
                {
                    staff.Add(person);
                }
            }
            return staff;
        }








    }
}
