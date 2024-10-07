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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        private void txtBuyingVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyingVehicle b1 = new BuyingVehicle();
            b1.ShowDialog();
        }

        private void btnRenting_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentingAccomodation r1 = new RentingAccomodation();
            r1.ShowDialog();
        }

        private void btnBuyingProperty_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyingProperty p1 = new BuyingProperty();
            p1.ShowDialog();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtGroceries.Text = "";
            txtGrossMonthlyIncome.Text = "";
            txtOtherExpenses.Text = "";
            txtTax.Text = "";
            txtTotalExpenses.Text = "";
            txtTraveCosts.Text = "";
            txtViewTotal.Text = "";
            txtWateLight.Text = "";
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //calculating percentage
            

            double totalMoney;
            decimal Calculate_percentage = (Convert.ToDecimal(txtGrossMonthlyIncome.Text) / 100) * Convert.ToDecimal(txtTax.Text);
            dataGridView1.Rows.Add(txtGrossMonthlyIncome.Text, Calculate_percentage.ToString(), txtTotalExpenses.Text, txtAvailableMoney.Text);

        }

        private void txtOtherExpenses_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTotalExpenses.Text = (float.Parse(txtWateLight.Text) + float.Parse(txtGroceries.Text) + float.Parse(txtTraveCosts.Text) + float.Parse(txtCellphoneTelle.Text) + float.Parse(txtOtherExpenses.Text)).ToString();
            }
            catch { 
            }
        }

        private void txtTotalExpenses_TextChanged(object sender, EventArgs e)
        {
            decimal calculate_percentage = (Convert.ToDecimal(txtGrossMonthlyIncome.Text) / 100) * Convert.ToDecimal(txtTax.Text);
            try
            {
                txtAvailableMoney.Text = (float.Parse(txtGrossMonthlyIncome.Text) - float.Parse(calculate_percentage.ToString()) - float.Parse(txtTotalExpenses.Text)).ToString();
            }
            catch
            { 
            }

        }

        private void txtViewTotal_Click(object sender, EventArgs e)
        {
            double totalMoney;
            decimal Calculate_percentage = (Convert.ToDecimal(txtGrossMonthlyIncome.Text) / 100) * Convert.ToDecimal(txtTax.Text);
            dataGridView1.Rows.Add(txtGrossMonthlyIncome.Text, Calculate_percentage.ToString(), txtTotalExpenses.Text, txtAvailableMoney.Text);

        }
    }
}
