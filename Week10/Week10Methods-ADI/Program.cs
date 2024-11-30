using System;

namespace Week10Methods_ADI
{
    internal class Program
    {
        //static int[] getallen = { 4, 5, 1, 0, 2, 3 };

        static void Main(string[] args)
        {
            HelloWorld();
            int G1 = Convert.ToInt32(Console.ReadLine());
            int G2 = Convert.ToInt32(Console.ReadLine());
            Optellen(G1, G2);
            Optellen(201, 99);
            Console.WriteLine(OptellenMetReturn(G1, G2) + 15);

            Console.WriteLine();
            int[] getallen = { 4, 5, 1, 0, 2, 3 };
            Print(getallen);
            Array.Sort(getallen);
            Print(getallen);

            //lengte maakt niet uit!
            int[] getallen2 = { 2, 4, 6, 8, 9, 10, 1, 13, 28, -5, 16 };
            Print(getallen2);
            Array.Sort(getallen2);
            Print(getallen2);
            Console.WriteLine();

            int[] getallen3 = Fill(10);
            Print(getallen3);
            Array.Sort(getallen3);
            Print(getallen3);

            Console.WriteLine();

            int[] getallen4 = Fill(25);
            Print(getallen4);
            Array.Sort(getallen4);
            Print(getallen4);

            string[] woorden = { "banaan", "appel", "citroen" };
            Print(woorden);
            Array.Sort(woorden);
            Print(woorden);

            double[] doubles = { 1.2, 3.4, -5.8, 9.2, 3.1 };
            Print(doubles);
            Array.Sort(doubles);
            Print(doubles);

            //pass by value
            int ResultaatStudent = 75;
            Console.WriteLine($"De punten van de student voor de extra credits: {ResultaatStudent}");
            GeefExtraCredits(ref ResultaatStudent);
            Console.WriteLine($"De punten van de student NA de extra credits: {ResultaatStudent}");

            //int (datatype) heeft geen memory location, maar is een value type. 
            //een array is een reference type en bevat een aantal locaties waarnaar verwezen wordt
            //referentie naar de index van de array --> index 0


            int getal = 23;
            Console.WriteLine(getal);
            TEL(ref getal); //zonder ref hier en in parameter van methode, getal blijft zelfde
            Console.WriteLine(getal);


            //pass by reference
            int[] resultaten = new int[3];
            resultaten[0] = 80;
            resultaten[1] = 22;
            resultaten[2] = 51;
            Console.WriteLine($"Punten VOOR extra credits:");
            Print(resultaten);
            GeefMijExtraPunten(resultaten);
            Console.WriteLine($"Punten NA extra credits:");
            Print(resultaten);
            //punt wordt permanent aangepast, aangezien je werkt met een reference type (verwijzing naar de locatie)

            int a = 6;
            int b = 8;
            Console.WriteLine($"a: {a} en b: {b}");
            Swap(ref a,ref b);
            Console.WriteLine($"a: {a} en b: {b}");


            //out op de oude manier
            Console.Write($"Geef een size van array: ");
            string antwoord = Console.ReadLine();

            int[] array;
            if (Int32.TryParse(antwoord, out int grootte))
            {
                array = Fill(grootte);
            }
            else
            {
                array = Fill();
            }
            Print(array);




            //nieuwe voorbeeld met OUT --> optellen en vermenigvuldigen


            OptellenEnVermenigvuldigen(5, 10, out int optel, out int vermenigvuldig);
            Console.WriteLine(optel);
            Console.WriteLine(vermenigvuldig);

            nieuwGetal(out int N);
            Console.WriteLine(N);

            //optionele parameters
            WaardenToevoegen(5);
            WaardenToevoegen(5, z: 10);
            WaardenToevoegen(5, 2, 8);
            WaardenToevoegen(5, 12);


            //params keyword
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine();
            PrintArray(myArray);
            /*params keyword voor int[] array in methode PrintArray zorgt ervoor
             * dat je ofwel een vooropgestelde array kan invoeren, of gewoon raw input
             * kan meegeven en dit wordt gezien als een nieuwe array.
             * */
            Console.WriteLine();
            PrintArray(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);



        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void WaardenToevoegen(int x, int y = 1, int z = 2)
        {
            int berekening = x + y + z;
            Console.WriteLine(berekening);
        }

        static void nieuwGetal(out int nieuw)
        {
            nieuw = 5;
        }

        static void OptellenEnVermenigvuldigen(int a, int b, out int optel, out int vermenigvuldig)
        {
            optel = a + b;
            vermenigvuldig = a * b;
        }


        static void Swap(ref int a, ref int b)
        {
            int swapper = a;
            a = b;
            b = swapper;
        }

        static void GeefMijExtraPunten(int[] resultaten)
        {
            for (int i = 0; i < resultaten.Length; i++)
            {
                resultaten[i] += 3;
            }
            
        }



        static void TEL(ref int i)
        {
            i += 7;
            Console.WriteLine(i);
        }


        static void GeefExtraCredits(ref int ResultaatStudent)
        {
            ResultaatStudent += 3;
        }



        static int[] Fill(int size = 10)
        {
            Random random = new Random();
            int[] G = new int[size];
            for (int i = 0; i < size; i++)
            {
                G[i] = random.Next(0, 101);
            }
            return G;
            Array.Sort(G); //DIT IS DODE CODE, NA RETURN NIET UITGEVOERD!
        }

        static void Print(double[] D)
        {
            foreach (var item in D)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] S)
        {
            foreach (var item in S)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(int[] getallen)
        {
            foreach (var item in getallen)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int OptellenMetReturn(int G1, int G2)
        {
            int som = G1 + G2;
            return som;
        }


        static void Optellen(int getal1, int getal2) //void geeft niets terug, voert enkel iets uit
        {
            int som = getal1 + getal2;
            Console.WriteLine(som);
        }


        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
