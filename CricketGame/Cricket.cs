using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public bool CanPlay { get; set; }

        public int winner = 0;
        public Cricket()
        {
            CanPlay = true;
            PlayerScore = 0;
        }

        public void Score(int runs)
        {
            if(CanPlay==true)
            {
                if (runs > 6 || runs < 1)
                {
                    PlayerScore = PlayerScore +  0;
                }
                else
                {
                    PlayerScore = PlayerScore + runs;
                }
            }
         
        }

        public void playerAccess(bool p)
        {
            CanPlay = p;
        }

        public int CheckWinner(Cricket playerOne, Cricket playerTwo)
        {
            if(playerOne.PlayerScore>playerTwo.PlayerScore)
            {
                winner = 1;
            }
            else if(playerOne.PlayerScore < playerTwo.PlayerScore)
            {
                winner = 2;
            }
            return winner;
        }
    }
}
