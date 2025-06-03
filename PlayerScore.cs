using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class PlayerScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Position { get; set; }

        public PlayerScore(string name, int score, int position)
        {
            this.Name = name;
            this.Score = score;
            this.Position = position;
        }
    }
}
