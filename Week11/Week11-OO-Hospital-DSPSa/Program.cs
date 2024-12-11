using System;

namespace Week11_OO_Hospital_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Steve = new Doctor("Steve Jobs", new DateOnly(2000, 01, 01), "Meds");
            Patient Bashir = new Patient("Bashir Abdi", new DateOnly(1999, 03, 19), "Malaria");
            Nurse Collin = new Nurse("Collin Van der Vorst", new DateOnly(1991, 04, 16), "Emergency");
            Doctor Julie = new Doctor("Julie François", new DateOnly(2005, 07, 23), "Radiology");
            AmbulanceDriver Radj = new AmbulanceDriver("Radj Gurdeep", new DateOnly(2002, 11, 14), 'C');

            Console.WriteLine(Collin.Department);
            Console.WriteLine(Steve.Name);
            Console.WriteLine(Bashir.Name);
            //Console.WriteLine(Julie.Birthday);
            Console.WriteLine($"{Radj.Name} is driving a {Radj.LicenseType} type ambulance");

            Steve.Name = "Steve Jobs";
            Steve.FieldOfStudy = "Weird feet";
            Console.WriteLine($"{Steve.Name} is a doctor in {Steve.FieldOfStudy}");

            Collin.Print();
            Console.WriteLine(Collin);

            Console.WriteLine(Julie);

            List<Person> people = new List<Person>();
            people.Add(Steve);
            people.Add(Collin);
            people.Add(Bashir);
            people.Add(Julie);
            people.Add(Radj);

            foreach (Person p in people) // or var p
            {
                Console.WriteLine(p);
            }

        }
    }
}
