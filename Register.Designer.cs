namespace BudgetApp
{
    partial class Register
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.txtPwdRegister = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblHaveAnAcct = new System.Windows.Forms.Label();
            this.lnklabelLogIn = new System.Windows.Forms.LinkLabel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserOnRegisterPg = new System.Windows.Forms.Label();
            this.lblPwdOnRegisterPg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(316, 20);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(144, 39);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(57, 111);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(653, 41);
            this.txtFullName.TabIndex = 1;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegister.Location = new System.Drawing.Point(57, 201);
            this.txtEmailRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(653, 41);
            this.txtEmailRegister.TabIndex = 2;
            // 
            // txtPwdRegister
            // 
            this.txtPwdRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdRegister.Location = new System.Drawing.Point(57, 289);
            this.txtPwdRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwdRegister.Name = "txtPwdRegister";
            this.txtPwdRegister.Size = new System.Drawing.Size(653, 41);
            this.txtPwdRegister.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(273, 350);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(199, 46);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblHaveAnAcct
            // 
            this.lblHaveAnAcct.AutoSize = true;
            this.lblHaveAnAcct.Location = new System.Drawing.Point(181, 415);
            this.lblHaveAnAcct.Name = "lblHaveAnAcct";
            this.lblHaveAnAcct.Size = new System.Drawing.Size(162, 16);
            this.lblHaveAnAcct.TabIndex = 5;
            this.lblHaveAnAcct.Text = "Already have an account?";
            // 
            // lnklabelLogIn
            // 
            this.lnklabelLogIn.AutoSize = true;
            this.lnklabelLogIn.Location = new System.Drawing.Point(364, 415);
            this.lnklabelLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklabelLogIn.Name = "lnklabelLogIn";
            this.lnklabelLogIn.Size = new System.Drawing.Size(43, 16);
            this.lnklabelLogIn.TabIndex = 6;
            this.lnklabelLogIn.TabStop = true;
            this.lnklabelLogIn.Text = "Log In";
            this.lnklabelLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabelLogIn_LinkClicked);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(55, 65);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(129, 29);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUserOnRegisterPg
            // 
            this.lblUserOnRegisterPg.AutoSize = true;
            this.lblUserOnRegisterPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUserOnRegisterPg.Location = new System.Drawing.Point(55, 167);
            this.lblUserOnRegisterPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOnRegisterPg.Name = "lblUserOnRegisterPg";
            this.lblUserOnRegisterPg.Size = new System.Drawing.Size(141, 29);
            this.lblUserOnRegisterPg.TabIndex = 8;
            this.lblUserOnRegisterPg.Text = "User Name";
            // 
            // lblPwdOnRegisterPg
            // 
            this.lblPwdOnRegisterPg.AutoSize = true;
            this.lblPwdOnRegisterPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPwdOnRegisterPg.Location = new System.Drawing.Point(51, 256);
            this.lblPwdOnRegisterPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwdOnRegisterPg.Name = "lblPwdOnRegisterPg";
            this.lblPwdOnRegisterPg.Size = new System.Drawing.Size(124, 29);
            this.lblPwdOnRegisterPg.TabIndex = 9;
            this.lblPwdOnRegisterPg.Text = "Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPwdOnRegisterPg);
            this.Controls.Add(this.lblUserOnRegisterPg);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lnklabelLogIn);
            this.Controls.Add(this.lblHaveAnAcct);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPwdRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblRegister);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.TextBox txtPwdRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblHaveAnAcct;
        private System.Windows.Forms.LinkLabel lnklabelLogIn;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserOnRegisterPg;
        private System.Windows.Forms.Label lblPwdOnRegisterPg;
    }
}