namespace ST10097490_AlphyChauke_PROG6221_POE
{
    partial class BuyingVehicle
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
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchasing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGrossIncome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsurancePremium = new System.Windows.Forms.TextBox();
            this.txtInteretRate = new System.Windows.Forms.TextBox();
            this.txtTotalDeposit = new System.Windows.Forms.TextBox();
            this.txtPurcasingPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(251, 310);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(235, 20);
            this.txtBalance.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Balance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.income,
            this.tax,
            this.model,
            this.Purchasing,
            this.deposit,
            this.interest,
            this.insurance,
            this.Balance});
            this.dataGridView1.Location = new System.Drawing.Point(52, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 166);
            this.dataGridView1.TabIndex = 39;
            // 
            // income
            // 
            this.income.HeaderText = "Monthly Income";
            this.income.Name = "income";
            // 
            // tax
            // 
            this.tax.HeaderText = "TAX";
            this.tax.Name = "tax";
            // 
            // model
            // 
            this.model.HeaderText = "Model Make";
            this.model.Name = "model";
            // 
            // Purchasing
            // 
            this.Purchasing.HeaderText = "Purchasing Price";
            this.Purchasing.Name = "Purchasing";
            // 
            // deposit
            // 
            this.deposit.HeaderText = "Total Deposit";
            this.deposit.Name = "deposit";
            // 
            // interest
            // 
            this.interest.HeaderText = "Interest Rate";
            this.interest.Name = "interest";
            // 
            // insurance
            // 
            this.insurance.HeaderText = "Insurance Premium";
            this.insurance.Name = "insurance";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 37);
            this.button3.TabIndex = 38;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 37;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(251, 89);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(235, 20);
            this.txtTax.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "TAX %";
            // 
            // txtGrossIncome
            // 
            this.txtGrossIncome.Location = new System.Drawing.Point(251, 54);
            this.txtGrossIncome.Name = "txtGrossIncome";
            this.txtGrossIncome.Size = new System.Drawing.Size(235, 20);
            this.txtGrossIncome.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Gross Monthly Income";
            // 
            // txtInsurancePremium
            // 
            this.txtInsurancePremium.Location = new System.Drawing.Point(251, 271);
            this.txtInsurancePremium.Name = "txtInsurancePremium";
            this.txtInsurancePremium.Size = new System.Drawing.Size(235, 20);
            this.txtInsurancePremium.TabIndex = 31;
            this.txtInsurancePremium.TextChanged += new System.EventHandler(this.txtInsurancePremium_TextChanged);
            // 
            // txtInteretRate
            // 
            this.txtInteretRate.Location = new System.Drawing.Point(251, 233);
            this.txtInteretRate.Name = "txtInteretRate";
            this.txtInteretRate.Size = new System.Drawing.Size(235, 20);
            this.txtInteretRate.TabIndex = 30;
            // 
            // txtTotalDeposit
            // 
            this.txtTotalDeposit.Location = new System.Drawing.Point(251, 197);
            this.txtTotalDeposit.Name = "txtTotalDeposit";
            this.txtTotalDeposit.Size = new System.Drawing.Size(235, 20);
            this.txtTotalDeposit.TabIndex = 29;
            // 
            // txtPurcasingPrice
            // 
            this.txtPurcasingPrice.Location = new System.Drawing.Point(251, 162);
            this.txtPurcasingPrice.Name = "txtPurcasingPrice";
            this.txtPurcasingPrice.Size = new System.Drawing.Size(235, 20);
            this.txtPurcasingPrice.TabIndex = 28;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(251, 125);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(235, 20);
            this.txtModel.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Insurance Premium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Interest Rate %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total Deposit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Purchasing Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Model Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "BUYING A VEHICLE";
            // 
            // BuyingVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(992, 517);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrossIncome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInsurancePremium);
            this.Controls.Add(this.txtInteretRate);
            this.Controls.Add(this.txtTotalDeposit);
            this.Controls.Add(this.txtPurcasingPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BuyingVehicle";
            this.Text = "BuyingVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchasing;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGrossIncome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInsurancePremium;
        private System.Windows.Forms.TextBox txtInteretRate;
        private System.Windows.Forms.TextBox txtTotalDeposit;
        private System.Windows.Forms.TextBox txtPurcasingPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}