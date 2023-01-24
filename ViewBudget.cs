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
using Coupons.Processes;

namespace BudgetApp
{
    public partial class ViewBudget : Form
    {
        public string SetBudget { get; set; }
        Home HomeForm = new Home();
        int intTotalBudget = 0;
        string fileBC = "BudgetCouponStorageFile.txt";

        int intAddAllExpenses = 0;

        public ViewBudget()
        {
            InitializeComponent();
        }

        public ViewBudget(Home f)
        {
            HomeForm = f;
        }

        private void ViewBudget_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Repository.GetBudget(); //made this method public to be called here. Could have made a property in 
            // Repository and then the GET would get the value from this PRIVATE method, but just easier like this.

            txtSetBudget.Text = Repository.intBudget.ToString();
            intAddAllExpenses = Repository.SumExpenses(fileBC, intAddAllExpenses);
            this.btnSetTotalBudget.PerformClick();
        }

        private void lnklblHomeOnViewBudgetPg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeForm.SetBudget = SetBudget;
            this.Close();
        }

        private void btnSetTotalBudget_Click(object sender, EventArgs e)
        {
            if(txtSetBudget.Text != "")
            {
                bool boolSuccess = int.TryParse(txtSetBudget.Text, out intTotalBudget);
                if(boolSuccess)
                {
                    Repository.SaveBudget(intTotalBudget);

                    btnSetTotalBudget.BackColor = Color.SteelBlue;
                    txtMoneySpent.Text = Repository.intSumExpenses.ToString();
                    double dblMoneyLeft = ((double)intTotalBudget - (double)intAddAllExpenses);
                    if(dblMoneyLeft < 0)
                    {
                        MessageBox.Show("You spent over your budget.");
                    }
                    else if(dblMoneyLeft == 0)
                    {
                        MessageBox.Show("You have no more money left in the budget.");
                    }
                    txtMoneyLeft.Text = dblMoneyLeft.ToString();
                    txtPercentLeft.Text = Math.Round(((((double)intTotalBudget - (double)intAddAllExpenses) / (double)intTotalBudget) * 100),ParseCouponDataToJSON.twoDecimalPlaces).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter only numbers for your budget.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the amount of money you have for the month.");
            }
        }
    }
}
