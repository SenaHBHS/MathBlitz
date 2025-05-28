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
        List<MultiChoice> selectedMultiChoiceList; // multi choice questions based on the selected level
        List<TrueFalse> selectedTrueFalseList; // true false questions based on the selected level
        int questionsCount = 15; // 15 is the default number and if the questions available is less than that questionsCount changes
        int trueFalseQuota = 6; // maximum number of true false questions that can be asked
        int nTrueFalseAsked = 0; // the number of true false questions asked
        List<string> trueFalseOptions = new List<string> { "True", "False" };
        List<string> askedQuestionIds = new List<string>();
        string currentQuestionType; // "multi-choice" or "true-false"
        TrueFalse currentTrueFalseQuestion;
        MultiChoice currentMultiChoiceQuestion;
        int elapsedSeconds = 0;
        int piScore = 0;
        int correctAnswerCount = 0; // the number of correct answeres
        
        // common color values
        Color red = ColorTranslator.FromHtml("#FC9B93");
        Color green = ColorTranslator.FromHtml("#B8F2E6");
        Color blue = ColorTranslator.FromHtml("#A7E2EB");

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
                                            Array.Copy(fields, baseFieldsNumber, options, 0, mcqOptionsCount);

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
            } else
            {
                LogError($"File {filePath}: Not Found");
            }
        }

        /// <summary>
        /// aligns a label to the centre relative to the tab space
        /// </summary>
        /// <param name="lbl">label to be aligned</param>
        private void CenterAlignLabel(Label lbl)
        {
            lbl.Location = new Point((tabQuestion.Width - lbl.Width) / 2, lbl.Location.Y);
        }

        /// <summary>
        /// loads the selected level
        /// </summary>
        /// <param name="level">"Rookie", "Veteran" or "Grandmaster"</param>
        private void SelectLevel(string level)
        {
            selectedLevel = level;

            // loading the questions for the chosen level
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

            // displaying the questions tab and starting the questions
            ResetTabs();
            tbcCore.TabPages.Add(tabQuestion);
            LoadNewQuestion();
        }

        /// <summary>
        /// enables the question option buttons and their responses
        /// </summary>
        private void EnableOptionButtons()
        {
            btnOptionOne.Enabled = true;
            btnOptionTwo.Enabled = true;
            btnOptionThree.Enabled = true;
            btnOptionFour.Enabled = true;
        }

        /// <summary>
        /// disables question option buttons
        /// </summary>
        private void DisableOptionButtons() {
            btnOptionOne.Enabled = false;
            btnOptionTwo.Enabled = false;
            btnOptionThree.Enabled = false;
            btnOptionFour.Enabled = false;
        }

        /// <summary>
        /// sets up the ui and display a multi choice question
        /// </summary>
        private void DisplayMutliChoiceQuestion()
        {
            // question text
            lblQuestion.Text = currentMultiChoiceQuestion.QuestionText;

            // options text
            btnOptionOne.Text = currentMultiChoiceQuestion.Options[0];
            btnOptionTwo.Text = currentMultiChoiceQuestion.Options[1];
            btnOptionThree.Text = currentMultiChoiceQuestion.Options[2];
            btnOptionFour.Text = currentMultiChoiceQuestion.Options[3];
        }

        /// <summary>
        /// sets up the ui and display a true false choice question
        /// </summary>
        private void DisplayTrueFalseQuestion()
        {
            // question text
            lblQuestion.Text = currentTrueFalseQuestion.QuestionText;

            // options text
            btnOptionOne.Text = trueFalseOptions[0];
            btnOptionTwo.Text = trueFalseOptions[1];
        }

        /// <summary>
        /// sets up the ui to load either a true false or a multi choice question
        /// </summary>
        private void SetUpQuestionUI()
        {
            EnableOptionButtons();

            // showing the question
            if (currentQuestionType == "multi-choice")
            {
                btnOptionThree.Show();
                btnOptionFour.Show();

                DisplayMutliChoiceQuestion();

            } else
            {
                btnOptionThree.Hide();
                btnOptionFour.Hide();

                DisplayTrueFalseQuestion();
            }

            // hiding the continue button
            btnContinue.Hide();

            // displaying the elapsed time
            elapsedSeconds = 0;
            lblElapsedTime.Text = "00:00";
            tmrQuestion.Start();

            // loading the question
            lblQuestionCount.Text = $"{askedQuestionIds.Count}/{questionsCount}";
            CenterAlignLabel(lblQuestion);


            // setting pi points
            lblPiPoints.Show();
            lblPiPoints.Text = $"{piScore}π";
            
            // setting button colors
            btnOptionOne.BackColor = Color.Transparent;
            btnOptionTwo.BackColor = Color.Transparent;
            btnOptionThree.BackColor = Color.Transparent;
            btnOptionFour.BackColor = Color.Transparent;
            btnContinue.BackColor = blue;
        }

        /// <summary>
        /// loads a new question
        /// </summary>
        private void LoadNewQuestion()
        {
            Random rand = new Random();
            int newQuestionType; // 0 - true false question, 1 - multi choice question

            // randomly choosing the newQuestionType
            if (nTrueFalseAsked < trueFalseQuota)
            {
                newQuestionType = rand.Next(2);
            }
            else
            {
                newQuestionType = 1;
            }

            // loading a question from the chosen question type
            if (newQuestionType == 0)
            {
                // loading a new true false question
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
                currentTrueFalseQuestion = newQuestion;
                askedQuestionIds.Add(newQuestionId);
            }
            else
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
                currentMultiChoiceQuestion = newQuestion;
                askedQuestionIds.Add(newQuestionId);
            }

            // setting up the UI and displaying the quesiton
            SetUpQuestionUI();
        }

        private void UpdateScore()
        {
            int baseScore;
            double questionTimeLimit;
            if (currentQuestionType == "multi-choice")
            {
                baseScore = currentMultiChoiceQuestion.Score;
                questionTimeLimit = currentMultiChoiceQuestion.TimeLimit * 60;
            } else
            {
                baseScore = currentTrueFalseQuestion.Score;
                questionTimeLimit = currentTrueFalseQuestion.TimeLimit * 60;
            }

            if (elapsedSeconds >= questionTimeLimit)
            {
                piScore += baseScore;
            } else
            {
                double remainingTime = questionTimeLimit - elapsedSeconds;
                double extraPoints = Math.Round((remainingTime / questionTimeLimit) * (baseScore * 4));
                piScore += (int)extraPoints + baseScore;
            }

            lblPiPoints.Text = $"{piScore}π";
        }

        /// <summary>
        /// turns a given integer number to a 2 digit string
        /// </summary>
        /// <param name="num">an integer below 100</param>
        /// <returns></returns>
        private string GetTwoDigitNumberString(int num)
        {
            if (num < 10)
            {
                return $"0{num}";
            } else
            {
                return num.ToString();
            }
        }

        /// <summary>
        /// displays the elapsed time in the MM:SS format
        /// </summary>
        private void DisplayElapsedTime()
        {
            int nMinutes = elapsedSeconds / 60;
            int nSeconds = elapsedSeconds % 60;
            lblElapsedTime.Text = $"{GetTwoDigitNumberString(nMinutes)}:{GetTwoDigitNumberString(nSeconds)}";
        }

        /// <summary>
        /// changes the background color of an option button
        /// </summary>
        /// <param name="optionNum">option number from 1-4</param>
        /// <param name="color">color object for the background</param>
        private void ColorOptionButton(int optionNum, Color color)
        {
            if (optionNum == 1)
            {
                btnOptionOne.BackColor = color;
            }
            else if (optionNum == 2)
            {
                btnOptionTwo.BackColor = color;
            }
            else if (optionNum == 3)
            {
                btnOptionThree.BackColor = color;
            }
            else
            {
                btnOptionFour.BackColor = color;
            }
        }

        /// <summary>
        /// validates the selected option and gives visual feedback
        /// </summary>
        /// <param name="selectedOption">option number the user selected</param>
        private void ValidateSelectedOption(int selectedOption)
        {
            DisableOptionButtons();
            btnContinue.Show();

            // stopping the question timer
            tmrQuestion.Stop();

            int correctOption;

            // loading the correct option dynamically
            if (currentQuestionType == "multi-choice")
            {
                correctOption = currentMultiChoiceQuestion.AnswerOptionNum;
            } else
            {
                string correctTrueFalseAns = currentTrueFalseQuestion.Answer;
                if (trueFalseOptions[selectedOption - 1].ToLower() == correctTrueFalseAns.ToLower())
                {
                    correctOption = selectedOption;
                } else
                {
                    correctOption = selectedOption == 2 ? 1 : 2;
                }
            }
            
            if (selectedOption == correctOption)
            {
                UpdateScore();
                correctAnswerCount += 1;
                ColorOptionButton(selectedOption, green);
            } else
            {
                ColorOptionButton(selectedOption, red);
                ColorOptionButton(correctOption, green);
            }
        }

        /// <summary>
        /// hides all the tabs
        /// </summary>
        private void ResetTabs()
        {
            tbcCore.TabPages.Remove(tabQuizMode);
            tbcCore.TabPages.Remove(tabQuestion);
            tbcCore.TabPages.Remove(tabEndScreen);
            tbcCore.TabPages.Remove(tabWelcome);
        }

        /// <summary>
        /// validates the player name and starts the quiz
        /// </summary>
        private void StartQuiz()
        {
            string nameInput = txtUsername.Text;
            if (nameInput != "")
            {
                playerName = nameInput;

                // loading the quiz mode tab
                ResetTabs();
                tbcCore.TabPages.Add(tabQuizMode);
            }
            else
            {
                MessageBox.Show("Your username can't be empty :(");
            }
        }

        /// <summary>
        /// shows the end screen
        /// </summary>
        private void EndQuiz()
        {
            ResetTabs();
            tbcCore.TabPages.Add(tabEndScreen);

            // set up the ui
            lblPiScore.Text = $"{piScore}π";
            double accuracy = double.Parse(correctAnswerCount.ToString()) / double.Parse(questionsCount.ToString());
            lblAccuracy.Text = $"{Math.Round(accuracy * 100, 1)}%";
        }

        /// <summary>
        /// starts a new game
        /// </summary>
        private void StartNewGame()
        {
            // resetting main game variables
            playerName = "";
            nTrueFalseAsked = 0; // the number of true false questions asked
            askedQuestionIds = new List<string>(); // emptying the asked questions list

            ResetTabs();
            tbcCore.TabPages.Add(tabWelcome);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataFile(mcqFilePath, "multi-choice-questions");
            LoadDataFile(tfqFilePath, "true-false-questions");

            RefreshLeaderboardDgv();

            ResetTabs();
            tbcCore.TabPages.Add(tabWelcome);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void tmrQuestion_Tick(object sender, EventArgs e)
        {
            elapsedSeconds += 1;
            DisplayElapsedTime();
        }

        private void btnOptionOne_Click(object sender, EventArgs e)
        {
            ValidateSelectedOption(1);
        }

        private void btnOptionTwo_Click(object sender, EventArgs e)
        {
            ValidateSelectedOption(2);
        }

        private void btnOptionThree_Click(object sender, EventArgs e)
        {
            ValidateSelectedOption(3);
        }

        private void btnOptionFour_Click(object sender, EventArgs e)
        {
            ValidateSelectedOption(4);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (askedQuestionIds.Count < questionsCount)
            {
                LoadNewQuestion();
            } else
            {
                EndQuiz();
            }
        }

        private void btnRookie_Click(object sender, EventArgs e)
        {
            SelectLevel("Rookie");
        }

        private void btnVeteran_Click(object sender, EventArgs e)
        {
            SelectLevel("Veteran");
        }

        private void btnGrandmaster_Click(object sender, EventArgs e)
        {
            SelectLevel("Grandmaster");
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartQuiz();
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Select the correct answer to earn pi points\n- The faster you answer the more pi points you get");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
