namespace BudgetApp
{
    partial class ResetPassword
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
            this.lblResetPwd = new System.Windows.Forms.Label();
            this.txtEmailResetPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.btnLoginOnResetPwdPg = new System.Windows.Forms.Button();
            this.lblUserOnResetPwdPg = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResetPwd
            // 
            this.lblResetPwd.AutoSize = true;
            this.lblResetPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPwd.Location = new System.Drawing.Point(265, 20);
            this.lblResetPwd.Name = "lblResetPwd";
            this.lblResetPwd.Size = new System.Drawing.Size(265, 39);
            this.lblResetPwd.TabIndex = 0;
            this.lblResetPwd.Text = "Reset Password";
            // 
            // txtEmailResetPwd
            // 
            this.txtEmailResetPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailResetPwd.Location = new System.Drawing.Point(57, 135);
            this.txtEmailResetPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailResetPwd.Name = "txtEmailResetPwd";
            this.txtEmailResetPwd.Size = new System.Drawing.Size(653, 41);
            this.txtEmailResetPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(57, 247);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(653, 41);
            this.txtNewPwd.TabIndex = 2;
            // 
            // btnLoginOnResetPwdPg
            // 
            this.btnLoginOnResetPwdPg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginOnResetPwdPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginOnResetPwdPg.ForeColor = System.Drawing.Color.White;
            this.btnLoginOnResetPwdPg.Location = new System.Drawing.Point(292, 336);
            this.btnLoginOnResetPwdPg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginOnResetPwdPg.Name = "btnLoginOnResetPwdPg";
            this.btnLoginOnResetPwdPg.Size = new System.Drawing.Size(204, 47);
            this.btnLoginOnResetPwdPg.TabIndex = 3;
            this.btnLoginOnResetPwdPg.Text = "Log In";
            this.btnLoginOnResetPwdPg.UseVisualStyleBackColor = false;
            this.btnLoginOnResetPwdPg.Click += new System.EventHandler(this.btnLoginOnResetPwdPg_Click);
            // 
            // lblUserOnResetPwdPg
            // 
            this.lblUserOnResetPwdPg.AutoSize = true;
            this.lblUserOnResetPwdPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOnResetPwdPg.Location = new System.Drawing.Point(51, 81);
            this.lblUserOnResetPwdPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOnResetPwdPg.Name = "lblUserOnResetPwdPg";
            this.lblUserOnResetPwdPg.Size = new System.Drawing.Size(141, 29);
            this.lblUserOnResetPwdPg.TabIndex = 4;
            this.lblUserOnResetPwdPg.Text = "User Name";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(51, 203);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(181, 29);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUserOnResetPwdPg);
            this.Controls.Add(this.btnLoginOnResetPwdPg);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtEmailResetPwd);
            this.Controls.Add(this.lblResetPwd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResetPwd;
        private System.Windows.Forms.TextBox txtEmailResetPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Button btnLoginOnResetPwdPg;
        private System.Windows.Forms.Label lblUserOnResetPwdPg;
        private System.Windows.Forms.Label lblNewPassword;
    }
}