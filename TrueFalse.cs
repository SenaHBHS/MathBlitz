using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class TrueFalse : Question
    {
        public TrueFalse(string id, string questionText, string answer, string timeLimitStr, string scoreStr, string level)
        {
            this.Id = id;
            this.QuestionText = questionText;
            this.Answer = answer;
            this.TimeLimitStr = timeLimitStr;
            this.ScoreStr = scoreStr;
            this.Level = level;
        }
    }
}
