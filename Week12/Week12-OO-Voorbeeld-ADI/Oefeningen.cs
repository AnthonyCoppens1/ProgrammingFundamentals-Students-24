using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_Voorbeeld_ADI
{
    public class Oefeningen
    {
        public Oefeningen() { }

        public string ReverseCase(string zin)
        {
            return $"poiuytreza";
        }


        public void SumOfChars(string woord1, string woord2)
        {
            Console.WriteLine("test");
        }

        public int berekening(int getal)
        {

            return getal + 5;
        }

        public void IsFibonacci(int getalFib)
        {
            int antwoord = berekening(getalFib);
            Console.WriteLine(antwoord);
        }

    }
}
