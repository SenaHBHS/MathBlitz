using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlitz
{
    internal class Question
    {
        public string Id { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }
        public string TimeLimitStr { get; set; } // in minutes
        public string ScoreStr { get; set; }
        public string Level { get; set; }
    }
}
