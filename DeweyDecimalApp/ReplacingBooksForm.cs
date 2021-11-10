using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DeweyDecimalApp
{
    public partial class ReplacingBooksForm : Form
    {
        CallNumber cn = new CallNumber(); // Needed to use the class methods.
        List<CallNumber> callNumbers = new List<CallNumber>();
        List<CallNumber> userAnswers = new List<CallNumber>();
        bool canBack;
        Stopwatch stopwatch = new Stopwatch(); // Used to measure the user time
        string userName;


        public ReplacingBooksForm()
        {
            InitializeComponent();
            canBack = true; // Used to control if the user is allowed to return to the menu or not. User cannot go back during the game.
            toolTipReplaceBooks.SetToolTip(btnRemoveCallNum, "Click here to remove a call number from your list of sorted call numbers.");
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

        private void btnAddCallNum_Click(object sender, EventArgs e)
        {
            // If statement to check if the user is trying to add an already added answer
            if (lstUserAnswer.Items.Contains(lstOriginalList.SelectedItem)) // No duplicate items allowed.
            {
                MessageBox.Show($"{lstOriginalList.SelectedItem} You have already chosen this call number!", "Alert");
            }
            else
            {
                //Try block to add the currently selected call number to the users answers
                try
                {
                    userAnswers.Add(callNumbers.ElementAt(lstOriginalList.SelectedIndex));
                    lstUserAnswer.Items.Add(lstOriginalList.SelectedItem);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to add call number to your answer.", "Error");
                }
            }
        }

        private void btnRemoveCallNum_Click(object sender, EventArgs e)
        {
            try
            {
                // Removing the selected call number from the background list of user call numbers and the user answer list box.
                userAnswers.RemoveAt(lstUserAnswer.SelectedIndex);
                lstUserAnswer.Items.Remove(lstUserAnswer.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to remove the selected call number.", "Error");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            tbName.Clear();
            List<CallNumber> sortedList = cn.SortCallNumbers(callNumbers); // Sorting the random list of generated call numbers.
                                                                           // This is used to check if the user ordered the numbers correctly.

            stopwatch.Stop();
            double time = Math.Round(stopwatch.Elapsed.TotalSeconds, 2); // Recording the time the user took to complete the question.

            if (cn.CompareLists(sortedList, userAnswers))
            {
                CallNumberGameScores c = new CallNumberGameScores(time, userName);
                List<CallNumberGameScores> listScores = c.ReadHighScores();

                // Comparing the users score to the list of highscores to see if the user has achieved a highscore.
                if (c.IsScoreHigher(listScores, c))
                {
                    c.UpdateLeaderboard(listScores, c);
                    MessageBox.Show($"Congratulations, {userName}, you achieved a highscore with a time of {time} seconds!", "YAY");
                    MessageBox.Show(c.DisplayHighScores(), "High Scores");

                }
                else
                {
                    MessageBox.Show($"You answered the question correctly with a time of {time} seconds! Unfotunately you did not get a high score. Please try again if you want a high score!", "Congratulations!");
                    MessageBox.Show(c.DisplayHighScores(), "High Scores");
                }

            }
            else
            {
                MessageBox.Show("You have incorrectly ordered the call numbers! Please restart and try again!" +
                    "\nTo restart, simply hit the start button again.", "BOO!");
            }

            // Some house keeping tasks.
            lstOriginalList.Items.Clear();
            lstUserAnswer.Items.Clear();
            btnAddCallNum.Enabled = false;
            btnRemoveCallNum.Enabled = false;
            canBack = true; // Allowing the user to go back after they have completed the game.
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            userName = tbName.Text.Trim();

            // House keeping tasks.
            if (!(lstOriginalList.Items is null))
            {
                lstOriginalList.Items.Clear();
            }
            if (!(lstUserAnswer.Items is null))
            {
                lstUserAnswer.Items.Clear();
                userAnswers.Clear();
            }

            // Ensuring a user has entered their name before they start the game. This is important as score requires a name component and time component.
            if (userName.Equals(""))
            {
                tbName.Clear(); // This is for when Sarina enters only whitespace to test. It is just to get rid of the whitespace :)
                MessageBox.Show("Please enter your name first!", "Alert");
            }
            else
            {
                btnStart.Text = "Restart";
                btnConfirm.Enabled = true;
                canBack = false;

                try
                {
                    callNumbers = cn.GenerateCallNumberList();

                    foreach (CallNumber item in callNumbers)
                    {
                        lstOriginalList.Items.Add(item);
                    }
                    stopwatch.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to generate call numbers", "Error");
                }
            }
        }

        private void lstOriginalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstOriginalList.SelectedIndex;
            lstUserAnswer.ClearSelected();
            lstOriginalList.SelectedIndex = index; // This is necessary as selecting an item in lstUserAnswers will result in both list boxes being unselected.
            btnAddCallNum.Enabled = true;
            btnRemoveCallNum.Enabled = false;
        }

        private void lstUserAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstUserAnswer.SelectedIndex;
            lstOriginalList.ClearSelected();
            lstUserAnswer.SelectedIndex = index; // This is necessary as selecting an item in lstOrignalList will result in both list boxes being unselected.
            btnAddCallNum.Enabled = false;
            btnRemoveCallNum.Enabled = true;
        }
    }
}
