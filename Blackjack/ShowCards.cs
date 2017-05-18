using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class ShowCards
    {
        public string Check(int yourScore, int computerScore)
        {
            string result = "";
            //Display all scores
            if (yourScore == 21 && !(computerScore == 21))
            {
                result = "\nYou Won!";
            }
            else if (yourScore <= 21 && computerScore > 21)
            {
                result = "\nYou Won!";
            }
            else if (yourScore >= computerScore)
            {
                result = "\nYou Won!";
            }
            //Draw
            else if (yourScore == 21 && computerScore == 21)
            {
                result = "\nIt's a draw. No one wins!";
            }
            else if (yourScore == computerScore)
            {
                result = "\nIt's a draw. No one wins!";
            }
            else if (yourScore > 21 && computerScore <= 21)
            {
                result = "\nYou lost.";
            }
            else if (yourScore < computerScore && computerScore <= 21)
            {
                result = "\nYou lost.";
            }
            return result;
        }
    }
}
