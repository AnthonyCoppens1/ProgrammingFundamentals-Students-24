using System;
using System.Collections.Generic;

namespace Week09StudentDatabase_DSPSa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to do? INSERT, SELECT, UPDATE, DELETE or END? ");
            string input = Console.ReadLine().ToUpper();
            List<string> name = new List<string>();
            List<int> age = new List<int>();
            List<DateTime> birthday = new List<DateTime>();

            while (input != "END")
            {
                switch (input)
                {
                    case "INSERT":
                        Console.Write("Name: "); name.Add(Console.ReadLine());
                        Console.Write("Age: "); age.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Birthday: "); birthday.Add(Convert.ToDateTime(Console.ReadLine()));
                        Console.WriteLine($"Your student number is: {name.Count}");
                        input = Console.ReadLine().ToUpper();
                        break;

                    case "SELECT":
                        Console.Write("What student data do you want? Provide the number: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Name: {name[number - 1]}, age: {age[number - 1]}, birthday: {birthday[number - 1]}");
                        input = Console.ReadLine().ToUpper();
                        break;

                    case "UPDATE":
                        Console.Write("What student data do you want? Provide the number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What do you want to update? NAME, AGE or BIRTHDAY? ");
                        string command = Console.ReadLine().ToUpper();
                        if (command == "NAME")
                        {
                            Console.Write("Name: ");
                            name[number - 1] = Console.ReadLine();
                        }
                        else if (command == "AGE")
                        {
                            Console.Write("Age: ");
                            age[number - 1] = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (command == "BIRTHDAY")
                        {
                            Console.Write("Birthday: ");
                            birthday[number - 1] = Convert.ToDateTime(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write("Wrong message, terminating this update!");
                        }
                        input = Console.ReadLine();
                        break;

                    case "DELETE":
                        Console.Write("What is the student number you want to delete?");
                        number = Convert.ToInt32(Console.ReadLine());
                        name.RemoveAt(number - 1);
                        age.RemoveAt(number - 1);
                        birthday.RemoveAt(number - 1);
                        Console.WriteLine($"Student {number} has been removed!");
                        input = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again!");
                        input = Console.ReadLine();
                        break;
                }
            }

            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"Student {i + 1}: {name[i]}, {age[i]}, {DateOnly.FromDateTime(birthday[i])}");
            }



        }
    }
}
