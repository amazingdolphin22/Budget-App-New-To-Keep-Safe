using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coupons.Models;
using BudgetApp.Processes;

namespace BudgetApp
{
    public partial class ViewDeals : Form
    {
        List<CouponModel> coupons = new List<CouponModel>();
        List<CouponModel> discounts = new List<CouponModel>();

        private string _selectedCategory = string.Empty;
        private string _selectedDiscount = string.Empty;

        public ViewDeals()
        {
            InitializeComponent();
            
        }
        private void lnklblHomeOnViewDealsPg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home viewDealsToHome = new Home();
            viewDealsToHome.ShowDialog();
        }

        private void ViewDeals_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //btnAddSavings.PerformClick();
            this.coupons = Repository.GetDeals();
            this.PopulateCategories();
        }

        private void btnAddSavings_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;

            foreach (var c in coupons)
            {
                if (c.Title.ToUpper().Contains(_selectedDiscount.ToUpper()))
                {
                    string msg = "Are you sure you want to buy: " + c.Title + "?";
                    DialogResult result = MessageBox.Show(msg, Titles.MessageBoxTitle,
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                        Repository.SaveDeals(c.DiscountAmt);
                }
            }

            //MOVED the following code to GetDeals() in Repository class.
            //coupons = CouponService.GetCouponData();
            //this.PopulateCategories();

            //Cursor.Current = Cursors.Default;
        }

        private void PopulateCategories()
        {
            //Clear the listboxes
            //this.SetControls();
            

            //Get the Category Titles - LINQ
            IEnumerable<String> categories = (from c in this.coupons
                                              select c.Category).ToList().Distinct();

            //Populate ListBox Categories
            //this.lstCategories.DataSource = categories.ToList();
            this.cbCategories.DataSource = categories.ToList();

            //Get the Discounts
           // this.PopulateDiscounts();

        }

        private void lstDiscounts_SelectedValueChanged(object sender, EventArgs e)
        {
            //Get Selected Discount
            if (this.lstDiscounts.SelectedValue != null)
            {
                _selectedDiscount = this.lstDiscounts.SelectedValue.ToString();
                //Repository.GetDeals();

                foreach (var c in coupons)
                {
                    if (c.Title.ToUpper().Contains(_selectedDiscount.ToUpper()))
                    {
                        lblDiscountAmount.Text = c.DiscountAmt;
                    }
                }
                
            }
        }

        private void cbCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            //Get Selected Category
            if (this.cbCategories.SelectedValue != null)
            {
                _selectedCategory = this.cbCategories.SelectedValue.ToString();
                this.PopulateDiscounts();
            }
        }

        private void PopulateDiscounts()
        {
            //Need to get String Value for comparison in LINQ
            _selectedDiscount = this.cbCategories.SelectedItem.ToString();

            //Get the discounts
            //LINQ allows you to search a collection
            //discounts is the variable
            //Inumeralbe<string> is the type
            //from .... is quering the coupons object List<CouponModel> which contains the coupon data
            //You are searching inside the CouponModel for a specific discount
            IEnumerable<string> discounts = (from c in this.coupons
                                             where c.Category == this._selectedDiscount
                                             select c.Title).ToList();

            //Populate ListBox Discounts (Titles)
            this.lstDiscounts.DataSource = discounts.ToList();

            this.DisplayWebPage();
        }

        private void DisplayWebPage()
        {

            //Need to get String Value for comparison in LINQ
            string selectedURL = this.lstDiscounts.SelectedItem.ToString();

            //Get the discounts
            var url = (from c in this.coupons
                       where c.Title == selectedURL
                       select c.CouponURL).ToArray();


            //Suppress any script errors on the webbrowser control
            this.wbBrowser.ScriptErrorsSuppressed = true;

            //Load the webpage
            this.wbBrowser.Navigate(new Uri(url[0].ToString()), false);
        }


    }
}
