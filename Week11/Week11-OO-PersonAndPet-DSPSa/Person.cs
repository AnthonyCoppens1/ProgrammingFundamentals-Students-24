using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_PersonAndPet_DSPSa
{
    public class Person
    {
        //prop + tab
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public int Age { get; set; }

        //trying to make a list of pets? difficult without a base class
        public List<Pet> Pets { get; set; } = new();

        //ctor + tab
        public Person(string firstname, string lastname, DateOnly birthday, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}";
        }

    }

    //introduce a baseclass called Pet! It's a type of blueprint, nobody has a pet named
    //pet, it should describe the common properties of ALL pets

    public abstract class Pet
    {
        //making it abstract turns this into something we can't create, but can
        //be used as a blueprint
        //importance of bigger picture: ABSTRACTION
        public string FirstName { get; set; }
        public Pet(string firstname)
        {
            FirstName = firstname;
        }
        public abstract string MakeNoise();
        public override string ToString()
        {
            return $"{FirstName} and I am a {GetType().Name}";
        }
    }


    public class Dog : Pet
    {
        //ctor + tab
        public Dog(string firstname) : base(firstname)
        {
        }

        //public string Bark() => "Bark"; --> expression bodied method!
        public override string MakeNoise()
        {
            return "Bark";
        }
    }

    public class Fish : Pet
    {
        public Fish(string firstname) : base(firstname)
        {
        }

        public override string MakeNoise()
        {
            return "Blub";
        } 
        //or public string Blub() => "Blub";
    }
}
