using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetApp.Processes;

namespace BudgetApp
{
    public partial class Home : Form
    {
        public string SetBudget { get; set; }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnViewBudget_Click(object sender, EventArgs e)
        {
            ViewBudget homeToViewBudget = new ViewBudget();//this arg
            homeToViewBudget.SetBudget = SetBudget;
            homeToViewBudget.ShowDialog();
        }

        private void btnTrackExpenses_Click(object sender, EventArgs e)
        {
            TrackExpenses homeToTrackExpenses = new TrackExpenses();
            homeToTrackExpenses.ShowDialog();
        }
      
        private void btnViewDeals_Click(object sender, EventArgs e)
        {
            ViewDeals homeToViewDeals = new ViewDeals();//homeToViewGoal);
            homeToViewDeals.ShowDialog();
        }

        private void btnViewGoal_Click(object sender, EventArgs e)
        {
            ViewGoal homeToViewGoal = new ViewGoal();
            homeToViewGoal.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomePage logOutToWelcome = new WelcomePage();
            logOutToWelcome.ShowDialog();
        }
    }
}
