using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class MultiChoice : Question
    {
        public string[] Options { get; set; } // options list
        public int AnswerOptionNum { get; set; } // numbers ranging from 1 to 4 to denote the correct option

        public MultiChoice(string id, string questionText, string answer, double timeLimit, int score, string level, string[] options)
        {
            // constructing a multichoice question record
            this.Id = ParseLoadedString(id);
            this.QuestionText = ParseLoadedString(questionText);
            this.Answer = ParseLoadedString(answer);
            this.TimeLimit = timeLimit;
            this.Score = score;
            this.Level = ParseLoadedString(level);
            this.Options = options.Select(option => ParseLoadedString(option)).ToArray();
            this.AnswerOptionNum = Array.IndexOf(options, answer) + 1;
        }
    }
}
