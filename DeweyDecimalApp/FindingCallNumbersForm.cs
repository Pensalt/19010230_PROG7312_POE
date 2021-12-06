using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyDecimalApp
{
    public partial class FindingCallNumbersForm : Form
    {
        // Global variables.
        CallNumberClassifications c = new CallNumberClassifications();
        bool canBack = true; // Controls if the user can go back to the menu or not.
        string userName;
        int qCount = 0;
        string message;
        CallNumberClassifications q;
        CallNumberClassifications a;
        int streak;
        List<CallNumberClassifications> TreeValues;


        public FindingCallNumbersForm()
        {
            InitializeComponent();
            canBack = true;
            // Setting tool tips.
            toolTipHelp.SetToolTip(btnFinish, "Click here to end your round.");
            toolTipHelp.SetToolTip(btnSelectAnswer, "Click here to select your answer.");
            toolTipHelp.SetToolTip(tbQuestion, "The third level value will appear here.");
            toolTipHelp.SetToolTip(btnBack, "Click here to return to the menu.");
            toolTipHelp.SetToolTip(btnStart, "Click here to start the game.");
            toolTipHelp.SetToolTip(tbUserName, "Enter your username here.");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnFinish.Enabled = false; // User must not be able to click the finish button mid game.
            userName = tbUserName.Text.Trim();
            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your username!", "Alert");
            }
            else
            {
                qCount = 0;
                PopulateValues();
                canBack = false; // User cannot go back to the menu mid game.
                tbUserName.Enabled = false;
                btnStart.Enabled = false;
                btnFinish.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (canBack)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please finish the game before returning to the menu!", "Alert");
            }
        }

        public void PopulateValues()
        {
            lbAnswers.Items.Clear(); // Clearing the list.
            if (qCount == 0)
            {
                TreeValues = c.GetRandomQA();

                tbQuestion.Text = TreeValues.ElementAt(0).Description; // Setting the questions.

                for (int i = 1; i < 5; i++)
                {
                    lbAnswers.Items.Add(TreeValues.ElementAt(i).ToString());
                }

                qCount++; // Controls if the question shows top level or second level values.
            }
            else
            {
                for (int i = 5; i < TreeValues.Count; i++)
                {
                    lbAnswers.Items.Add(TreeValues.ElementAt(i).ToString());
                }

                qCount--;
            }
        }


        private void btnSelectAnswer_Click(object sender, EventArgs e)
        {
            // Handling if the user has the right answer to proceed or if the user has lost the game.
            if (lbAnswers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an answer!", "Alert");
            }
            else
            {
                if (CheckAnswer())
                {
                    MessageBox.Show(message, "Congratulations!");

                    if (qCount == 0)
                    {
                        streak++;
                    }
                    PopulateValues(); // Filling in the questions.
                }
                else
                {
                    MessageBox.Show($"{message}\nThank you for playing! Click restart to go again.",":(");

                    HandleScores();
                    lbAnswers.Items.Clear();
                    btnStart.Text = "Restart";
                    canBack = true;
                    tbUserName.Enabled = true;
                    btnStart.Enabled = true;
                    Housekeeping();
                }
            }
        }

        // Method to check user answer
        public bool CheckAnswer()
        {
            q = TreeValues.ElementAt(0);
            if (qCount == 1)
            {
                a = TreeValues.ElementAt(lbAnswers.SelectedIndex + 1);
                message = c.CheckAnswerTopLevel(a, q).message; // Appropriate response according to result.
                
                return c.CheckAnswerTopLevel(a, q).correct;
            }
            else
            {
                a = TreeValues.ElementAt(lbAnswers.SelectedIndex + 5);
                message = c.CheckAnswerSecondLevel(a, q).message;

                return c.CheckAnswerSecondLevel(a, q).correct;
            }
        }

        // Method to handle the scores.
        public void HandleScores()
        {
            FindingCallNumbersScores scores = new FindingCallNumbersScores(streak, userName);
            List<FindingCallNumbersScores> listScores = scores.ReadHighScores();

            if (scores.IsScoreHigher(listScores, scores))
            {
                scores.UpdateLeaderboard(listScores, scores);
                MessageBox.Show($"Congratulations, {userName}, you achieved a highscore with a streak of {streak}!", "YAY");
                MessageBox.Show(scores.DisplayHighScores(), "High Scores");
            }
            else
            {
                MessageBox.Show("Unfortunately you did not achieve a high score! Please try again.", ":(");
            }

            streak = 0;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing!", ":)");

            HandleScores();
            Housekeeping();
            canBack = true;
            qCount = 0;
        }

        // Housekeeping tasks.
        public void Housekeeping()
        {
            lbAnswers.Items.Clear();
            tbUserName.Clear();
            tbQuestion.Clear();
        }
    }
}
