namespace BudgetApp
{
    partial class Home
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
            this.lblHome = new System.Windows.Forms.Label();
            this.btnViewBudget = new System.Windows.Forms.Button();
            this.btnTrackExpenses = new System.Windows.Forms.Button();
            this.btnViewDeals = new System.Windows.Forms.Button();
            this.btnViewGoal = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHome.Location = new System.Drawing.Point(241, 19);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(86, 31);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            // 
            // btnViewBudget
            // 
            this.btnViewBudget.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnViewBudget.ForeColor = System.Drawing.Color.White;
            this.btnViewBudget.Location = new System.Drawing.Point(43, 79);
            this.btnViewBudget.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewBudget.Name = "btnViewBudget";
            this.btnViewBudget.Size = new System.Drawing.Size(511, 35);
            this.btnViewBudget.TabIndex = 1;
            this.btnViewBudget.Text = "Set or View Monthly Budget";
            this.btnViewBudget.UseVisualStyleBackColor = false;
            this.btnViewBudget.Click += new System.EventHandler(this.btnViewBudget_Click);
            // 
            // btnTrackExpenses
            // 
            this.btnTrackExpenses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTrackExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTrackExpenses.ForeColor = System.Drawing.Color.White;
            this.btnTrackExpenses.Location = new System.Drawing.Point(43, 136);
            this.btnTrackExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrackExpenses.Name = "btnTrackExpenses";
            this.btnTrackExpenses.Size = new System.Drawing.Size(511, 35);
            this.btnTrackExpenses.TabIndex = 2;
            this.btnTrackExpenses.Text = "Track Monthly Expenses";
            this.btnTrackExpenses.UseVisualStyleBackColor = false;
            this.btnTrackExpenses.Click += new System.EventHandler(this.btnTrackExpenses_Click);
            // 
            // btnViewDeals
            // 
            this.btnViewDeals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnViewDeals.ForeColor = System.Drawing.Color.White;
            this.btnViewDeals.Location = new System.Drawing.Point(43, 193);
            this.btnViewDeals.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDeals.Name = "btnViewDeals";
            this.btnViewDeals.Size = new System.Drawing.Size(511, 35);
            this.btnViewDeals.TabIndex = 3;
            this.btnViewDeals.Text = "View Deals";
            this.btnViewDeals.UseVisualStyleBackColor = false;
            this.btnViewDeals.Click += new System.EventHandler(this.btnViewDeals_Click);
            // 
            // btnViewGoal
            // 
            this.btnViewGoal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnViewGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnViewGoal.ForeColor = System.Drawing.Color.White;
            this.btnViewGoal.Location = new System.Drawing.Point(43, 254);
            this.btnViewGoal.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewGoal.Name = "btnViewGoal";
            this.btnViewGoal.Size = new System.Drawing.Size(511, 35);
            this.btnViewGoal.TabIndex = 4;
            this.btnViewGoal.Text = "Set or View Goal";
            this.btnViewGoal.UseVisualStyleBackColor = false;
            this.btnViewGoal.Click += new System.EventHandler(this.btnViewGoal_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(43, 312);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(511, 35);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewGoal);
            this.Controls.Add(this.btnViewDeals);
            this.Controls.Add(this.btnTrackExpenses);
            this.Controls.Add(this.btnViewBudget);
            this.Controls.Add(this.lblHome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnViewBudget;
        private System.Windows.Forms.Button btnTrackExpenses;
        private System.Windows.Forms.Button btnViewDeals;
        private System.Windows.Forms.Button btnViewGoal;
        private System.Windows.Forms.Button btnLogOut;
    }
}