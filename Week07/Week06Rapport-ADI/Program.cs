using System;
using System.Runtime.Serialization;

namespace Week06Rapport_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal studenten: ");
            int studenten = Convert.ToInt32(Console.ReadLine());

            Console.Write("Aantal gegeven testen: ");
            int testen = Convert.ToInt32(Console.ReadLine());

            int[,] rapport = new int[studenten, testen];

            //cijfers toevoegen
            for (int i = 0; i < studenten; i++)
            {
                for (int j = 0; j < testen; j++)
                {
                    Console.Write($"Punt voor test {j + 1} van student {i + 1}: ");
                    rapport[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            //resultaten tonen in een matrix

            for (int i = 0; i < studenten; i++)
            {
                Console.Write($"Student{i + 1}: ");
                for (int j = 0; j < testen; j++)
                {
                    Console.Write(rapport[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //gemiddelde per student berekenen
            for (int i = 0; i < studenten; i++) //of i < rapport.GetLength(0)
            {
                int som = 0;
                for (int j = 0; j < testen; j++) //of j < rapport.GetLength(1)
                {
                    som += rapport[i, j];
                }
                Console.WriteLine($"gemiddelde voor student {i + 1} is {som/testen}");
            }

            Console.WriteLine();

            //gemiddelde per test
            for (int i = 0; i < testen; i++)
            {
                int som = 0;
                for (int j = 0; j < studenten; j++)
                {
                    som += rapport[j, i];
                }
                Console.WriteLine($"gemiddelde voor test {i + 1} is {som / studenten}");
            }



        }
    }
}
