namespace ST10097490_AlphyChauke_PROG6221_POE
{
    partial class RentingAccomodation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubmit = new System.Windows.Forms.Button();
            this.txtMoynth = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTEXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RENTING ACCOMODATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mnthly Repayments";
            // 
            // txtSubmit
            // 
            this.txtSubmit.Location = new System.Drawing.Point(134, 108);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.Size = new System.Drawing.Size(75, 23);
            this.txtSubmit.TabIndex = 2;
            this.txtSubmit.Text = "SUBMIT";
            this.txtSubmit.UseVisualStyleBackColor = true;
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // txtMoynth
            // 
            this.txtMoynth.Location = new System.Drawing.Point(172, 68);
            this.txtMoynth.Name = "txtMoynth";
            this.txtMoynth.Size = new System.Drawing.Size(100, 20);
            this.txtMoynth.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(113, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 60);
            this.dataGridView1.TabIndex = 4;
            // 
            // total
            // 
            this.total.HeaderText = "Monthly Amount";
            this.total.Name = "total";
            // 
            // TXTEXIT
            // 
            this.TXTEXIT.Location = new System.Drawing.Point(215, 108);
            this.TXTEXIT.Name = "TXTEXIT";
            this.TXTEXIT.Size = new System.Drawing.Size(75, 23);
            this.TXTEXIT.TabIndex = 5;
            this.TXTEXIT.Text = "EXIT";
            this.TXTEXIT.UseVisualStyleBackColor = true;
            this.TXTEXIT.Click += new System.EventHandler(this.TXTEXIT_Click);
            // 
            // RentingAccomodation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 262);
            this.Controls.Add(this.TXTEXIT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMoynth);
            this.Controls.Add(this.txtSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentingAccomodation";
            this.Text = "RentingAccomodation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtSubmit;
        private System.Windows.Forms.TextBox txtMoynth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button TXTEXIT;
    }
}