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
        string errorLogPath = Path.Combine(Application.StartupPath, "error_log.csv"); // path to log errors

        // question data related
        string mcqFilePath = Path.Combine(Application.StartupPath, "math_blitz_multiple_choice.csv"); // path to multi choice questions
        string tfqFilePath = Path.Combine(Application.StartupPath, "math_blitz_true_false.csv"); // path to true false questions
        int baseFieldsNumber = 6; // the number of fields in the true false questions csv
        int mcqOptionsCount = 4; // the number of options each MCQ has. this is added to the baseFieldsNumber to get the total MCQ fields count
        List<MultiChoice> mcqQuestionsList = new List<MultiChoice>();
        List<TrueFalse> trueFalseQuestionsList = new List<TrueFalse>();

        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// refreshes the datagrid view by resetting its data source
        /// </summary>
        private void RefreshLeaderboardDgv()
        {
            dgvLeaderboard.DataSource = null;
            dgvLeaderboard.DataSource = null; // TODO: wire up the data list later
        }

        /// <summary>
        /// logs errors with datestamps in a csv file
        /// </summary>
        /// <param name="errorMessage">the error occurred</param>
        private void LogError(string errorMessage)
        {
            if (File.Exists(errorLogPath))
            {
                using (StreamWriter sw = new StreamWriter(errorLogPath, true))
                {
                    sw.WriteLine($"{DateTime.Now}, {errorMessage}");
                }
            }
        }

        /// <summary>
        /// loads data from a csv file and turns them into a list of objects
        /// </summary>
        /// <param name="filePath">file path to read the data from</param>
        /// <param name="loadDataType">data type can be "true-false-questions", "multi-choice-questions" or "leaderboard-data"</param>
        private void LoadDataFile(string filePath, string loadDataType)
        {
            if (File.Exists(filePath))
            {
                string line;
                Dictionary<string, int> questionDataFieldsCountDict = new Dictionary<string, int>() {
                    { "true-false-questions", baseFieldsNumber },
                    { "multi-choice-questions", baseFieldsNumber + mcqOptionsCount }
                };

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
                                    bool isTimeNumeric = double.TryParse(timeLimitStr, out double timeLimit);
                                    string scoreStr = fields[4];
                                    bool isScoreNumeric = int.TryParse(scoreStr, out int score);
                                    string level = fields[5];
                                    if (isTimeNumeric && isScoreNumeric)
                                    {
                                        if (loadDataType == "multi-choice-questions")
                                        {
                                            // id,question,answer,time_limit,score,level,option_1,option_2,option_3,option_4
                                            string[] options = new string[mcqOptionsCount];
                                            // extracting the options (assumes the options are the last few fields)
                                            Array.Copy(fields, baseFieldsNumber-1, options, 0, mcqOptionsCount);

                                            // creating a new question entry
                                            MultiChoice newMcQuestion = new MultiChoice(id, question, answer, timeLimit, score, level, options);
                                            mcqQuestionsList.Add(newMcQuestion);
                                        } else
                                        {
                                            // id,question,answer,time_limit,score,level
                                            TrueFalse newTrueFalseQuestion = new TrueFalse(id, question, answer, timeLimit, score, level);
                                            trueFalseQuestionsList.Add(newTrueFalseQuestion);
                                        }
                                    } else
                                    {
                                        LogError($"The score or the time in {lineNo} is non-numerical");
                                    }
                                } else
                                {
                                    LogError($"{lineNo} doesn't have necessary questions data fields");
                                }
                            }
                        } else
                        {
                            LogError($"{lineNo} is empty");
                        }
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataFile(mcqFilePath, "multi-choice-questions");
        }
    }
}
