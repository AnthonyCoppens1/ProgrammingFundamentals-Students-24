using System;

namespace Week11_OO_Pets_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Anthony = new Person("Anthony", "Coppens", 29, 
                'M', new DateOnly(1995, 07, 31));
            Person Cali = new Person("Calipride", "Sona", 24, 'F', new DateOnly(2000, 03, 16));
            Person Josh = new Person("Josh", "Poltavskyi", 35, 'M', new DateOnly(1989, 10, 27));
            Person Elke = new Person("Elke", "Boonen", 44, 'F', new DateOnly(1980, 04, 23));

            List<Person> people = new List<Person> {Anthony, Cali, Josh, Elke };
            Console.WriteLine(people.Count);

            Anthony.Pets.Add(new Cat("Yuki"));
            Anthony.Pets.Add(new Dog("George"));

            Cali.Pets.Add(new Cat("Bowie"));
            Cali.Pets.Add(new Cat("Beyonce"));

            Elke.Pets.Add(new Dog("Benoit"));
            Elke.Pets.Add(new Dog("Denzel"));

            Console.WriteLine(Josh);

            foreach (var p in people)
            {
                Console.WriteLine($"{p}");
                foreach (var pet in p.Pets)
                {
                    Console.WriteLine($"      {pet}");
                }
            }

            Console.WriteLine(17.ToString());

        }
    }
}
