using System;

namespace Week11_OO_Hospital_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor Collin = new Doctor("Collin Van der Vorst", new DateOnly(1991, 04, 16), "Feet");
            Doctor Elke = new Doctor("Elke Boonen", new DateOnly(1980, 04, 23), "Eyes");
            Patient Rihanna = new Patient("Robyn Rihanna Fenty", new DateOnly(1988, 02, 20), "Shitty voice");
            Patient Trump = new Patient("Donald J Trump", new DateOnly(1954, 05, 18), "Orange and too talkative");
            Nurse Jess = new Nurse("Jess the nurse", new DateOnly(1990, 12, 03), "Cardiology");

            /* WILL NOT WORK ANYMORE BECAUSE WE TOOK AWAY STATUS AND MADE CORRECT CLASSES
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


        }

    }
}
