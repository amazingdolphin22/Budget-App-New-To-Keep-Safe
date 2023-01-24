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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnToLoginPg_Click(object sender, EventArgs e)
        {
            Login welcomeToLogin = new Login();
            welcomeToLogin.ShowDialog();
        }

        private void lnklblRegisterHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register welcomeToRegister = new Register();
            welcomeToRegister.ShowDialog();
        }
    }
}
