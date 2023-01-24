using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class Login : Form
    {
        List<LoginModel> Credentials = new List<LoginModel>();

        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Credentials = LoginModel.GetCredentials();
        }

        private void btnLoginOnLoginPg_Click(object sender, EventArgs e)
        {
            if (!this.IsValidUser())
                return;

            Home loginToHome = new Home();
            loginToHome.ShowDialog();
        }

        private bool IsValidUser()
        {
            string user = this.txtEmailLogIn.Text.Trim();
            string pwd = this.txtPwdLogIn.Text.Trim();

            var result = (from c in Credentials
                          where c.UserName == user
                          where c.Password == pwd
                          select c).ToArray();

            if (!result.Any())
            {
                MessageBox.Show("Credentials are incorrect!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void lnklabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword loginToResetPassword = new ResetPassword();
            loginToResetPassword.ShowDialog();
        }

    }
}
