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

        public frmMain()
        {
            InitializeComponent();
        }
        private void RefreshLeaderboardDgv()
        {
            dgvLeaderboard.DataSource = null;
            dgvLeaderboard.DataSource = null; // wire up the data list later
        }

        private void LoadDataFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string line;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        // TrueFalse newEntry = new TrueFalse(...fields);
                        // dataList.Add(newEntry);
                    }
                }
            }
        }
    }
}
