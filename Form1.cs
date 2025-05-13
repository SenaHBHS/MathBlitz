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

        string playerName = "";

        // question data related
        string mcqFilePath = Path.Combine(Application.StartupPath, "math_blitz_multiple_choice.csv"); // path to multi choice questions
        string tfqFilePath = Path.Combine(Application.StartupPath, "math_blitz_true_false.csv"); // path to true false questions
        int baseFieldsNumber = 6; // the number of fields in the true false questions csv
        int mcqOptionsCount = 4; // the number of options each MCQ has. this is added to the baseFieldsNumber to get the total MCQ fields count
        // loaded multi choice questions by level
        List<MultiChoice> rookieMultiChoiceList = new List<MultiChoice>();
        List<MultiChoice> veteranMultiChoiceList = new List<MultiChoice>();
        List<MultiChoice> grandmasterMultiChoiceList = new List<MultiChoice>();
        // loaded true false quesions by level
        List<TrueFalse> rookieTrueFalseList = new List<TrueFalse>();
        List<TrueFalse> veteranTrueFalseList = new List<TrueFalse>();
        List<TrueFalse> grandmasterTrueFalseList = new List<TrueFalse>();

        // quiz related variables
        string selectedLevel = "";
        List<MultiChoice> selectedMultiChoiceList;
        List<TrueFalse> selectedTrueFalseList;
        int questionsCount = 15; // 15 is the default number and if the questions available is less than that questionsCount changes
        int trueFalseQuota = 6; // maximum number of true false questions that can be asked
        int nTrueFalseAsked = 0; // the number of true false questions asked
        List<string> askedQuestionIds = new List<string>();
        string currentQuestionType; // "multi-choice" or "true-false"
        int currentQuestionIndex;

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
                                            if (level == "Grandmaster")
                                            {
                                                grandmasterMultiChoiceList.Add(newMcQuestion);
                                            } else if (level == "Veteran")
                                            {
                                                veteranMultiChoiceList.Add(newMcQuestion);
                                            } else
                                            {
                                                rookieMultiChoiceList.Add(newMcQuestion);
                                            }
                                        } else
                                        {
                                            // id,question,answer,time_limit,score,level
                                            TrueFalse newTrueFalseQuestion = new TrueFalse(id, question, answer, timeLimit, score, level);
                                            if (level == "Grandmaster")
                                            {
                                                grandmasterTrueFalseList.Add(newTrueFalseQuestion);
                                            }
                                            else if (level == "Veteran")
                                            {
                                                veteranTrueFalseList.Add(newTrueFalseQuestion);
                                            }
                                            else
                                            {
                                                rookieTrueFalseList.Add(newTrueFalseQuestion);
                                            }
                                        }
                                    } else
                                    {
                                        LogError($"Line {lineNo}: The score or the time is non-numerical");
                                    }
                                } else
                                {
                                    LogError($"Line {lineNo}: Missing necessary questions data fields");
                                }
                            }
                        } else
                        {
                            LogError($"Line {lineNo}: Empty");
                        }
                    }
                }
            }
        }

        private void SelectLevel(string level)
        {
            selectedLevel = level;

            if (level == "Grandmaster")
            {
                selectedMultiChoiceList = grandmasterMultiChoiceList;
                selectedTrueFalseList = grandmasterTrueFalseList;
            } else if (level == "Veteran")
            {
                selectedMultiChoiceList = veteranMultiChoiceList;
                selectedTrueFalseList = veteranTrueFalseList;
            } else
            {
                selectedMultiChoiceList = rookieMultiChoiceList;
                selectedTrueFalseList = rookieTrueFalseList;
            }

            // updating these variables here prevents the possibility for infinite loops
            questionsCount = Math.Min(questionsCount, selectedMultiChoiceList.Count + selectedTrueFalseList.Count);
            trueFalseQuota = Math.Min(trueFalseQuota, selectedTrueFalseList.Count);
        }

        private void LoadNewQuestion()
        {
            Random rand = new Random();
            int newQuestionType; // 0 - true false question, 1 - multi choice question

            if (nTrueFalseAsked < trueFalseQuota)
            {
                newQuestionType = rand.Next(2);
            } else
            {
                newQuestionType = 1;
            }

            if (newQuestionType == 0)
            {
                int newQuestionIndex = rand.Next(selectedTrueFalseList.Count);
                TrueFalse newQuestion = selectedTrueFalseList[newQuestionIndex];
                string newQuestionId = newQuestion.Id;

                while (askedQuestionIds.Contains(newQuestionId))
                {
                    newQuestionIndex = rand.Next(selectedTrueFalseList.Count);
                    newQuestion = selectedTrueFalseList[newQuestionIndex];
                    newQuestionId = newQuestion.Id; 
                }

                currentQuestionType = "true-false";
                currentQuestionIndex = newQuestionIndex;
            } else
            {
                int newQuestionIndex = rand.Next(selectedMultiChoiceList.Count);
                MultiChoice newQuestion = selectedMultiChoiceList[newQuestionIndex];
                string newQuestionId = newQuestion.Id;

                while (askedQuestionIds.Contains(newQuestionId))
                {
                    newQuestionIndex = rand.Next(selectedMultiChoiceList.Count);
                    newQuestion = selectedMultiChoiceList[newQuestionIndex];
                    newQuestionId = newQuestion.Id;
                }
                currentQuestionType = "multi-choice";
                currentQuestionIndex = newQuestionIndex;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataFile(mcqFilePath, "true-false-questions");
            RefreshLeaderboardDgv();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string nameInput = txtUsername.Text;
            if (nameInput != "")
            {
                playerName = nameInput;
            } else
            {
                MessageBox.Show("Your username can't be empty :(");
            }
        }
    }
}
