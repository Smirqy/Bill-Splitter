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
    public partial class SplitCalculator : Form
    {
        private List<string> names = new List<string>();
        private List<double> amnt_owed = new List<double>();
        double total_paid = 0;
        int num_people = 0;
        public SplitCalculator()
        {
            InitializeComponent();
            initFields();
        }

        #region Helpers
        private void initFields()
        {
            OutputListBox.Items.Add("Total: " + total_paid);
        }

        private void UpdateOutput()
        {
            OutputListBox.Items.Clear();
            OutputListBox.Items.Add("Total: " + total_paid);
            OutputListBox.Items.Add("");
            foreach (string name in names)
            {
                if(!name.Equals(""))
                    OutputListBox.Items.Add(name);
            }
        }

        private void UpdateTotalPaid()
        {
            total_paid = 0;
            foreach (DataGridViewRow row in PeopleGridBox.Rows)
                total_paid += double.Parse(row.Cells[1].Value.ToString());
        }

        private void UpdateAmountOwed()
        {
            double equalPayAmnt = total_paid / num_people;
            while(false)
            { }
        }

        #endregion

        #region Listeners
        private void AddRowButton_Click(object sender, EventArgs e)
        {
            var temp = PeopleGridBox.Rows.Add();
            PeopleGridBox.Rows[temp].Cells[1].Value = 0;
            names.Add("");
            amnt_owed.Add(0);
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(DataGridViewCell cell in PeopleGridBox.SelectedCells){
                index = cell.RowIndex;
                PeopleGridBox.Rows.RemoveAt(index);
                names.RemoveAt(index);
                total_paid -= amnt_owed[index];
                amnt_owed.RemoveAt(index);
            }

            UpdateTotalPaid();
            UpdateAmountOwed();
            UpdateOutput();
        }

        private void PeopleGridBox_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                names[e.RowIndex] = PeopleGridBox.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + ": ";
                num_people++;
            }

            UpdateTotalPaid();
            UpdateAmountOwed();
            UpdateOutput();
        }
        #endregion


    }
}
