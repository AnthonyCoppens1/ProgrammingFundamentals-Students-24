using System;

namespace Week11_OO_Hospital_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Collin = new Doctor("Collin Van der Vorst", new DateOnly(1991, 04, 16), Spec.Feet);
            Doctor Elke = new Doctor("Elke Boonen", new DateOnly(1980, 04, 23), Spec.Eyes);
            Patient Rihanna = new Patient("Robyn Rihanna Fenty", new DateOnly(1988, 02, 20), "Shitty voice");
            Patient Trump = new Patient("Donald J Trump", new DateOnly(1954, 05, 18), "Orange and too talkative");
            Nurse Jess = new Nurse("Jess the nurse", new DateOnly(1990, 12, 03), Dep.Cardiology);

            /* WILL NOT WORK ANYMORE BECAUSE WE TOOK AWAY STATUS AND MADE CORRECT CLASSES
             * BECAUSE WE DONT HAVE THE STATUS ANYMORE
             * foreach (var p in people)
            {
                if (p.Status == "Doctor")
                {
                    Console.WriteLine(p.Name);
                }
            }*/

            Rihanna.Print();
            /*Console.WriteLine(Rihanna);

            Console.WriteLine(Jess);
            Console.WriteLine(Collin);
            Console.WriteLine(Elke);
            Console.WriteLine(Trump);
            Taken care of in the foreach loop under the list! */

            List<Person> people = new List<Person>();
            people.Add(Elke);
            people.Add(Rihanna);
            people.Add(Collin);
            people.Add(Jess);
            people.Add(Trump);

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            Hospital AZThomasMore = new Hospital("AZThomasMore", "Mechelen", people);

            Nurse Anthony = new Nurse("Anthony Coppens", new DateOnly(1995, 07, 31), Dep.Neurology);
            
            //possibility to add someone to the hospital
            AZThomasMore.AddPerson(Anthony);
            Console.WriteLine(AZThomasMore);

            Console.WriteLine();
            foreach(var patient in AZThomasMore.GetPatients())
            {
                Console.WriteLine(patient);
            }
            Console.WriteLine();

            foreach (var staffmember in AZThomasMore.GetStaff())
            {
                Console.WriteLine(staffmember);
            }
            Console.WriteLine("-------------");


            Hospital UZLeuven = new Hospital("UZLeuven", "Leuven");
            Doctor SnoopDog = new Doctor("Snoop double G", new DateOnly(1971, 03, 17), Spec.DisabledRappers);
            Patient NickyMinaj = new Patient("Nicky Minaj", new DateOnly(1985, 09, 22), "Always beefin");

            UZLeuven.AddPerson(SnoopDog);
            UZLeuven.AddPerson(NickyMinaj);

            Console.WriteLine(UZLeuven);






        }

    }
}
