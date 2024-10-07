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
    public partial class BuyingVehicle : Form
    {
        public BuyingVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Budget f1 = new Budget();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBalance.Text = "";
            txtGrossIncome.Text = "";
            txtInsurancePremium.Text = "";
            txtInteretRate.Text = "";
            txtModel.Text = "";
            txtPurcasingPrice.Text = "";
            txtTax.Text = "";
            txtTotalDeposit.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalMoney;
            decimal Calculate_percentage = (Convert.ToDecimal(txtGrossIncome.Text) / 100) * Convert.ToDecimal(txtTax.Text);
            dataGridView1.Rows.Add(txtGrossIncome.Text, Calculate_percentage.ToString(), txtModel.Text, txtPurcasingPrice.Text  , txtTotalDeposit.Text, txtInteretRate.Text, txtInsurancePremium.Text, txtBalance.Text);
        }

        private void txtInsurancePremium_TextChanged(object sender, EventArgs e)
        {
            decimal Calculate_percentage = (Convert.ToDecimal(txtGrossIncome.Text) / 100) * Convert.ToDecimal(txtTax.Text);
            decimal Calculate_percentag = (Convert.ToDecimal(txtGrossIncome.Text) / 100) * Convert.ToDecimal(txtInteretRate.Text);

            try
            {
                txtBalance.Text = (float.Parse(txtGrossIncome.Text)  - float.Parse(txtTotalDeposit.Text) - float.Parse(txtInsurancePremium.Text)).ToString();
            }
            catch
            {
            }
        }
    }
}
