namespace BudgetApp
{
    partial class ViewDeals
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
            this.lblViewDeals = new System.Windows.Forms.Label();
            this.btnAddSavings = new System.Windows.Forms.Button();
            this.lnklblHomeOnViewDealsPg = new System.Windows.Forms.LinkLabel();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.lstDiscounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblViewDeals
            // 
            this.lblViewDeals.AutoSize = true;
            this.lblViewDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewDeals.ForeColor = System.Drawing.Color.White;
            this.lblViewDeals.Location = new System.Drawing.Point(397, 15);
            this.lblViewDeals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewDeals.Name = "lblViewDeals";
            this.lblViewDeals.Size = new System.Drawing.Size(200, 39);
            this.lblViewDeals.TabIndex = 0;
            this.lblViewDeals.Text = "View Deals";
            // 
            // btnAddSavings
            // 
            this.btnAddSavings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddSavings.ForeColor = System.Drawing.Color.White;
            this.btnAddSavings.Location = new System.Drawing.Point(16, 101);
            this.btnAddSavings.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSavings.Name = "btnAddSavings";
            this.btnAddSavings.Size = new System.Drawing.Size(120, 31);
            this.btnAddSavings.TabIndex = 1;
            this.btnAddSavings.Text = "Add Savings";
            this.toolTip1.SetToolTip(this.btnAddSavings, "Click here to add this DEAL and be reflected in View Goals");
            this.btnAddSavings.UseVisualStyleBackColor = false;
            this.btnAddSavings.Click += new System.EventHandler(this.btnAddSavings_Click);
            // 
            // lnklblHomeOnViewDealsPg
            // 
            this.lnklblHomeOnViewDealsPg.AutoSize = true;
            this.lnklblHomeOnViewDealsPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblHomeOnViewDealsPg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklblHomeOnViewDealsPg.Location = new System.Drawing.Point(12, 671);
            this.lnklblHomeOnViewDealsPg.Name = "lnklblHomeOnViewDealsPg";
            this.lnklblHomeOnViewDealsPg.Size = new System.Drawing.Size(71, 20);
            this.lnklblHomeOnViewDealsPg.TabIndex = 2;
            this.lnklblHomeOnViewDealsPg.TabStop = true;
            this.lnklblHomeOnViewDealsPg.Text = "< Home";
            this.lnklblHomeOnViewDealsPg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHomeOnViewDealsPg_LinkClicked);
            // 
            // cbCategories
            // 
            this.cbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(154, 101);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(203, 28);
            this.cbCategories.TabIndex = 3;
            this.cbCategories.SelectedValueChanged += new System.EventHandler(this.cbCategories_SelectedValueChanged);
            // 
            // lstDiscounts
            // 
            this.lstDiscounts.BackColor = System.Drawing.SystemColors.Window;
            this.lstDiscounts.FormattingEnabled = true;
            this.lstDiscounts.Location = new System.Drawing.Point(379, 101);
            this.lstDiscounts.Name = "lstDiscounts";
            this.lstDiscounts.Size = new System.Drawing.Size(603, 82);
            this.lstDiscounts.TabIndex = 4;
            this.lstDiscounts.SelectedValueChanged += new System.EventHandler(this.lstDiscounts_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discounts for Selected Category";
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(16, 220);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(966, 437);
            this.wbBrowser.TabIndex = 7;
            this.wbBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.BackColor = System.Drawing.SystemColors.Window;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(151, 170);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(206, 23);
            this.lblDiscountAmount.TabIndex = 8;
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Discount Amount";
            // 
            // ViewDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(994, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDiscounts);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lnklblHomeOnViewDealsPg);
            this.Controls.Add(this.btnAddSavings);
            this.Controls.Add(this.lblViewDeals);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewDeals";
            this.Text = "ViewDeals";
            this.Load += new System.EventHandler(this.ViewDeals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewDeals;
        private System.Windows.Forms.Button btnAddSavings;
        private System.Windows.Forms.LinkLabel lnklblHomeOnViewDealsPg;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ListBox lstDiscounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label4;
    }
}