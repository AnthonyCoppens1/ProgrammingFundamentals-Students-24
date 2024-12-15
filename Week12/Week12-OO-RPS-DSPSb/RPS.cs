using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_RPS_DSPSb
{
    public class RPS
    {
        public Hand Me { get; set; }
        public Hand PC { get; set; }
        public int ScoreMe { get; set; }
        public int ScorePC { get; set; }
        private Random rd { get; set; }

        public RPS()
        {
            rd = new Random();
        }

        public string Turn()
        {
            PC = (Hand)rd.Next(0, 3);
            string result = "";

            if ((Me == Hand.Rock && PC == Hand.Scissor) || (Me == Hand.Paper && PC == Hand.Rock)
                || (Me == Hand.Scissor && PC == Hand.Paper))
            {
                ScoreMe++;
                result = $"Computer: {PC} --> I win!";
            }
            else if ((PC == Hand.Rock && Me == Hand.Scissor) || (PC == Hand.Paper && Me == Hand.Rock)
                || (PC == Hand.Scissor && Me == Hand.Paper))
            {
                ScorePC++;
                result = $"Computer: {PC} --> I Lose!";
            }
            else
            {
                result = $"Computer: {PC} --> DRAW!";
            }
            return result;
        }

        public override string ToString()
        {
            return $"ME: {ScoreMe} vs PC: {ScorePC}";
        }




    }

    public enum Hand
    {
        Rock = 0,
        Paper = 1,
        Scissor = 2
    }
}
