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
        public Hub()
        {
            InitializeComponent();
        }

        private void BillCalculatorLink_MouseClick(object sender, MouseEventArgs e)
        {
            billCalculatorForm = new BillCalculatorForm();
            billCalculatorForm.Show();
        }
    }
}
