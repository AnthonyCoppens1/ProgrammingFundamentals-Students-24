using System;

namespace Week11_OO_Hospital_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Steve = new Doctor("Steve Jobs", new DateOnly(2000, 01, 01), field.Meds);
            Patient Bashir = new Patient("Bashir Abdi", new DateOnly(1999, 03, 19), "Malaria");
            Nurse Collin = new Nurse("Collin Van der Vorst", new DateOnly(1991, 04, 16), dept.Emergency);
            Doctor Julie = new Doctor("Julie François", new DateOnly(2005, 07, 23), field.Radiology);
            AmbulanceDriver Radj = new AmbulanceDriver("Radj Gurdeep", new DateOnly(2002, 11, 14), 'C');

            Console.WriteLine(Collin.Department);
            Console.WriteLine(Steve.Name);
            Console.WriteLine(Bashir.Name);
            //Console.WriteLine(Julie.Birthday);
            Console.WriteLine($"{Radj.Name} is driving a {Radj.LicenseType} type ambulance");

            Steve.Name = "Steve Jobs";
            Steve.FieldOfStudy = field.WeirdFeet;
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

            Hospital PalaceOfUnicorns = new Hospital("Palace of Unicorns", "Paradise");
            Console.WriteLine(PalaceOfUnicorns.Name);
            foreach (var p in people)
            {
                PalaceOfUnicorns.AddPerson(p);
                Console.WriteLine(p);
            }



            //create a couple of people to immediately move into the new hospital
            //with a list prepared

            Patient Usman = new Patient("Usman", new DateOnly(2001, 04, 14), "Tendinitis");
            AmbulanceDriver Coppens = new AmbulanceDriver("Coppens", new DateOnly(1967, 09, 12), 'B');
            Doctor Pasci = new Doctor("Pasci Pascal", new DateOnly(2010, 12, 25), field.Pneumonology);

            List<Person> newbies = new List<Person> { Usman, Coppens, Pasci };


            Hospital ZiekenhuisMechelen = new Hospital("Ziekenhuis Mechelen", "Mechelen", newbies);
            Console.WriteLine("\n" + ZiekenhuisMechelen.Name);
            foreach (var p in ZiekenhuisMechelen.People)
            {
                Console.WriteLine($"-{p}");
            }


            Console.WriteLine("-----------");
            foreach (var p in PalaceOfUnicorns.GetPatients())
            {
                Console.WriteLine(p);
            }
            foreach (var p in PalaceOfUnicorns.GetStaff())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine(PalaceOfUnicorns);




        }
    }
}
