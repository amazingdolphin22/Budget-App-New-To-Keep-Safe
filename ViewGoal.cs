using BudgetApp.Processes;
using Coupons.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coupons.Processes;

namespace BudgetApp
{
    public partial class ViewGoal : Form
    {
        public int intCurrentGoal = 0;
        public double dblGoalCompleteFraction = 0;

        private string fileG = "Goal.txt";

        public ViewGoal()
        {
            InitializeComponent();
        }

        private void lnklblHomeOnViewGoalPg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home viewGoalToHome = new Home();
           viewGoalToHome.ShowDialog();
        }

        private void ViewGoal_Load(object sender, EventArgs e)
        {
            try
            {
                this.CenterToScreen();
                this.txtCurrentGoal.Text = Repository.GetGoal(fileG);
                txtGoalCompletion.Text = Repository.GetDealsFromFile().ToString();
                CalculateGoalCompletionPercentage();
            }
            catch
            { 
                MessageBox.Show("Exception error occurred in ViewGoal page load eventhandler."); 
            }
        }

        private void CalculateGoalCompletionPercentage()//string strCurrentGoal, string strGoalCompleted)
        {
            double dblGoalCompleted = 0.0;
            int intCurrentGoal = 0;
            dblGoalCompleted = Repository.GetDealsFromFile();
            bool boolSuccess = false;
            boolSuccess = int.TryParse(txtCurrentGoal.Text, out intCurrentGoal);
            dblGoalCompleteFraction = Math.Round(dblGoalCompleted / intCurrentGoal,4);
            txtGoalPercentComplete.Text = Math.Round(dblGoalCompleteFraction * 100, ParseCouponDataToJSON.twoDecimalPlaces).ToString();
        }

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            if (txtSetGoal.Text != "")
            {
                bool boolSuccess = int.TryParse(txtSetGoal.Text, out intCurrentGoal);
                if (boolSuccess)
                {
                    txtCurrentGoal.Text = txtSetGoal.Text.Trim();
                    txtSetGoal.Text = "";
                    btnSetGoal.BackColor = Color.SteelBlue;
                    CalculateGoalCompletionPercentage();

                    Repository.SaveGoal(fileG, txtCurrentGoal.Text);
                }
                else
                {
                    MessageBox.Show("Please enter only numbers for your financial goal.", Titles.MessageBoxTitle, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a dollar amount that is your goal here", Titles.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
