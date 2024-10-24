using System;

namespace Week06Arrays1D_OEF_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 13, -4, 5, 17, 83, 99 };

            //gemakkelijke manier
            Console.WriteLine("som: " + array.Sum());
            Console.WriteLine("gemiddelde: " + array.Average());
            Console.WriteLine("min: " + array.Min());
            Console.WriteLine("max: " + array.Max());

            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Array.Reverse(array);
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }


            //algoritmische manier
            //som berekenen en het gemiddelde
            array = new int[] { 1, 8, -3, 6, 9, 13, -4, 5, 17, 83, 99 };

            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("som: " + som);
            Console.WriteLine("gemiddelde: " + som / array.Length);


            //min en max zoeken
            int min = array[0];

            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("min: " + min);


            //sorteeralgoritmes
            //https://en.wikipedia.org/wiki/Bubble_sort
            //checken of huidige getal groter is dan volgende, indien ja, wissel
            //indien nee, naar volgende 2. Herhaal tot volledig gesorteerd

            for (int i = 0; i < array.Length; i++)
            { //checkt meerdere keren voor het maximum aantal elementen in keren
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //omdraaien van die handel
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
