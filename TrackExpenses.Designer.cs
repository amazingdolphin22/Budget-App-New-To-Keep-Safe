namespace BudgetApp
{
    partial class TrackExpenses
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
            this.lblTrackExpenses = new System.Windows.Forms.Label();
            this.lnklblHomeOnTrackExpensesPg = new System.Windows.Forms.LinkLabel();
            this.lvExpenseRecord = new System.Windows.Forms.ListView();
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmountSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCategoryOfExpense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountOfExpense = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSumOfExpenses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrackExpenses
            // 
            this.lblTrackExpenses.AutoSize = true;
            this.lblTrackExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTrackExpenses.Location = new System.Drawing.Point(264, 28);
            this.lblTrackExpenses.Name = "lblTrackExpenses";
            this.lblTrackExpenses.Size = new System.Drawing.Size(261, 39);
            this.lblTrackExpenses.TabIndex = 0;
            this.lblTrackExpenses.Text = "Track Expenses";
            // 
            // lnklblHomeOnTrackExpensesPg
            // 
            this.lnklblHomeOnTrackExpensesPg.AutoSize = true;
            this.lnklblHomeOnTrackExpensesPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblHomeOnTrackExpensesPg.Location = new System.Drawing.Point(16, 415);
            this.lnklblHomeOnTrackExpensesPg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblHomeOnTrackExpensesPg.Name = "lnklblHomeOnTrackExpensesPg";
            this.lnklblHomeOnTrackExpensesPg.Size = new System.Drawing.Size(81, 25);
            this.lnklblHomeOnTrackExpensesPg.TabIndex = 1;
            this.lnklblHomeOnTrackExpensesPg.TabStop = true;
            this.lnklblHomeOnTrackExpensesPg.Text = "< Home";
            this.lnklblHomeOnTrackExpensesPg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHomeOnTrackExpensesPg_LinkClicked);
            // 
            // lvExpenseRecord
            // 
            this.lvExpenseRecord.BackColor = System.Drawing.Color.White;
            this.lvExpenseRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvExpenseRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCategory,
            this.chAmountSpent});
            this.lvExpenseRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExpenseRecord.FullRowSelect = true;
            this.lvExpenseRecord.GridLines = true;
            this.lvExpenseRecord.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvExpenseRecord.HideSelection = false;
            this.lvExpenseRecord.Location = new System.Drawing.Point(39, 198);
            this.lvExpenseRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvExpenseRecord.Name = "lvExpenseRecord";
            this.lvExpenseRecord.Size = new System.Drawing.Size(722, 168);
            this.lvExpenseRecord.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lvExpenseRecord, "This displays a cumulative itemized list of all expenses for the month.");
            this.lvExpenseRecord.UseCompatibleStateImageBehavior = false;
            this.lvExpenseRecord.View = System.Windows.Forms.View.Details;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category of Expense";
            this.chCategory.Width = 250;
            // 
            // chAmountSpent
            // 
            this.chAmountSpent.Text = "Amount Spent($)";
            this.chAmountSpent.Width = 200;
            // 
            // txtCategoryOfExpense
            // 
            this.txtCategoryOfExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryOfExpense.Location = new System.Drawing.Point(39, 133);
            this.txtCategoryOfExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoryOfExpense.Name = "txtCategoryOfExpense";
            this.txtCategoryOfExpense.Size = new System.Drawing.Size(252, 36);
            this.txtCategoryOfExpense.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtCategoryOfExpense, "Type the category of your expenditure.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category of Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // txtAmountOfExpense
            // 
            this.txtAmountOfExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOfExpense.Location = new System.Drawing.Point(329, 134);
            this.txtAmountOfExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountOfExpense.Name = "txtAmountOfExpense";
            this.txtAmountOfExpense.Size = new System.Drawing.Size(248, 36);
            this.txtAmountOfExpense.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtAmountOfExpense, "Type the amount spent.");
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(608, 133);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(153, 37);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Be sure to enter both the category and amount before pressing this Enter button.");
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // lblSumOfExpenses
            // 
            this.lblSumOfExpenses.BackColor = System.Drawing.Color.White;
            this.lblSumOfExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSumOfExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOfExpenses.Location = new System.Drawing.Point(376, 382);
            this.lblSumOfExpenses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumOfExpenses.Name = "lblSumOfExpenses";
            this.lblSumOfExpenses.Size = new System.Drawing.Size(268, 38);
            this.lblSumOfExpenses.TabIndex = 9;
            this.lblSumOfExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sum of Expenses";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Expense";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TrackExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSumOfExpenses);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountOfExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryOfExpense);
            this.Controls.Add(this.lvExpenseRecord);
            this.Controls.Add(this.lnklblHomeOnTrackExpensesPg);
            this.Controls.Add(this.lblTrackExpenses);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrackExpenses";
            this.Text = "TrackExpenses";
            this.Load += new System.EventHandler(this.TrackExpenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackExpenses;
        private System.Windows.Forms.LinkLabel lnklblHomeOnTrackExpensesPg;
        private System.Windows.Forms.ListView lvExpenseRecord;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chAmountSpent;
        private System.Windows.Forms.TextBox txtCategoryOfExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountOfExpense;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblSumOfExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
    }
}