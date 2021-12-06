using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Numerics;
using System.Linq;

namespace DeweyDecimalApp
{
    public partial class IdentifyingAreasForm : Form
    {
        IdentifyingAreas areas = new IdentifyingAreas(); // Used to access the class' methods.
        int questionType; // Used to alternate between type 1 and type 2 questions.
        Dictionary<string, string> currDictionary; // Used to access the current dictionary storing question data in multiple methods.
        string userName;
        int streak = 0; // Counts the user's correct answer streak.
        bool canBack; // Controls whether the user can exit the form or not via the 'Back' button.
        private static Random randy; // Random variable used when randomising the dictionary.
        List<string> answers; // List of the user's selected answers. Used in a few methods so making it global was necessary.

        public IdentifyingAreasForm()
        {
            InitializeComponent();
            toolTipHelp.SetToolTip(btnBack, "Click here to return to the menu.");
            toolTipHelp.SetToolTip(btnFinish, "Click here to end your game.");
            toolTipHelp.SetToolTip(btnCheckAnswers, "Click here to check your answers.");
            toolTipHelp.SetToolTip(btnStart, "Click here to begin a round of questions.");
            toolTipHelp.SetToolTip(btnBack, "Return to the menu.");
            toolTipHelp.SetToolTip(nudA, "Type in your answer or use the up/down buttons to select the apppropriate number.");
            toolTipHelp.SetToolTip(nudB, "Type in your answer or use the up/down buttons to select the apppropriate number.");
            toolTipHelp.SetToolTip(nudC, "Type in your answer or use the up/down buttons to select the apppropriate number.");
            toolTipHelp.SetToolTip(nudD, "Type in your answer or use the up/down buttons to select the apppropriate number.");
 
        }

        private void IdentifyingAreasForm_Load(object sender, EventArgs e)
        {
            canBack = true; // The user has the power to leave the page before they start the game.
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
                canBack = false; // User cannot go back to the menu mid game.
                tbUserName.Enabled = false;
                Housekeeping(); // Clean up tasks.

                // Users can now interact with Numeric Up Downs again
                nudA.Enabled = true;
                nudB.Enabled = true;
                nudC.Enabled = true;
                nudD.Enabled = true;

                btnCheckAnswers.Enabled = true;
                btnStart.Enabled = false;
                btnStart.Text = "Next Question";
                PopulateColumns();
            }
        }

        public void PopulateColumns()
        {
            questionType++;
            Dictionary<string, string> data = new Dictionary<string, string>();
            List<string> questions = new List<string>();
            answers = new List<string>();

            // Odd numbers are question type 1, even numbers are question type 2.
            if (questionType % 2 == 0)
            {
                data = areas.ReturnQuestionType(2);
            }
            else
            {
                data = areas.ReturnQuestionType(1);
            }

            while (questions.Count < 4)
            {
                randy = new Random();
                int index = randy.Next(data.Count);
                KeyValuePair<string, string> kvp = data.ElementAt(index);

                // No duplicates can be added to the possible answers.
                // It is important to have this as the data set is very small so the chance of duplicates is high.
                if (!questions.Contains(kvp.Key))
                {
                    questions.Add(kvp.Key);
                }
            }

            // All possible answers must be shown.
            foreach (var item in data)
            {
                answers.Add(item.Value);
            }

            // Populating text boxes.
            tbQ1.Text = questions.ElementAt(0);
            tbQ2.Text = questions.ElementAt(1);
            tbQ3.Text = questions.ElementAt(2);
            tbQ4.Text = questions.ElementAt(3);

            tbA1.Text = answers.ElementAt(0);
            tbA2.Text = answers.ElementAt(1);
            tbA3.Text = answers.ElementAt(2);
            tbA4.Text = answers.ElementAt(3);
            tbA5.Text = answers.ElementAt(4);
            tbA6.Text = answers.ElementAt(5);
            tbA7.Text = answers.ElementAt(6);

            currDictionary = data; // data needs to be send to the IdentifyingAreas.cs class.
        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            // No repeptition allowed in the numeric up downs.
            if (nudA.Value == nudB.Value || nudA.Value == nudC.Value || nudA.Value == nudD.Value || nudB.Value == nudC.Value || nudB.Value == nudD.Value || nudC.Value == nudD.Value)
            {
                MessageBox.Show("Please select unique answers!", "Alert");
            }
            else
            {
                // Only some house keeping tasks are needed here.
                btnCheckAnswers.Enabled = false;
                nudA.Enabled = false;
                nudB.Enabled = false;
                nudC.Enabled = false;
                nudD.Enabled = false;

                // Getting questions from text boxes.
                string q1 = tbQ1.Text;
                string q2 = tbQ2.Text;
                string q3 = tbQ3.Text;
                string q4 = tbQ4.Text;

                string a1;
                string a2;
                string a3;
                string a4;

                // Index starts from 0 however questions start at 1 so the minus 1 is required.
                a1 = answers.ElementAt((int)nudA.Value - 1);
                a2 = answers.ElementAt((int)nudB.Value - 1);
                a3 = answers.ElementAt((int)nudC.Value - 1);
                a4 = answers.ElementAt((int)nudD.Value - 1);

                if (areas.CheckAnswers(q1, q2, q3, q4, a1, a2, a3, a4, currDictionary))
                {
                    streak++;
                    MessageBox.Show($"You correctly matched the columns!\nYour current streak is {streak}!\nClick 'Finish' to end your run or 'Next Question' to go again.", "Congratulations!");
                }
                else
                {
                    MessageBox.Show($"You incorrectly matched the columns!\nYou finished with a streak of {streak}!\nLet's see if you got a highscore!", "GAME OVER");
                    HandleScores();
                    btnStart.Text = "Restart";
                    tbUserName.Enabled = true;
                    tbUserName.ResetText();
                    canBack = true; // User can return to the menu after the 'game over' has happened.
                }
                btnStart.Enabled = true; // Enabling the start button once the user has completed the question.
                btnFinish.Enabled = false;
            }
        }

        // Clean up tasks.
        public void Housekeeping()
        {
            nudA.Value = 1;
            nudB.Value = 1;
            nudC.Value = 1;
            nudD.Value = 1;

            // dont actually need tb reset texts
            tbQ1.ResetText();
            tbQ2.ResetText();
            tbQ3.ResetText();
            tbQ4.ResetText();

            tbA1.ResetText();
            tbA2.ResetText();
            tbA3.ResetText();
            tbA4.ResetText();
            tbA5.ResetText();
            tbA6.ResetText();
            tbA7.ResetText();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Housekeeping(); // Clearing all the fields.
            HandleScores();
            streak = 0; // Resetting the streak counter.
            tbUserName.ResetText();
            tbUserName.Enabled = true;
            btnFinish.Enabled = false;
            canBack = true; // User may now exit as the game has concluded
        }

        // Method to check high scores and respond appropriately.
        public void HandleScores()
        {
            IdentifyingAreasScores scores = new IdentifyingAreasScores(streak, userName);
            List<IdentifyingAreasScores> listScores = scores.ReadHighScores();

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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (canBack)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete the game first!", "Alert");
            }
        }
    }
}
