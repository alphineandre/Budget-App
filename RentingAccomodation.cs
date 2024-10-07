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
    public partial class RentingAccomodation : Form
    {
        public RentingAccomodation()
        {
            InitializeComponent();
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtMoynth.Text);
        }

        private void TXTEXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Budget f1 = new Budget);
            f1.ShowDialog();
        }
    }
}
