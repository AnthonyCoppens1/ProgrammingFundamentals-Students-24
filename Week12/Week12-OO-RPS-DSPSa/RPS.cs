using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_OO_RPS_DSPSa
{
    public enum Choice
    {
        Rock = 0,
        Paper = 1,
        Scissor = 2
    }

    public class RPS
    {
        //my own choice (with hand), computer choice (with hand), scoreMyself, scorePC, random
        public Choice MyChoice { get; set; } 
        public Choice PCChoice { get; set; }
        public int MyScore { get; set; }
        public int PCScore { get; set; }
        public Random rd { get; set; }

        public RPS()
        {
            rd = new Random();
        }

        public string Round()
        {
            PCChoice = (Choice)rd.Next(0, 3);

            string result = "";
            if ((MyChoice == Choice.Rock && PCChoice == Choice.Scissor) ||
                (MyChoice == Choice.Paper && PCChoice == Choice.Rock) ||
                (MyChoice == Choice.Scissor && PCChoice == Choice.Paper))
            {
                MyScore++;
                result = $"Computer: {PCChoice} --> I win!";
            }
            else if ((PCChoice == Choice.Rock && MyChoice == Choice.Scissor) ||
                    (PCChoice == Choice.Paper && MyChoice == Choice.Rock) ||
                    (PCChoice == Choice.Scissor && MyChoice == Choice.Paper))
            {
                PCScore++;
                result = $"Computer: {PCChoice} --> PC wins!";
            }
            else
            {
                result = $"Computer: {PCChoice} --> DRAW!";
            }

            return result;
        }

        public override string ToString()
        {
            return $"{MyScore} : {PCScore}";
        }

    }
}
