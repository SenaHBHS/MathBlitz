using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class PlayerScore
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public PlayerScore(string name, int score, int position)
        {
            this.Position = position;
            this.Name = name;
            this.Score = score;
        }
    }
}
