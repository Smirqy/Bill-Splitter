using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillSplitter
{
    public partial class Hub : Form
    {
        private BillCalculatorForm billCalculatorForm;
        private SplitCalculator splitCalculator;
        public Hub()
        {
            InitializeComponent();
        }

        private void BillCalculatorLink_MouseClick(object sender, MouseEventArgs e)
        {
            billCalculatorForm = new BillCalculatorForm();
            billCalculatorForm.FormClosed += ShowHub;
            this.Hide();
            billCalculatorForm.Show();
        }

        private void SplitCalculatorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            splitCalculator = new SplitCalculator();
            this.Hide();
            splitCalculator.FormClosed += ShowHub;
            splitCalculator.Show();
            
        }

        private void ShowHub(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
