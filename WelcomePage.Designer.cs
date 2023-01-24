namespace BudgetApp
{
    partial class WelcomePage
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
            this.lnklblRegisterHere = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnToLoginPg = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLifeStyle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lnklblRegisterHere
            // 
            this.lnklblRegisterHere.AutoSize = true;
            this.lnklblRegisterHere.Location = new System.Drawing.Point(441, 418);
            this.lnklblRegisterHere.Name = "lnklblRegisterHere";
            this.lnklblRegisterHere.Size = new System.Drawing.Size(72, 13);
            this.lnklblRegisterHere.TabIndex = 13;
            this.lnklblRegisterHere.TabStop = true;
            this.lnklblRegisterHere.Text = "Register Here";
            this.lnklblRegisterHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRegisterHere_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Location = new System.Drawing.Point(314, 418);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(122, 13);
            this.lblNoAccount.TabIndex = 12;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // btnToLoginPg
            // 
            this.btnToLoginPg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnToLoginPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLoginPg.ForeColor = System.Drawing.Color.White;
            this.btnToLoginPg.Location = new System.Drawing.Point(336, 359);
            this.btnToLoginPg.Name = "btnToLoginPg";
            this.btnToLoginPg.Size = new System.Drawing.Size(153, 38);
            this.btnToLoginPg.TabIndex = 11;
            this.btnToLoginPg.Text = "Log In";
            this.btnToLoginPg.UseVisualStyleBackColor = false;
            this.btnToLoginPg.Click += new System.EventHandler(this.btnToLoginPg_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Enabled = false;
            this.imgLogo.ErrorImage = global::BudgetApp.Properties.Resources.logo;
            this.imgLogo.Image = global::BudgetApp.Properties.Resources.logo;
            this.imgLogo.InitialImage = null;
            this.imgLogo.Location = new System.Drawing.Point(304, 11);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(217, 157);
            this.imgLogo.TabIndex = 10;
            this.imgLogo.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(266, 298);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(293, 40);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Life$tyle is an app that helps you budget\r\nso that YOU can enjoy your life in sty" +
    "le!\r\n";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Broadway", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(318, 224);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(181, 38);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblLifeStyle
            // 
            this.lblLifeStyle.AutoSize = true;
            this.lblLifeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblLifeStyle.Location = new System.Drawing.Point(521, 224);
            this.lblLifeStyle.Name = "lblLifeStyle";
            this.lblLifeStyle.Size = new System.Drawing.Size(0, 25);
            this.lblLifeStyle.TabIndex = 7;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.lnklblRegisterHere);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.btnToLoginPg);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLifeStyle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklblRegisterHere;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnToLoginPg;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLifeStyle;
    }
}