using System;
using System.Collections.Generic;

namespace Week09StudentDatabase_DSPSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine().ToUpper();

            List<string> name = new List<string>();
            List<int> age = new List<int>();
            List<string> nationality = new List<string>();
            List<char> gender = new List<char>();
            List<DateTime> birthday = new List<DateTime>();

            int studentnumber = 1;

            while(action != "END")
            {
                switch (action)
                {
                    case "INSERTSTUDENT":
                        Console.Write("Name: "); name.Add(Console.ReadLine());
                        Console.Write("Age: "); age.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Nationality: "); nationality.Add(Console.ReadLine());
                        Console.Write("Gender: "); gender.Add(Convert.ToChar(Console.ReadLine()));
                        Console.Write("Birthday: "); birthday.Add(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write($"The student number is: {studentnumber} \n\n");
                        studentnumber++;
                        action = Console.ReadLine().ToUpper();
                        break;

                    case "UPDATE":
                        Console.Write("What is the student number? "); int number = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Name: "); name[number - 1] = Console.ReadLine();
                        Console.Write("Age: "); age[number - 1] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nationality: "); nationality[number - 1] = Console.ReadLine();
                        Console.Write("Gender: "); gender[number - 1] = Convert.ToChar(Console.ReadLine());
                        Console.Write("Birthday: "); birthday[number - 1] = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine();
                        action = Console.ReadLine().ToUpper();
                        break;
                    case "DELETE":
                        Console.Write("What is the student number? "); number = Convert.ToInt32(Console.ReadLine());
                        name.RemoveAt(number - 1);
                        age.RemoveAt(number - 1);
                        nationality.RemoveAt(number - 1);
                        gender.RemoveAt(number - 1);
                        birthday.RemoveAt(number - 1);
                        Console.Write($"The information of student {number} has been deleted! \n");
                        action = Console.ReadLine().ToUpper();
                        break;
                    default:
                        Console.WriteLine("You've entered something that is not a valid keyword! Try again.");
                        action = Console.ReadLine().ToUpper();
                        break;
                }
            }
            Console.WriteLine("Session has ended. These are our students!\n");
            for (int i = 0; i < name.Count; i++)
            {
                Console.Write(name[i] + " " + age[i] + " " + nationality[i] + " " + gender[i] +" "
                    + DateOnly.FromDateTime(birthday[i]) + "\n");
            }

        }
    }
}
