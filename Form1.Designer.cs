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
            this.tbcCore = new System.Windows.Forms.TabControl();
            this.tabWelcom = new System.Windows.Forms.TabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSuperTitle = new System.Windows.Forms.Label();
            this.tabQuizMode = new System.Windows.Forms.TabPage();
            this.btnGrandmaster = new System.Windows.Forms.Button();
            this.btnVeteran = new System.Windows.Forms.Button();
            this.btnRookie = new System.Windows.Forms.Button();
            this.lblSelectInstruction = new System.Windows.Forms.Label();
            this.tabQuestion = new System.Windows.Forms.TabPage();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOptionFour = new System.Windows.Forms.Button();
            this.btnOptionThree = new System.Windows.Forms.Button();
            this.btnOptionTwo = new System.Windows.Forms.Button();
            this.btnOptionOne = new System.Windows.Forms.Button();
            this.lblPiPoints = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabEndScreen = new System.Windows.Forms.TabPage();
            this.lblLeaderboardPos = new System.Windows.Forms.Label();
            this.lblTotalPiPoints = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.flwQuizModes = new System.Windows.Forms.FlowLayoutPanel();
            this.tbcCore.SuspendLayout();
            this.tabWelcom.SuspendLayout();
            this.tabQuizMode.SuspendLayout();
            this.tabQuestion.SuspendLayout();
            this.tabEndScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.flwQuizModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCore
            // 
            this.tbcCore.Controls.Add(this.tabWelcom);
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
            // tabWelcom
            // 
            this.tabWelcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabWelcom.Controls.Add(this.lblUsername);
            this.tabWelcom.Controls.Add(this.btnStartGame);
            this.tabWelcom.Controls.Add(this.textBox1);
            this.tabWelcom.Controls.Add(this.lblWelcome);
            this.tabWelcom.Controls.Add(this.lblSuperTitle);
            this.tabWelcom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWelcom.Location = new System.Drawing.Point(4, 27);
            this.tabWelcom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWelcom.Name = "tabWelcom";
            this.tabWelcom.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWelcom.Size = new System.Drawing.Size(1076, 530);
            this.tabWelcom.TabIndex = 0;
            this.tabWelcom.Text = "Welcome";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(391, 271);
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
            this.btnStartGame.Location = new System.Drawing.Point(486, 327);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(120, 32);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Quiz!";
            this.btnStartGame.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(506, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(488, 199);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(102, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblSuperTitle
            // 
            this.lblSuperTitle.AutoSize = true;
            this.lblSuperTitle.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperTitle.Location = new System.Drawing.Point(368, 96);
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
            // 
            // lblSelectInstruction
            // 
            this.lblSelectInstruction.AutoSize = true;
            this.lblSelectInstruction.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInstruction.Location = new System.Drawing.Point(406, 107);
            this.lblSelectInstruction.Name = "lblSelectInstruction";
            this.lblSelectInstruction.Size = new System.Drawing.Size(222, 33);
            this.lblSelectInstruction.TabIndex = 0;
            this.lblSelectInstruction.Text = "Select Quiz Mode";
            // 
            // tabQuestion
            // 
            this.tabQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabQuestion.Controls.Add(this.btnContinue);
            this.tabQuestion.Controls.Add(this.btnOptionFour);
            this.tabQuestion.Controls.Add(this.btnOptionThree);
            this.tabQuestion.Controls.Add(this.btnOptionTwo);
            this.tabQuestion.Controls.Add(this.btnOptionOne);
            this.tabQuestion.Controls.Add(this.lblPiPoints);
            this.tabQuestion.Controls.Add(this.lblElapsedTime);
            this.tabQuestion.Controls.Add(this.lblQuestionCount);
            this.tabQuestion.Controls.Add(this.lblQuestion);
            this.tabQuestion.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.tabQuestion.Location = new System.Drawing.Point(4, 27);
            this.tabQuestion.Name = "tabQuestion";
            this.tabQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestion.Size = new System.Drawing.Size(1076, 530);
            this.tabQuestion.TabIndex = 2;
            this.tabQuestion.Text = "Question";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(226)))), ((int)(((byte)(235)))));
            this.btnContinue.Location = new System.Drawing.Point(134, 437);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(773, 34);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // btnOptionFour
            // 
            this.btnOptionFour.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionFour.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionFour.Location = new System.Drawing.Point(557, 317);
            this.btnOptionFour.Name = "btnOptionFour";
            this.btnOptionFour.Size = new System.Drawing.Size(350, 90);
            this.btnOptionFour.TabIndex = 8;
            this.btnOptionFour.Text = "Option";
            this.btnOptionFour.UseVisualStyleBackColor = false;
            // 
            // btnOptionThree
            // 
            this.btnOptionThree.BackColor = System.Drawing.Color.Transparent;
            this.btnOptionThree.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionThree.Location = new System.Drawing.Point(134, 317);
            this.btnOptionThree.Name = "btnOptionThree";
            this.btnOptionThree.Size = new System.Drawing.Size(350, 90);
            this.btnOptionThree.TabIndex = 7;
            this.btnOptionThree.Text = "Option";
            this.btnOptionThree.UseVisualStyleBackColor = false;
            // 
            // btnOptionTwo
            // 
            this.btnOptionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(155)))), ((int)(((byte)(147)))));
            this.btnOptionTwo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionTwo.Location = new System.Drawing.Point(557, 192);
            this.btnOptionTwo.Name = "btnOptionTwo";
            this.btnOptionTwo.Size = new System.Drawing.Size(350, 90);
            this.btnOptionTwo.TabIndex = 6;
            this.btnOptionTwo.Text = "Option";
            this.btnOptionTwo.UseVisualStyleBackColor = false;
            // 
            // btnOptionOne
            // 
            this.btnOptionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btnOptionOne.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionOne.Location = new System.Drawing.Point(134, 192);
            this.btnOptionOne.Name = "btnOptionOne";
            this.btnOptionOne.Size = new System.Drawing.Size(350, 90);
            this.btnOptionOne.TabIndex = 5;
            this.btnOptionOne.Text = "Option";
            this.btnOptionOne.UseVisualStyleBackColor = false;
            // 
            // lblPiPoints
            // 
            this.lblPiPoints.AutoSize = true;
            this.lblPiPoints.Location = new System.Drawing.Point(939, 29);
            this.lblPiPoints.Name = "lblPiPoints";
            this.lblPiPoints.Size = new System.Drawing.Size(49, 23);
            this.lblPiPoints.TabIndex = 4;
            this.lblPiPoints.Text = "100π";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(490, 29);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(50, 23);
            this.lblElapsedTime.TabIndex = 3;
            this.lblElapsedTime.Text = "01:30";
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(26, 29);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(40, 23);
            this.lblQuestionCount.TabIndex = 2;
            this.lblQuestionCount.Text = "1/10";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(396, 111);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(243, 33);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What is Math Blitz?";
            // 
            // tabEndScreen
            // 
            this.tabEndScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.tabEndScreen.Controls.Add(this.lblLeaderboardPos);
            this.tabEndScreen.Controls.Add(this.lblTotalPiPoints);
            this.tabEndScreen.Controls.Add(this.btnStart);
            this.tabEndScreen.Controls.Add(this.dgvLeaderboard);
            this.tabEndScreen.Controls.Add(this.lblCongrats);
            this.tabEndScreen.Controls.Add(this.label1);
            this.tabEndScreen.Controls.Add(this.lblAccuracy);
            this.tabEndScreen.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.tabEndScreen.Location = new System.Drawing.Point(4, 27);
            this.tabEndScreen.Name = "tabEndScreen";
            this.tabEndScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndScreen.Size = new System.Drawing.Size(1076, 530);
            this.tabEndScreen.TabIndex = 3;
            this.tabEndScreen.Text = "Congrats";
            // 
            // lblLeaderboardPos
            // 
            this.lblLeaderboardPos.AutoSize = true;
            this.lblLeaderboardPos.Location = new System.Drawing.Point(552, 239);
            this.lblLeaderboardPos.Name = "lblLeaderboardPos";
            this.lblLeaderboardPos.Size = new System.Drawing.Size(190, 23);
            this.lblLeaderboardPos.TabIndex = 5;
            this.lblLeaderboardPos.Text = "Leaderboard Position";
            // 
            // lblTotalPiPoints
            // 
            this.lblTotalPiPoints.AutoSize = true;
            this.lblTotalPiPoints.Location = new System.Drawing.Point(553, 205);
            this.lblTotalPiPoints.Name = "lblTotalPiPoints";
            this.lblTotalPiPoints.Size = new System.Drawing.Size(174, 23);
            this.lblTotalPiPoints.TabIndex = 4;
            this.lblTotalPiPoints.Text = "Total Pi Score: 100π";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(221)))));
            this.btnStart.Location = new System.Drawing.Point(621, 427);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(169, 44);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "New Game";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(49, 30);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.Size = new System.Drawing.Size(437, 450);
            this.dgvLeaderboard.TabIndex = 2;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Location = new System.Drawing.Point(628, 51);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(162, 23);
            this.lblCongrats.TabIndex = 1;
            this.lblCongrats.Text = "Yay! You Finished!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "96%";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.Location = new System.Drawing.Point(677, 104);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(70, 39);
            this.lblAccuracy.TabIndex = 0;
            this.lblAccuracy.Text = "96%";
            // 
            // flwQuizModes
            // 
            this.flwQuizModes.Controls.Add(this.btnRookie);
            this.flwQuizModes.Controls.Add(this.btnVeteran);
            this.flwQuizModes.Controls.Add(this.btnGrandmaster);
            this.flwQuizModes.Location = new System.Drawing.Point(239, 189);
            this.flwQuizModes.Name = "flwQuizModes";
            this.flwQuizModes.Size = new System.Drawing.Size(570, 101);
            this.flwQuizModes.TabIndex = 4;
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
            this.tbcCore.ResumeLayout(false);
            this.tabWelcom.ResumeLayout(false);
            this.tabWelcom.PerformLayout();
            this.tabQuizMode.ResumeLayout(false);
            this.tabQuizMode.PerformLayout();
            this.tabQuestion.ResumeLayout(false);
            this.tabQuestion.PerformLayout();
            this.tabEndScreen.ResumeLayout(false);
            this.tabEndScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.flwQuizModes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCore;
        private System.Windows.Forms.TabPage tabWelcom;
        private System.Windows.Forms.TabPage tabQuizMode;
        private System.Windows.Forms.Label lblSuperTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label lblPiPoints;
        private System.Windows.Forms.Button btnOptionOne;
        private System.Windows.Forms.Button btnOptionFour;
        private System.Windows.Forms.Button btnOptionThree;
        private System.Windows.Forms.Button btnOptionTwo;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPiPoints;
        private System.Windows.Forms.Label lblLeaderboardPos;
        private System.Windows.Forms.FlowLayoutPanel flwQuizModes;
    }
}

