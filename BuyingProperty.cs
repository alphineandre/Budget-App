using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10097490_AlphyChauke_PROG6221_POE
{
    public partial class BuyingProperty : Form
    {
        public BuyingProperty()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal Calculate_percentage = (Convert.ToDecimal(txtPurchaseP.Text) / 100) * Convert.ToDecimal(txtInterestRate.Text);

            dataGridView1.Rows.Add(txtPurchaseP.Text, txtTotalDeposit.Text, Calculate_percentage.ToString(), txtNumberOfMonths.Text,  txtRemeiningBlance.Text, txtMonthlyRep.Text );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInterestRate.Text = "";
            txtMonthlyRep.Text = "";
            txtNumberOfMonths.Text = "";
            txtPurchaseP.Text = "";
            txtRemeiningBlance.Text = "";
            txtTotalDeposit.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Budget f1 = new Budget();
            f1.ShowDialog();


        }

        private void txtNumberOfMonths_TextChanged(object sender, EventArgs e)
        {
            decimal Calculate_percentage = (Convert.ToDecimal(txtPurchaseP.Text) / 100) * Convert.ToDecimal(txtInterestRate.Text);

            try
            {
                txtRemeiningBlance.Text = (float.Parse(txtPurchaseP.Text) - float.Parse(txtTotalDeposit.Text) - float.Parse(txtInterestRate.Text) ).ToString();
            }
            catch
            {
            }
        }

        private void txtRemeiningBlance_TextChanged(object sender, EventArgs e)
        {
            decimal Calculate_percentage = (Convert.ToDecimal(txtPurchaseP.Text) / 100) * Convert.ToDecimal(txtInterestRate.Text);

            try
            {
                txtMonthlyRep.Text = ((float.Parse(txtPurchaseP.Text) - float.Parse(txtTotalDeposit.Text) - float.Parse(txtInterestRate.Text)) / float.Parse(txtNumberOfMonths.Text)).ToString();
            }
            catch
            {
            }
        }
    }
}
