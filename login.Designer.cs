namespace BudgetApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtEmailLogIn = new System.Windows.Forms.TextBox();
            this.txtPwdLogIn = new System.Windows.Forms.TextBox();
            this.btnLoginOnLoginPg = new System.Windows.Forms.Button();
            this.lnklabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblUserOnLoginPg = new System.Windows.Forms.Label();
            this.lblPasswordOnLoginPg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(316, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 39);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Log In";
            // 
            // txtEmailLogIn
            // 
            this.txtEmailLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogIn.Location = new System.Drawing.Point(57, 135);
            this.txtEmailLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailLogIn.Name = "txtEmailLogIn";
            this.txtEmailLogIn.Size = new System.Drawing.Size(653, 41);
            this.txtEmailLogIn.TabIndex = 1;
            // 
            // txtPwdLogIn
            // 
            this.txtPwdLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdLogIn.Location = new System.Drawing.Point(57, 254);
            this.txtPwdLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwdLogIn.Name = "txtPwdLogIn";
            this.txtPwdLogIn.PasswordChar = '*';
            this.txtPwdLogIn.Size = new System.Drawing.Size(653, 41);
            this.txtPwdLogIn.TabIndex = 2;
            // 
            // btnLoginOnLoginPg
            // 
            this.btnLoginOnLoginPg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginOnLoginPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginOnLoginPg.ForeColor = System.Drawing.Color.White;
            this.btnLoginOnLoginPg.Location = new System.Drawing.Point(269, 335);
            this.btnLoginOnLoginPg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginOnLoginPg.Name = "btnLoginOnLoginPg";
            this.btnLoginOnLoginPg.Size = new System.Drawing.Size(204, 47);
            this.btnLoginOnLoginPg.TabIndex = 3;
            this.btnLoginOnLoginPg.Text = "Log In";
            this.btnLoginOnLoginPg.UseVisualStyleBackColor = false;
            this.btnLoginOnLoginPg.Click += new System.EventHandler(this.btnLoginOnLoginPg_Click);
            // 
            // lnklabelForgotPassword
            // 
            this.lnklabelForgotPassword.AutoSize = true;
            this.lnklabelForgotPassword.Location = new System.Drawing.Point(277, 402);
            this.lnklabelForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklabelForgotPassword.Name = "lnklabelForgotPassword";
            this.lnklabelForgotPassword.Size = new System.Drawing.Size(116, 16);
            this.lnklabelForgotPassword.TabIndex = 4;
            this.lnklabelForgotPassword.TabStop = true;
            this.lnklabelForgotPassword.Text = "Forgot Password?";
            this.lnklabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabelForgotPassword_LinkClicked);
            // 
            // lblUserOnLoginPg
            // 
            this.lblUserOnLoginPg.AutoSize = true;
            this.lblUserOnLoginPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOnLoginPg.Location = new System.Drawing.Point(57, 90);
            this.lblUserOnLoginPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOnLoginPg.Name = "lblUserOnLoginPg";
            this.lblUserOnLoginPg.Size = new System.Drawing.Size(141, 29);
            this.lblUserOnLoginPg.TabIndex = 5;
            this.lblUserOnLoginPg.Text = "User Name";
            // 
            // lblPasswordOnLoginPg
            // 
            this.lblPasswordOnLoginPg.AutoSize = true;
            this.lblPasswordOnLoginPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordOnLoginPg.Location = new System.Drawing.Point(57, 206);
            this.lblPasswordOnLoginPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordOnLoginPg.Name = "lblPasswordOnLoginPg";
            this.lblPasswordOnLoginPg.Size = new System.Drawing.Size(124, 29);
            this.lblPasswordOnLoginPg.TabIndex = 6;
            this.lblPasswordOnLoginPg.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPasswordOnLoginPg);
            this.Controls.Add(this.lblUserOnLoginPg);
            this.Controls.Add(this.lnklabelForgotPassword);
            this.Controls.Add(this.btnLoginOnLoginPg);
            this.Controls.Add(this.txtPwdLogIn);
            this.Controls.Add(this.txtEmailLogIn);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtEmailLogIn;
        private System.Windows.Forms.TextBox txtPwdLogIn;
        private System.Windows.Forms.Button btnLoginOnLoginPg;
        private System.Windows.Forms.LinkLabel lnklabelForgotPassword;
        private System.Windows.Forms.Label lblUserOnLoginPg;
        private System.Windows.Forms.Label lblPasswordOnLoginPg;
    }
}