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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login registerToLogin = new Login();
            registerToLogin.ShowDialog();
        }

        private void lnklabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login alreadyHaveLogIn = new Login();
            alreadyHaveLogIn.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
