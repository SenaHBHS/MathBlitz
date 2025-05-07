using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathBlitz
{
    public partial class frmMain : Form
    {
        string tfqFilePath = Path.Combine(Application.StartupPath, "math_blitz_true_false.csv"); // path to true false questions
        string mcqFilePath = Path.Combine(Application.StartupPath, "math_blitz_multiple_choice.csv"); // path to multi choice questions
        string errorLogPath = Path.Combine(Application.StartupPath, "error_log.csv");

        int questionDataFieldsCount = 6; // excluding the options fields
        Dictionary<string, int> questionDataFieldsCountDict = new Dictionary<string, int>() {
            { "true-false-questions", 6 },
            { "multi-choice-questions", 10 }
        };

        public frmMain()
        {
            InitializeComponent();
        }
        private void RefreshLeaderboardDgv()
        {
            dgvLeaderboard.DataSource = null;
            dgvLeaderboard.DataSource = null; // wire up the data list later
        }

        private void LogError(string errorMessage)
        {
            if (File.Exists(errorLogPath))
            {
                using (StreamWriter sw = new StreamWriter(errorLogPath, true))
                {
                    sw.WriteLine($"{DateTime.Now}: {errorMessage}");
                }
            }
        }

        private void LoadDataFile(string filePath, string loadDataType)
        {
            if (File.Exists(filePath))
            {
                string line;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    int lineNo = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNo++;
                        string[] fields = line.Split(',');
                        if (fields.Length > 0)
                        {
                            if (loadDataType == "true-false-questions" || loadDataType == "multi-choice-questions")
                            {
                                if (fields.Length >= questionDataFieldsCountDict[loadDataType])
                                {
                                    string id = fields[0];
                                    string question = fields[1];
                                    string answer = fields[2];
                                    string timeLimitStr = fields[3]; // in minutes
                                    bool isTimeNumeric = int.TryParse(timeLimitStr, out int timeLimit);
                                    string scoreStr = fields[4];
                                    bool isScoreNumeric = int.TryParse(scoreStr, out int score);
                                    string level = fields[5];
                                    if (isTimeNumeric && isScoreNumeric)
                                    {
                                        if (loadDataType == "multi-choice-questions")
                                        {
                                            // id,question,option_1,option_2,option_3,option_4,answer,time_limit,score,level
                                            string optionOne = fields[6];
                                            string optionTwo = fields[7];
                                            string optionThree = fields[8];
                                        } else
                                        {
                                            // id,question,answer,time_limit,score,level
                                        }
                                    } else
                                    {
                                        MessageBox.Show($"The score or the time in {lineNo} is non-numerical!");
                                    }
                                }
                            }
                        } else
                        {
                            MessageBox.Show(lineNo + " is empty!");
                        }
                        // TrueFalse newEntry = new TrueFalse(...fields);
                        // dataList.Add(newEntry);
                    }
                }
            }
        }
    }
}
