using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_OO_Pets_DSPSb
{
    public class Person
    {
        //Name, Age, Gender, birthday
        public string FirstName { get; set; } //prop --> tab
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public List<Pet> Pets { get; set; } = new();
        //everyone gets the possibility of adding pets

        public Person(string firstname, string lastname, 
            int age, char gender, DateOnly birthday) //ctor --> tab
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Gender = gender;
            Birthday = birthday;
        }

        //you need to override the ToString() method, because otherwise
        //it will grab the one from the class Object, which prints out the class type
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }

    /* introducing a base class or a parent class called Pet!
     * type of blueprint, nobody has pet named pet
     * describes common properties of ALL pets*/

    public abstract class Pet
    { //this blueprint is a designed model of what a pet would look like
        //abstraction: thinking of global picture, before specifying
        public string First { get; set; }
        public Pet(string firstname)
        {
            First = firstname;
        }

        public abstract string MakeNoise();

        public override string ToString()
        {
            return $"{First} is a {GetType().Name}";
        }
    }


    public class Cat : Pet //inheritance, lending properties, ... from base class
    {
        public Cat(string firstname) : base(firstname)
        {
        }

        public override string MakeNoise()
        {
            return "meow";
        }
        //need to override, because every pet has a unique MakeNoise(), can't use
        //the global one that doesn't specifiy.

        //new way of creating method that ONLY returns a string:
        //public string Meow() => "meow";
    }

    public class Dog : Pet
    {
        public Dog(string firstname) : base(firstname)
        {
        }

        public override string MakeNoise() => "bark";
    }

}
