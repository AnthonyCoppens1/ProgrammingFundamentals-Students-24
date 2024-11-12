using System;

namespace Week07ExceptionsVoorEnNa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OUDE MANIER
            /*Console.WriteLine("enter filename: ");
            string file = Console.ReadLine();

            Console.Write("Geef een lijn in: ");
            int lijnnr;
            if (!Int32.TryParse(Console.ReadLine(), out lijnnr))
            {
                Console.WriteLine("Geen correct getal als lijnnummer! We stoppen.");
                return;
            }

            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if (lijnnr > text.Length)
                {
                    Console.WriteLine("Lijnnummer is veel te groot! We stoppen.");
                    return;
                }
                Console.WriteLine(text[lijnnr]);
            }
            else
            {
                Console.WriteLine("Geen correcte file! We stoppen.");
                return;
            }*/


            //NIEUWE MANIER MET EXCEPTION HANDLING
            try
            {
                Console.Write("Geef een filenaam: ");
                string file = Console.ReadLine();
                Console.Write("Geef een getal als lijn: ");
                int lijn = Convert.ToInt32(Console.ReadLine());
                string[] text = File.ReadAllLines(file);
                Console.WriteLine(text[lijn]);

            }
            catch (FileNotFoundException ex) //foute naam
            {
                Console.WriteLine("File werd niet gevonden!");
            }
            catch (IndexOutOfRangeException ex) //lijnnummer -7
            {
                Console.WriteLine("lijnnummer was niet correct voor deze file");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Lijnnummer is geen geheel getal!");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            /*catch (OverflowException ex)
             * {
             *      Console.WriteLine("Getal is veel te groot");
             * }*/



            try
            {
                Console.WriteLine("Geef een getal: ");
                int getal = Convert.ToInt32(Console.ReadLine());
                if (getal > 0 && getal < 20)
                {
                    Console.WriteLine(getal);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Je hebt geen getal opgegeven");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Je getal is veel te groot voor het datatype");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getal was groter dan 20 of kleiner dan 0");
            }
            finally
            {
                Console.WriteLine("Einde van mijn code");
            }





            //herhaaldelijk printen en problemen uitdrukken
            bool succes = false;
            while (succes == false)
            {
                try
                {
                    Console.WriteLine("Geef een getal: ");
                    int getal = Convert.ToInt32(Console.ReadLine());
                    if (getal > 0 && getal < 20)
                    {
                        Console.WriteLine(getal);
                        succes = true; //of break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Je hebt geen getal opgegeven");
                    Console.WriteLine("De code wordt opnieuw gestart, try again!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Je getal is veel te groot voor het datatype");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Getal was groter dan 20 of kleiner dan 0");
                }
            }
            
        }
    }
}
