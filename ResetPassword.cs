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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnLoginOnResetPwdPg_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            Home resetPasswordToHome = new Home();
            resetPasswordToHome.ShowDialog();
        }

        private bool Validation()
        {
            if (String.IsNullOrEmpty(this.txtEmailResetPwd.Text.Trim()))
            {
                MessageBox.Show("Please enter a new username.", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(this.txtNewPwd.Text.Trim()))
            {
                MessageBox.Show("Please enter a new password.", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
