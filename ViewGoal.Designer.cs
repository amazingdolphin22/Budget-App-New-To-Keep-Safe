namespace BudgetApp
{
    partial class ViewGoal
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
            this.components = new System.ComponentModel.Container();
            this.lblViewGoal = new System.Windows.Forms.Label();
            this.txtSetGoal = new System.Windows.Forms.TextBox();
            this.lblGoalCompletion = new System.Windows.Forms.Label();
            this.lblGoalSuccessRate = new System.Windows.Forms.Label();
            this.lnklblHomeOnViewGoalPg = new System.Windows.Forms.LinkLabel();
            this.txtGoalCompletion = new System.Windows.Forms.TextBox();
            this.txtGoalPercentComplete = new System.Windows.Forms.TextBox();
            this.lblSetGoal = new System.Windows.Forms.Label();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.txtCurrentGoal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblViewGoal
            // 
            this.lblViewGoal.AutoSize = true;
            this.lblViewGoal.BackColor = System.Drawing.Color.White;
            this.lblViewGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewGoal.Location = new System.Drawing.Point(285, 34);
            this.lblViewGoal.Name = "lblViewGoal";
            this.lblViewGoal.Size = new System.Drawing.Size(337, 46);
            this.lblViewGoal.TabIndex = 0;
            this.lblViewGoal.Text = "Set or View Goal";
            // 
            // txtSetGoal
            // 
            this.txtSetGoal.BackColor = System.Drawing.Color.White;
            this.txtSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSetGoal.Location = new System.Drawing.Point(204, 135);
            this.txtSetGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSetGoal.Name = "txtSetGoal";
            this.txtSetGoal.Size = new System.Drawing.Size(425, 41);
            this.txtSetGoal.TabIndex = 1;
            // 
            // lblGoalCompletion
            // 
            this.lblGoalCompletion.AutoSize = true;
            this.lblGoalCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGoalCompletion.Location = new System.Drawing.Point(373, 288);
            this.lblGoalCompletion.Name = "lblGoalCompletion";
            this.lblGoalCompletion.Size = new System.Drawing.Size(246, 29);
            this.lblGoalCompletion.TabIndex = 2;
            this.lblGoalCompletion.Text = "Goal Completion ($):";
            // 
            // lblGoalSuccessRate
            // 
            this.lblGoalSuccessRate.AutoSize = true;
            this.lblGoalSuccessRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGoalSuccessRate.Location = new System.Drawing.Point(355, 345);
            this.lblGoalSuccessRate.Name = "lblGoalSuccessRate";
            this.lblGoalSuccessRate.Size = new System.Drawing.Size(266, 29);
            this.lblGoalSuccessRate.TabIndex = 3;
            this.lblGoalSuccessRate.Text = "% Completion of Goal:";
            // 
            // lnklblHomeOnViewGoalPg
            // 
            this.lnklblHomeOnViewGoalPg.AutoSize = true;
            this.lnklblHomeOnViewGoalPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblHomeOnViewGoalPg.Location = new System.Drawing.Point(16, 415);
            this.lnklblHomeOnViewGoalPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblHomeOnViewGoalPg.Name = "lnklblHomeOnViewGoalPg";
            this.lnklblHomeOnViewGoalPg.Size = new System.Drawing.Size(115, 31);
            this.lnklblHomeOnViewGoalPg.TabIndex = 4;
            this.lnklblHomeOnViewGoalPg.TabStop = true;
            this.lnklblHomeOnViewGoalPg.Text = "< Home";
            this.lnklblHomeOnViewGoalPg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHomeOnViewGoalPg_LinkClicked);
            // 
            // txtGoalCompletion
            // 
            this.txtGoalCompletion.BackColor = System.Drawing.Color.White;
            this.txtGoalCompletion.Enabled = false;
            this.txtGoalCompletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGoalCompletion.Location = new System.Drawing.Point(637, 284);
            this.txtGoalCompletion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoalCompletion.Name = "txtGoalCompletion";
            this.txtGoalCompletion.Size = new System.Drawing.Size(124, 36);
            this.txtGoalCompletion.TabIndex = 5;
            this.txtGoalCompletion.Text = "Goal Completion";
            this.txtGoalCompletion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGoalPercentComplete
            // 
            this.txtGoalPercentComplete.BackColor = System.Drawing.Color.White;
            this.txtGoalPercentComplete.Enabled = false;
            this.txtGoalPercentComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGoalPercentComplete.Location = new System.Drawing.Point(637, 338);
            this.txtGoalPercentComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoalPercentComplete.Name = "txtGoalPercentComplete";
            this.txtGoalPercentComplete.Size = new System.Drawing.Size(73, 36);
            this.txtGoalPercentComplete.TabIndex = 6;
            this.txtGoalPercentComplete.Text = "0";
            this.txtGoalPercentComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSetGoal
            // 
            this.lblSetGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSetGoal.AutoSize = true;
            this.lblSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGoal.Location = new System.Drawing.Point(23, 142);
            this.lblSetGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetGoal.Name = "lblSetGoal";
            this.lblSetGoal.Size = new System.Drawing.Size(168, 29);
            this.lblSetGoal.TabIndex = 7;
            this.lblSetGoal.Text = "Set New Goal";
            this.lblSetGoal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSetGoal.ForeColor = System.Drawing.Color.White;
            this.btnSetGoal.Location = new System.Drawing.Point(637, 135);
            this.btnSetGoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(125, 43);
            this.btnSetGoal.TabIndex = 8;
            this.btnSetGoal.Text = "Set";
            this.btnSetGoal.UseVisualStyleBackColor = false;
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // txtCurrentGoal
            // 
            this.txtCurrentGoal.BackColor = System.Drawing.Color.White;
            this.txtCurrentGoal.Enabled = false;
            this.txtCurrentGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurrentGoal.HideSelection = false;
            this.txtCurrentGoal.Location = new System.Drawing.Point(637, 229);
            this.txtCurrentGoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrentGoal.Name = "txtCurrentGoal";
            this.txtCurrentGoal.Size = new System.Drawing.Size(124, 36);
            this.txtCurrentGoal.TabIndex = 10;
            this.txtCurrentGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(419, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Goal ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(719, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // ViewGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCurrentGoal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetGoal);
            this.Controls.Add(this.lblSetGoal);
            this.Controls.Add(this.txtGoalPercentComplete);
            this.Controls.Add(this.txtGoalCompletion);
            this.Controls.Add(this.lnklblHomeOnViewGoalPg);
            this.Controls.Add(this.lblGoalSuccessRate);
            this.Controls.Add(this.lblGoalCompletion);
            this.Controls.Add(this.txtSetGoal);
            this.Controls.Add(this.lblViewGoal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewGoal";
            this.Text = "ViewGoal";
            this.Load += new System.EventHandler(this.ViewGoal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewGoal;
        private System.Windows.Forms.TextBox txtSetGoal;
        private System.Windows.Forms.Label lblGoalCompletion;
        private System.Windows.Forms.Label lblGoalSuccessRate;
        private System.Windows.Forms.LinkLabel lnklblHomeOnViewGoalPg;
        private System.Windows.Forms.TextBox txtGoalCompletion;
        private System.Windows.Forms.TextBox txtGoalPercentComplete;
        private System.Windows.Forms.Label lblSetGoal;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.TextBox txtCurrentGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}