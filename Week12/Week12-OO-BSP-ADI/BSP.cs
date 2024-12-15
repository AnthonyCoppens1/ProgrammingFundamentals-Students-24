using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_BSP_ADI
{
    public enum Hand
    {
        Blad = 0,
        Steen = 1,
        Schaar = 2
    }

    public class BSS
    {
        //hand mezelf, hand computer, score mezelf, score computer, random
        public Hand Mij { get; set; }
        public Hand PC { get; set; }
        public int ScoreMij { get; set; }
        public int ScorePC { get; set; }
        public Random r { get; set; }

        public BSS()
        {
            r = new Random();
        }

        public string Beurt()
        {
            PC = (Hand)r.Next(0, 3);
            string resultaat = "";

            if ((Mij == Hand.Steen && PC == Hand.Schaar) || 
                (Mij == Hand.Schaar && PC == Hand.Blad) ||
                (Mij == Hand.Blad && PC == Hand.Steen))
            {
                ScoreMij++;
                resultaat = $"Computer: {PC} --> Ik win!!! Wohooow";
            }
            else if ((PC == Hand.Steen && Mij == Hand.Schaar) ||
                (PC == Hand.Schaar && Mij == Hand.Blad) ||
                (PC == Hand.Blad && Mij == Hand.Steen))
            {
                ScorePC++;
                resultaat = $"Computer: {PC} --> PC wint!!! BOOOOO";
            }
            else
            {
                resultaat = $"Computer: {PC} --> Gelijkspel!";
            }
            return resultaat;
        }

        public override string ToString()
        {
            return $"{ScoreMij} - {ScorePC}";
        }

    }
}
