namespace BudgetApp
{
    partial class ViewBudget
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
            this.lblViewBudget = new System.Windows.Forms.Label();
            this.txtSetBudget = new System.Windows.Forms.TextBox();
            this.lblMoneySpent = new System.Windows.Forms.Label();
            this.lblPercentLeft = new System.Windows.Forms.Label();
            this.lnklblHomeOnViewBudgetPg = new System.Windows.Forms.LinkLabel();
            this.txtMoneySpent = new System.Windows.Forms.TextBox();
            this.txtPercentLeft = new System.Windows.Forms.TextBox();
            this.lblSetTotalBudget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetTotalBudget = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneyLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblViewBudget
            // 
            this.lblViewBudget.AutoSize = true;
            this.lblViewBudget.BackColor = System.Drawing.Color.White;
            this.lblViewBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblViewBudget.Location = new System.Drawing.Point(221, 25);
            this.lblViewBudget.Name = "lblViewBudget";
            this.lblViewBudget.Size = new System.Drawing.Size(436, 39);
            this.lblViewBudget.TabIndex = 0;
            this.lblViewBudget.Text = "Set or View Monthly Budget";
            // 
            // txtSetBudget
            // 
            this.txtSetBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSetBudget.Location = new System.Drawing.Point(347, 135);
            this.txtSetBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetBudget.Name = "txtSetBudget";
            this.txtSetBudget.Size = new System.Drawing.Size(201, 41);
            this.txtSetBudget.TabIndex = 1;
            // 
            // lblMoneySpent
            // 
            this.lblMoneySpent.AutoSize = true;
            this.lblMoneySpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMoneySpent.Location = new System.Drawing.Point(245, 213);
            this.lblMoneySpent.Name = "lblMoneySpent";
            this.lblMoneySpent.Size = new System.Drawing.Size(169, 29);
            this.lblMoneySpent.TabIndex = 2;
            this.lblMoneySpent.Text = "Money Spent:";
            // 
            // lblPercentLeft
            // 
            this.lblPercentLeft.AutoSize = true;
            this.lblPercentLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPercentLeft.Location = new System.Drawing.Point(327, 274);
            this.lblPercentLeft.Name = "lblPercentLeft";
            this.lblPercentLeft.Size = new System.Drawing.Size(91, 29);
            this.lblPercentLeft.TabIndex = 3;
            this.lblPercentLeft.Text = "% Left:";
            // 
            // lnklblHomeOnViewBudgetPg
            // 
            this.lnklblHomeOnViewBudgetPg.AutoSize = true;
            this.lnklblHomeOnViewBudgetPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblHomeOnViewBudgetPg.Location = new System.Drawing.Point(16, 415);
            this.lnklblHomeOnViewBudgetPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblHomeOnViewBudgetPg.Name = "lnklblHomeOnViewBudgetPg";
            this.lnklblHomeOnViewBudgetPg.Size = new System.Drawing.Size(81, 25);
            this.lnklblHomeOnViewBudgetPg.TabIndex = 5;
            this.lnklblHomeOnViewBudgetPg.TabStop = true;
            this.lnklblHomeOnViewBudgetPg.Text = "< Home";
            this.lnklblHomeOnViewBudgetPg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHomeOnViewBudgetPg_LinkClicked);
            // 
            // txtMoneySpent
            // 
            this.txtMoneySpent.Enabled = false;
            this.txtMoneySpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMoneySpent.Location = new System.Drawing.Point(431, 213);
            this.txtMoneySpent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoneySpent.Name = "txtMoneySpent";
            this.txtMoneySpent.Size = new System.Drawing.Size(124, 36);
            this.txtMoneySpent.TabIndex = 6;
            // 
            // txtPercentLeft
            // 
            this.txtPercentLeft.Enabled = false;
            this.txtPercentLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPercentLeft.Location = new System.Drawing.Point(431, 271);
            this.txtPercentLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPercentLeft.Name = "txtPercentLeft";
            this.txtPercentLeft.Size = new System.Drawing.Size(124, 36);
            this.txtPercentLeft.TabIndex = 7;
            // 
            // lblSetTotalBudget
            // 
            this.lblSetTotalBudget.AutoSize = true;
            this.lblSetTotalBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTotalBudget.Location = new System.Drawing.Point(83, 139);
            this.lblSetTotalBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetTotalBudget.Name = "lblSetTotalBudget";
            this.lblSetTotalBudget.Size = new System.Drawing.Size(236, 36);
            this.lblSetTotalBudget.TabIndex = 8;
            this.lblSetTotalBudget.Text = "Set Total Budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // btnSetTotalBudget
            // 
            this.btnSetTotalBudget.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSetTotalBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTotalBudget.ForeColor = System.Drawing.Color.White;
            this.btnSetTotalBudget.Location = new System.Drawing.Point(568, 135);
            this.btnSetTotalBudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetTotalBudget.Name = "btnSetTotalBudget";
            this.btnSetTotalBudget.Size = new System.Drawing.Size(151, 43);
            this.btnSetTotalBudget.TabIndex = 10;
            this.btnSetTotalBudget.Text = "Set";
            this.btnSetTotalBudget.UseVisualStyleBackColor = false;
            this.btnSetTotalBudget.Click += new System.EventHandler(this.btnSetTotalBudget_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(563, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // txtMoneyLeft
            // 
            this.txtMoneyLeft.Enabled = false;
            this.txtMoneyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMoneyLeft.Location = new System.Drawing.Point(431, 322);
            this.txtMoneyLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoneyLeft.Name = "txtMoneyLeft";
            this.txtMoneyLeft.Size = new System.Drawing.Size(124, 36);
            this.txtMoneyLeft.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(191, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Money Remaining:";
            // 
            // ViewBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMoneyLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetTotalBudget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSetTotalBudget);
            this.Controls.Add(this.txtPercentLeft);
            this.Controls.Add(this.txtMoneySpent);
            this.Controls.Add(this.lnklblHomeOnViewBudgetPg);
            this.Controls.Add(this.lblPercentLeft);
            this.Controls.Add(this.lblMoneySpent);
            this.Controls.Add(this.txtSetBudget);
            this.Controls.Add(this.lblViewBudget);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewBudget";
            this.Text = "ViewBudget";
            this.Load += new System.EventHandler(this.ViewBudget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewBudget;
        private System.Windows.Forms.TextBox txtSetBudget;
        private System.Windows.Forms.Label lblMoneySpent;
        private System.Windows.Forms.Label lblPercentLeft;
        private System.Windows.Forms.LinkLabel lnklblHomeOnViewBudgetPg;
        private System.Windows.Forms.TextBox txtMoneySpent;
        private System.Windows.Forms.TextBox txtPercentLeft;
        private System.Windows.Forms.Label lblSetTotalBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetTotalBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneyLeft;
        private System.Windows.Forms.Label label3;
    }
}