using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using BudgetApp.Models;
using BudgetApp.Processes;
using System.Linq;

namespace BudgetApp
{
    public partial class TrackExpenses : Form
    {
        string fileBC = "BudgetCouponStorageFile.txt";
        int intSumExpenses = 0;

        //string selectedItem = String.Empty;

        List<ExpensesModel> expenses = new List<ExpensesModel>();

        public TrackExpenses()
        {
            InitializeComponent();
        }

        private void lnklblHomeOnTrackExpensesPg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Home trackExpensesToHome = new Home();
            trackExpensesToHome.ShowDialog();
        }

        private void TrackExpenses_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtCategoryOfExpense.Focus();

            expenses = Repository.GetAllExpenses(fileBC);
            this.BindListView();

            this.CalcSumExpenses();
        }

        private void BindListView()
        {
            this.lvExpenseRecord.Items.Clear();

            foreach (var item in expenses)
            {
                ListViewItem lvi = new ListViewItem(item.Item);
                lvExpenseRecord.Items.Add(lvi);
                lvi.SubItems.Add(item.Value.ToString());
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!string.IsNullOrEmpty(txtCategoryOfExpense.Text) && !string.IsNullOrEmpty(txtAmountOfExpense.Text))
                {
                    bool boolPassed = false;
                    int intAmountOfExpense = 0;

                    //Testing if input is an "INT"
                    boolPassed = int.TryParse(txtAmountOfExpense.Text, out intAmountOfExpense);

                    //add this to the existing lblSumOfExpenses.Text control/property
                    int intSumOfExpenses = 0;
                    if(boolPassed == true)
                    {
                        boolPassed = false; //reinitialize to false so that it is true ONLY IF the integer conversion succeeded.
                        boolPassed = int.TryParse(lblSumOfExpenses.Text, out intSumOfExpenses);
                        string sumExpensesText = (intAmountOfExpense + intSumOfExpenses).ToString();

                        if (boolPassed == true)
                        {
                            lblSumOfExpenses.Text = sumExpensesText;

                            expenses.Add(new ExpensesModel()
                            {
                                Item = txtCategoryOfExpense.Text,
                                Value = intAmountOfExpense
                            });
                        }
                    }

                    //It is an INT
                    if (boolPassed)
                    {
                        ListViewItem lvi = new ListViewItem(txtCategoryOfExpense.Text);
                        lvExpenseRecord.Items.Add(lvi);
                        lvi.SubItems.Add(txtAmountOfExpense.Text);
                        txtCategoryOfExpense.Focus();
                        lvExpenseRecord.GridLines = true;

                        try
                        {
                            Repository.SaveExpenses(fileBC, this.txtCategoryOfExpense.Text.Trim(),
                                                    this.txtAmountOfExpense.Text.Trim());

                            txtAmountOfExpense.Clear();
                            txtCategoryOfExpense.Clear();
                        }
                        catch { }
                    }
                    else
                    {
                        string msg = "The amount field can only accept numbers. Please remove any dollar signs or " + 
                                     "anything else except numbers.";

                        MessageBox.Show(msg, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("Please enter both the Category and Amount of the expense in these fields.",
                                    TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Enter_Click threw an exception: " + exc.ToString());
            }

            this.CalcSumExpenses();
        }

        /*
        private void SelectedExpese(object sender, EventArgs e)
        {
            //var result = this.lvExpenseRecord.SelectedItems;
            //selectedItem = result[0].Text;
            //int i = this.lvExpenseRecord.SelectedIndices;
        }
        */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = this.lvExpenseRecord.SelectedIndices[0];
                //expenses.FindIndex(x => x.Item.Equals(this.lvExpenseRecord.SelectedItems));

            if (index > -1)
                expenses.RemoveAt(index);

            this.BindListView();

            this.CalcSumExpenses();
            /*
            foreach (var item in this.lvExpenseRecord.SelectedItems)
            {
                this.lvExpenseRecord.Items.Remove((ListViewItem)item);
            }
            */
        }

        private void CalcSumExpenses()
        {
            var value = expenses.Select(x => x.Value).ToArray();

            var total = (from t in value
                         select t).Sum();

            intSumExpenses = (int)total;

            //this.lvExpenseRecord = Repository.GetExpenses(fileBC, this.lvExpenseRecord, out intSumExpenses);
            lblSumOfExpenses.Text = intSumExpenses.ToString();
        }
    }
}
