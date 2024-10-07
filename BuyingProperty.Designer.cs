namespace ST10097490_AlphyChauke_PROG6221_POE
{
    partial class BuyingProperty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.purchasingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalaDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMonthlsToRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyRepayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonthlyRep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemeiningBlance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfMonths = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.txtPurchaseP = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchasingPrice,
            this.TotalaDeposit,
            this.interestRate,
            this.numberOfMonthlsToRepay,
            this.RemainingBalance,
            this.MonthlyRepayments});
            this.dataGridView1.Location = new System.Drawing.Point(29, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 59;
            // 
            // purchasingPrice
            // 
            this.purchasingPrice.HeaderText = "Purchasing Price";
            this.purchasingPrice.Name = "purchasingPrice";
            // 
            // TotalaDeposit
            // 
            this.TotalaDeposit.HeaderText = "Total Deposit";
            this.TotalaDeposit.Name = "TotalaDeposit";
            // 
            // interestRate
            // 
            this.interestRate.HeaderText = "Interest Rate";
            this.interestRate.Name = "interestRate";
            // 
            // numberOfMonthlsToRepay
            // 
            this.numberOfMonthlsToRepay.HeaderText = "Number Of Months";
            this.numberOfMonthlsToRepay.Name = "numberOfMonthlsToRepay";
            // 
            // RemainingBalance
            // 
            this.RemainingBalance.HeaderText = "Remaining Balance";
            this.RemainingBalance.Name = "RemainingBalance";
            // 
            // MonthlyRepayments
            // 
            this.MonthlyRepayments.HeaderText = "Monthly Repayments";
            this.MonthlyRepayments.Name = "MonthlyRepayments";
            // 
            // txtMonthlyRep
            // 
            this.txtMonthlyRep.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMonthlyRep.Location = new System.Drawing.Point(267, 261);
            this.txtMonthlyRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonthlyRep.Multiline = true;
            this.txtMonthlyRep.Name = "txtMonthlyRep";
            this.txtMonthlyRep.Size = new System.Drawing.Size(232, 39);
            this.txtMonthlyRep.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Monthly Repayment";
            // 
            // txtRemeiningBlance
            // 
            this.txtRemeiningBlance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRemeiningBlance.Location = new System.Drawing.Point(267, 214);
            this.txtRemeiningBlance.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemeiningBlance.Multiline = true;
            this.txtRemeiningBlance.Name = "txtRemeiningBlance";
            this.txtRemeiningBlance.Size = new System.Drawing.Size(232, 39);
            this.txtRemeiningBlance.TabIndex = 56;
            this.txtRemeiningBlance.TextChanged += new System.EventHandler(this.txtRemeiningBlance_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Remaining Balance";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(403, 328);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 31);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(283, 328);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 31);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Number of months to repay";
            // 
            // txtNumberOfMonths
            // 
            this.txtNumberOfMonths.Location = new System.Drawing.Point(267, 182);
            this.txtNumberOfMonths.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNumberOfMonths.Name = "txtNumberOfMonths";
            this.txtNumberOfMonths.Size = new System.Drawing.Size(232, 20);
            this.txtNumberOfMonths.TabIndex = 51;
            this.txtNumberOfMonths.TextChanged += new System.EventHandler(this.txtNumberOfMonths_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(267, 148);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(232, 20);
            this.txtInterestRate.TabIndex = 50;
            // 
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(267, 114);
            this.txtTotalDeposit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.Size = new System.Drawing.Size(232, 20);
            this.txtTotalDeposit.TabIndex = 49;
            // 
            // txtPurchaseP
            // 
            this.txtPurchaseP.Location = new System.Drawing.Point(267, 79);
            this.txtPurchaseP.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPurchaseP.Name = "txtPurchaseP";
            this.txtPurchaseP.Size = new System.Drawing.Size(232, 20);
            this.txtPurchaseP.TabIndex = 48;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(152, 328);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 31);
            this.btnSubmit.TabIndex = 47;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Total deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Purchase price of property";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 43;
            this.label1.Text = "BUY A PROPERTY";
            // 
            // BuyingProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMonthlyRep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemeiningBlance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberOfMonths);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtTotalDeposit);
            this.Controls.Add(this.txtPurchaseP);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuyingProperty";
            this.Text = "BuyingProperty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalaDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMonthlsToRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyRepayments;
        private System.Windows.Forms.TextBox txtMonthlyRep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemeiningBlance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfMonths;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.TextBox txtPurchaseP;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}