using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class PlayerScore
    {
        public int Position { get; set; } // the rank of the player
        public string Name { get; set; } // player name
        public int Score { get; set; } // total pi score

        public PlayerScore(string name, int score, int position)
        {
            // constructing a player score record
            this.Position = position;
            this.Name = name;
            this.Score = score;
        }
    }
}
