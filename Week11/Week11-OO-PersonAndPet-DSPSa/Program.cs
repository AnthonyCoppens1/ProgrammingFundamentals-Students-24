using System;
using System.Xml.Serialization;

namespace Week11_OO_PersonAndPet_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person MrBean = new Person("Rowan", "Atkinson", new DateOnly(1970, 05, 23), 54);
            Person Anthony = new Person("Anthony", "Coppens", new DateOnly(1995, 07, 31), 29);
            Person Elke = new Person("Elke", "Boonen", new DateOnly(1980, 04, 23), 44);

            Console.WriteLine(MrBean.Age);
            Console.WriteLine(Anthony.LastName);

            List<Person> People = new List<Person> { MrBean, Anthony, Elke };
            foreach (Person p in People)
            {
                Console.WriteLine(p.Age);
            }

            Anthony.Pets.Add(new Dog("doggo"));
            Anthony.Pets.Add(new Dog("Simba"));
            Anthony.Pets.Add(new Fish("Fishstick"));

            MrBean.Pets.Add(new Fish("Nemo"));
            MrBean.Pets.Add(new Fish("Dori"));
            MrBean.Pets.Add(new Fish("Sharky"));
            MrBean.Pets.Add(new Fish("Aquaman"));

            Console.WriteLine(Anthony);

            foreach (var P in People)
            {
                Console.WriteLine($"{P}");
                foreach (var pet in P.Pets)
                {
                    Console.WriteLine($"         {pet}");
                }
            }


        }
    }
}
