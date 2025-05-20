using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class MultiChoice : Question
    {
        public string[] Options { get; set; }
        public int AnswerOptionNum { get; set; } // numbers ranging from 1 to 4 to denote the correct option

        public MultiChoice(string id, string questionText, string answer, double timeLimit, int score, string level, string[] options)
        {
            this.Id = id;
            this.QuestionText = questionText;
            this.Answer = answer;
            this.TimeLimit = timeLimit;
            this.Score = score;
            this.Level = level;
            this.Options = options;
            this.AnswerOptionNum = Array.IndexOf(options, answer) + 1;
        }
    }
}
