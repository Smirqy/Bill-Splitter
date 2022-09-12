using System.Security.Cryptography;

namespace BillSplitter
{
    public partial class BillCalculatorForm : Form
    {
        private List<Tuple<string,double>> bills;
        public BillCalculatorForm()
        {
            InitializeComponent();
            bills = new List<Tuple<string,double>>();
        }

        #region listeners
        private void AddCostButton_Click(object sender, EventArgs e)
        {
            SplitCost();
            UpdateReceipt();
        }

        #endregion

        #region Helpers

        private void SplitCost()
        {
            List<string> payers =  new List<string>();
            foreach (DataGridViewRow row in PeopleGridBox.Rows)
            {
                string name = (string)row.Cells[0].FormattedValue;
                Boolean isChecked = (Boolean)row.Cells[1].FormattedValue;
                if (name != null && name != "")
                {
                    if (HasName(name))
                    {
                        if (isChecked)
                            payers.Add(name);
                    }
                    else
                    {
                        if (row.Index < bills.Count)
                            bills[row.Index] = new Tuple<string,double>(name, bills[row.Index].Item2);
                        else 
                            bills.Add(new Tuple<string, double>(name, 0));

                        if (isChecked)
                            payers.Add(name);
                    }
                }
            }

            double costToAdd = Double.Parse(AddCostBox.Text) / payers.Count;
            for(int i = 0; i < payers.Count; i++)
            {
                bills[i] = new Tuple<string, double>(bills[i].Item1,bills[i].Item2 + costToAdd);
            }

            ValidateValues();
        }

        private bool HasName(string name)
        {
            foreach(Tuple<string, double> pair in bills)
            {
                if (pair.Item1.Equals(name))
                    return true;
            }
            return false;
        }

        private void ValidateValues()
        {

        }

        private void UpdateReceipt()
        {
            ReceiptBox.Items.Clear();
            string item = "";
            string name;
            double cost;
            for(int i = 0; i < bills.Count; i++)
            {
                name = bills[i].Item1;
                cost = bills[i].Item2;

                item = name + ": " + "$" + Math.Round(cost,2) +"\n";
                ReceiptBox.Items.Add(item);
            }
        }

        #endregion
    }
}