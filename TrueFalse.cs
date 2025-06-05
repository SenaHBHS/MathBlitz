using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class TrueFalse : Question
    {
        public TrueFalse(string id, string questionText, string answer, double timeLimit, int score, string level)
        {
            this.Id = id;
            this.QuestionText = ParseLoadedString(questionText);
            this.Answer = ParseLoadedString(answer);
            this.TimeLimit = timeLimit;
            this.Score = score;
            this.Level = ParseLoadedString(level);
        }
    }
}
