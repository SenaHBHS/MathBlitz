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
        public double TimeLimit { get; set; } // in minutes
        public int Score { get; set; }
        public string Level { get; set; }

        public string ParseLoadedString(string loadedString)
        {
            char first = loadedString[0];
            char last = loadedString[loadedString.Length - 1];

            if ((first == '"' || first == '\'') && first == last && loadedString.Length >= 2)
            {
                return loadedString.Substring(1, loadedString.Length - 2);
            }

            return loadedString;
        }
    }
}
