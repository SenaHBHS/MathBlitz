namespace MathBlitz
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcCore = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblSuperTitle = new System.Windows.Forms.Label();
            this.tabQuizMode = new System.Windows.Forms.TabPage();
            this.flwQuizModes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRookie = new System.Windows.Forms.Button();
            this.btnVeteran = new System.Windows.Forms.Button();
            this.btnGrandmaster = new System.Windows.Forms.Button();
            this.lblSelectInstruction = new System.Windows.Forms.Label();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.lblPiPoints = new System.Windows.Forms.Label();
            this.flwTopRowControls = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabEndScreen = new System.Windows.Forms.TabPage();
            this.flwStatsValues = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPiScore = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.flwStatsLabels = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalPiPoints = new System.Windows.Forms.Label();
            this.lblRankText = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.tmrQuestion = new System.Windows.Forms.Timer(this.components);
            this.tbcCore.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabQuizMode.SuspendLayout();
            this.flwQuizModes.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.flwTopRowControls.SuspendLayout();
            this.tabEndScreen.SuspendLayout();
            this.flwStatsValues.SuspendLayout();
            this.flwStatsLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCore
            // 
            this.tbcCore.Controls.Add(this.tabWelcome);
            this.tbcCore.Controls.Add(this.tabQuizMode);
            this.tbcCore.Controls.Add(this.tabQuestion);
            this.tbcCore.Controls.Add(this.tabEndScreen);
            this.tbcCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCore.Location = new System.Drawing.Point(0, 0);
            this.tbcCore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcCore.Name = "tbcCore";
            this.tbcCore.SelectedIndex = 0;
            this.tbcCore.Size = new System.Drawing.Size(1084, 561);
            this.tbcCore.TabIndex = 0;
            // 
            // tabWelcome
            // 
            this.tabWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabWelcome.Controls.Add(this.btnInstructions);
            this.tabWelcome.Controls.Add(this.lblUsername);
            this.tabWelcome.Controls.Add(this.btnStartGame);
            this.tabWelcome.Controls.Add(this.txtUsername);
            this.tabWelcome.Controls.Add(this.lblTagline);
            this.tabWelcome.Controls.Add(this.lblSuperTitle);
            this.tabWelcome.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWelcome.Location = new System.Drawing.Point(4, 27);
            this.tabWelcome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWelcome.Size = new System.Drawing.Size(1076, 530);
            this.tabWelcome.TabIndex = 0;
            this.tabWelcome.Text = "Welcome";
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.btnInstructions.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(463, 391);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(159, 32);
            this.btnInstructions.TabIndex = 5;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(489, 249);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username: ";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.Location = new System.Drawing.Point(438, 429);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(209, 56);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Quiz!";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(465, 275);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(154, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.Location = new System.Drawing.Point(389, 121);
            this.lblTagline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(306, 33);
            this.lblTagline.TabIndex = 1;
            this.lblTagline.Text = "Speedy Level 3 Calculus";
            // 
            // lblSuperTitle
            // 
            this.lblSuperTitle.AutoSize = true;
            this.lblSuperTitle.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperTitle.Location = new System.Drawing.Point(382, 44);
            this.lblSuperTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuperTitle.Name = "lblSuperTitle";
            this.lblSuperTitle.Size = new System.Drawing.Size(320, 77);
            this.lblSuperTitle.TabIndex = 0;
            this.lblSuperTitle.Text = "Math Blitz";
            // 
            // tabQuizMode
            // 
            this.tabQuizMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabQuizMode.Controls.Add(this.flwQuizModes);
            this.tabQuizMode.Controls.Add(this.lblSelectInstruction);
            this.tabQuizMode.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.tabQuizMode.Location = new System.Drawing.Point(4, 27);
            this.tabQuizMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuizMode.Name = "tabQuizMode";
            this.tabQuizMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuizMode.Size = new System.Drawing.Size(1076, 530);
            this.tabQuizMode.TabIndex = 1;
            this.tabQuizMode.Text = "Select Mode";
            // 
            // flwQuizModes
            // 
            this.flwQuizModes.Controls.Add(this.btnRookie);
            this.flwQuizModes.Controls.Add(this.btnVeteran);
            this.flwQuizModes.Controls.Add(this.btnGrandmaster);
            this.flwQuizModes.Location = new System.Drawing.Point(253, 225);
            this.flwQuizModes.Name = "flwQuizModes";
            this.flwQuizModes.Size = new System.Drawing.Size(570, 101);
            this.flwQuizModes.TabIndex = 4;
            // 
            // btnRookie
            // 
            this.btnRookie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btnRookie.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRookie.Location = new System.Drawing.Point(20, 20);
            this.btnRookie.Margin = new System.Windows.Forms.Padding(20);
            this.btnRookie.Name = "btnRookie";
            this.btnRookie.Size = new System.Drawing.Size(150, 60);
            this.btnRookie.TabIndex = 1;
            this.btnRookie.Text = "Rookie";
            this.btnRookie.UseVisualStyleBackColor = false;
            this.btnRookie.Click += new System.EventHandler(this.btnRookie_Click);
            // 
            // btnVeteran
            // 
            this.btnVeteran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.btnVeteran.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.btnVeteran.Location = new System.Drawing.Point(210, 20);
            this.btnVeteran.Margin = new System.Windows.Forms.Padding(20);
            this.btnVeteran.Name = "btnVeteran";
            this.btnVeteran.Size = new System.Drawing.Size(150, 60);
            this.btnVeteran.TabIndex = 2;
            this.btnVeteran.Text = "Veteran";
            this.btnVeteran.UseVisualStyleBackColor = false;
            this.btnVeteran.Click += new System.EventHandler(this.btnVeteran_Click);
            // 
            // btnGrandmaster
            // 
            this.btnGrandmaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.btnGrandmaster.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.btnGrandmaster.Location = new System.Drawing.Point(400, 20);
            this.btnGrandmaster.Margin = new System.Windows.Forms.Padding(20);
            this.btnGrandmaster.Name = "btnGrandmaster";
            this.btnGrandmaster.Size = new System.Drawing.Size(150, 60);
            this.btnGrandmaster.TabIndex = 3;
            this.btnGrandmaster.Text = "Grandmaster";
            this.btnGrandmaster.UseVisualStyleBackColor = false;
            this.btnGrandmaster.Click += new System.EventHandler(this.btnGrandmaster_Click);
            // 
            // lblSelectInstruction
            // 
            this.lblSelectInstruction.AutoSize = true;
            this.lblSelectInstruction.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInstruction.Location = new System.Drawing.Point(440, 143);
            this.lblSelectInstruction.Name = "lblSelectInstruction";
            this.lblSelectInstruction.Size = new System.Drawing.Size(205, 33);
            this.lblSelectInstruction.TabIndex = 0;
            this.lblSelectInstruction.Text = "Select Difficulty";
            // 
            // tabQuestion
            // 
            this.tabQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabQuestion.Controls.Add(this.lblPiPoints);
            this.tabQuestion.Controls.Add(this.flwTopRowControls);
            this.tabQuestion.Controls.Add(this.btnContinue);
            this.tabQuestion.Controls.Add(this.btnOptionFour);
            this.tabQuestion.Controls.Add(this.btnOptionThree);
            this.tabQuestion.Controls.Add(this.btnOptionTwo);
            this.tabQuestion.Controls.Add(this.btnOptionOne);
            this.tabQuestion.Controls.Add(this.lblQuestion);
            this.tabQuestion.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.tabQuestion.Location = new System.Drawing.Point(4, 27);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(1076, 530);
            this.tabQuestion.TabIndex = 2;
            this.tabQuestion.Text = "Question";
            // 
            // lblPiPoints
            // 
            this.lblPiPoints.AutoSize = true;
            this.lblPiPoints.Location = new System.Drawing.Point(975, 20);
            this.lblPiPoints.Name = "lblPiPoints";
            this.lblPiPoints.Size = new System.Drawing.Size(36, 23);
            this.lblPiPoints.TabIndex = 11;
            this.lblPiPoints.Text = "100";
            // 
            // flwTopRowControls
            // 
            this.flwTopRowControls.Controls.Add(this.lblQuestionCount);
            this.flwTopRowControls.Controls.Add(this.lblElapsedTime);
            this.flwTopRowControls.Location = new System.Drawing.Point(62, 20);
            this.flwTopRowControls.Name = "flwTopRowControls";
            this.flwTopRowControls.Size = new System.Drawing.Size(952, 28);
            this.flwTopRowControls.TabIndex = 10;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(3, 0);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(40, 23);
            this.lblQuestionCount.TabIndex = 2;
            this.lblQuestionCount.Text = "1/10";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(446, 0);
            this.lblElapsedTime.Margin = new System.Windows.Forms.Padding(400, 0, 400, 0);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(50, 23);
            this.lblElapsedTime.TabIndex = 3;
            this.lblElapsedTime.Text = "01:30";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.btnContinue.Location = new System.Drawing.Point(142, 446);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(773, 51);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOptionFour
            // 
            this.btnOptionFour.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionFour.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionFour.Location = new System.Drawing.Point(565, 317);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(350, 90);
            this.btnOptionFour.TabIndex = 8;
            this.btnOptionFour.Text = "Option";
            this.btnOptionFour.UseVisualStyleBackColor = false;
            this.btnOptionFour.Click += new System.EventHandler(this.btnOptionFour_Click);
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionThree.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionThree.Location = new System.Drawing.Point(142, 317);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(350, 90);
            this.btnOptionThree.TabIndex = 7;
            this.btnOptionThree.Text = "Option";
            this.btnOptionThree.UseVisualStyleBackColor = false;
            this.btnOptionThree.Click += new System.EventHandler(this.btnOptionThree_Click);
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.btnOptionTwo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionTwo.Location = new System.Drawing.Point(565, 192);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(350, 90);
            this.btnOptionTwo.TabIndex = 6;
            this.btnOptionTwo.Text = "Option";
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            this.btnOptionTwo.Click += new System.EventHandler(this.btnOptionTwo_Click);
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btnOptionOne.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionOne.Location = new System.Drawing.Point(142, 192);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(350, 90);
            this.btnOptionOne.TabIndex = 5;
            this.btnOptionOne.Text = "Option";
            this.btnOptionOne.UseVisualStyleBackColor = false;
            this.btnOptionOne.Click += new System.EventHandler(this.btnOptionOne_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(417, 95);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(243, 33);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What is Math Blitz?";
            // 
            // tabEndScreen
            // 
            this.tabEndScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabEndScreen.Controls.Add(this.flwStatsValues);
            this.tabEndScreen.Controls.Add(this.flwStatsLabels);
            this.tabEndScreen.Controls.Add(this.btnNewGame);
            this.tabEndScreen.Controls.Add(this.dgvLeaderboard);
            this.tabEndScreen.Controls.Add(this.lblCongrats);
            this.tabEndScreen.Controls.Add(this.lblAccuracy);
            this.tabEndScreen.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.tabEndScreen.Location = new System.Drawing.Point(4, 27);
            this.tabEndScreen.Name = "tabEndScreen";
            this.tabEndScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndScreen.Size = new System.Drawing.Size(1076, 530);
            this.tabEndScreen.TabIndex = 3;
            this.tabEndScreen.Text = "Congrats";
            // 
            // flwStatsValues
            // 
            this.flwStatsValues.Controls.Add(this.lblPiScore);
            this.flwStatsValues.Controls.Add(this.lblRank);
            this.flwStatsValues.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwStatsValues.Location = new System.Drawing.Point(861, 256);
            this.flwStatsValues.Name = "flwStatsValues";
            this.flwStatsValues.Size = new System.Drawing.Size(85, 70);
            this.flwStatsValues.TabIndex = 9;
            // 
            // lblPiScore
            // 
            this.lblPiScore.AutoSize = true;
            this.lblPiScore.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiScore.Location = new System.Drawing.Point(3, 5);
            this.lblPiScore.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblPiScore.Name = "lblPiScore";
            this.lblPiScore.Size = new System.Drawing.Size(63, 29);
            this.lblPiScore.TabIndex = 6;
            this.lblPiScore.Text = "100π";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(3, 39);
            this.lblRank.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(40, 29);
            this.lblRank.TabIndex = 7;
            this.lblRank.Text = "#2";
            // 
            // flwStatsLabels
            // 
            this.flwStatsLabels.Controls.Add(this.lblTotalPiPoints);
            this.flwStatsLabels.Controls.Add(this.lblRankText);
            this.flwStatsLabels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwStatsLabels.Location = new System.Drawing.Point(678, 256);
            this.flwStatsLabels.Name = "flwStatsLabels";
            this.flwStatsLabels.Size = new System.Drawing.Size(177, 70);
            this.flwStatsLabels.TabIndex = 8;
            // 
            // lblTotalPiPoints
            // 
            this.lblTotalPiPoints.AutoSize = true;
            this.lblTotalPiPoints.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPiPoints.Location = new System.Drawing.Point(3, 5);
            this.lblTotalPiPoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTotalPiPoints.Name = "lblTotalPiPoints";
            this.lblTotalPiPoints.Size = new System.Drawing.Size(166, 29);
            this.lblTotalPiPoints.TabIndex = 4;
            this.lblTotalPiPoints.Text = "Total Pi Score:";
            // 
            // lblRankText
            // 
            this.lblRankText.AutoSize = true;
            this.lblRankText.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankText.Location = new System.Drawing.Point(3, 39);
            this.lblRankText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRankText.Name = "lblRankText";
            this.lblRankText.Size = new System.Drawing.Size(73, 29);
            this.lblRankText.TabIndex = 5;
            this.lblRankText.Text = "Rank:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.btnNewGame.Location = new System.Drawing.Point(716, 459);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(169, 44);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.AllowUserToResizeRows = false;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(28, 28);
            this.dgvLeaderboard.MultiSelect = false;
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(464, 475);
            this.dgvLeaderboard.TabIndex = 2;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(688, 28);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(228, 33);
            this.lblCongrats.TabIndex = 1;
            this.lblCongrats.Text = "Yay! You Finished!";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.Location = new System.Drawing.Point(749, 61);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(106, 58);
            this.lblAccuracy.TabIndex = 0;
            this.lblAccuracy.Text = "96%";
            // 
            // tmrQuestion
            // 
            this.tmrQuestion.Interval = 1000;
            this.tmrQuestion.Tick += new System.EventHandler(this.tmrQuestion_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.tbcCore);
            this.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Math Blitz";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbcCore.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabQuizMode.ResumeLayout(false);
            this.tabQuizMode.PerformLayout();
            this.flwQuizModes.ResumeLayout(false);
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.flwTopRowControls.ResumeLayout(false);
            this.flwTopRowControls.PerformLayout();
            this.tabEndScreen.ResumeLayout(false);
            this.tabEndScreen.PerformLayout();
            this.flwStatsValues.ResumeLayout(false);
            this.flwStatsValues.PerformLayout();
            this.flwStatsLabels.ResumeLayout(false);
            this.flwStatsLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCore;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.TabPage tabQuizMode;
        private System.Windows.Forms.Label lblSuperTitle;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSelectInstruction;
        private System.Windows.Forms.Button btnRookie;
        private System.Windows.Forms.Button btnVeteran;
        private System.Windows.Forms.Button btnGrandmaster;
        private System.Windows.Forms.TabPage tabQuestion;
        private System.Windows.Forms.TabPage tabEndScreen;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblTotalPiPoints;
        private System.Windows.Forms.Label lblRankText;
        private System.Windows.Forms.FlowLayoutPanel flwQuizModes;
        private System.Windows.Forms.FlowLayoutPanel flwTopRowControls;
        private System.Windows.Forms.Label lblPiScore;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.FlowLayoutPanel flwStatsLabels;
        private System.Windows.Forms.FlowLayoutPanel flwStatsValues;
        private System.Windows.Forms.Timer tmrQuestion;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblPiPoints;
    }
}

