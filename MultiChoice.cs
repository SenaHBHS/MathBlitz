using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class MultiChoice : Question
    {
        public List<string> Options { get; set; }

        public MultiChoice(string id, string questionText, string answer, string timeLimitStr, string scoreStr, string level, List<string> options)
        {
            this.Id = id;
            this.QuestionText = questionText;
            this.Answer = answer;
            this.TimeLimitStr = timeLimitStr;
            this.ScoreStr = scoreStr;
            this.Level = level;
            this.Options = options;
        }
    }
}
