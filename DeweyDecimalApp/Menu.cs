using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeweyDecimalApp
{
    public partial class Menu : Form
    {
        //CallNumberGameScores prepJson = new CallNumberGameScores();
        //IdentifyingAreasScores prepJsonIdentifyingAreasScores = new IdentifyingAreasScores();
        CallNumberClassifications prepJsonCns = new CallNumberClassifications();
        //FindingCallNumbersScores prepJsonFCNS = new FindingCallNumbersScores();

        public Menu()
        {
            InitializeComponent();
            //prepJson.PrepareJsonFile();
            //prepJsonCns.PrepareJsonFile();
        }

        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            // Hiding the menu form and showing the replacing books form. 
            this.Hide();
            ReplacingBooksForm rbf = new ReplacingBooksForm();
            rbf.ShowDialog();
            this.Show();
        }

        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            //prepJsonIdentifyingAreasScores.PrepareJsonFile();

            // Actual button functionality will come in later
            //MessageBox.Show("This feature will be available at a later date!", "Alert!");

            // Hiding the menu form and showing the Identifying Areas form. 
            this.Hide();
            IdentifyingAreasForm iaf = new IdentifyingAreasForm();
            iaf.ShowDialog();
            this.Show();
        }

        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            //prepJsonFCNS.PrepareJsonFile();
            //List<CallNumberClassifications> clist =  prepJsonCns.GetRandomQA();
            

            // Actual button functionality will come in later
            //MessageBox.Show("This feature will be available at a later date!", "Alert!");

            // Hiding the menu form and showing the Finding Call Numbers form. 
            this.Hide();
            FindingCallNumbersForm fcnf = new FindingCallNumbersForm();
            fcnf.ShowDialog();
            this.Show();
        }

    }
}
