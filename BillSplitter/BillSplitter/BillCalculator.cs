namespace BillSplitter
{
    public partial class BillCalculatorForm : Form
    {
        private Dictionary<String, Double> bills;
        public BillCalculatorForm()
        {
            InitializeComponent();
            bills = new Dictionary<String, Double>();
        }

        #region listeners
        private void AddCostButton_Click(object sender, EventArgs e)
        {
           foreach(DataGridViewRow row in PeopleGridBox.Rows)
            {
                String name = row.Cells[0].Value.ToString();
                Boolean isChecked = row.Cells[1].Value.ToString().Equals("checked");
                if (name != null && name != "")
                {
                    if (bills.ContainsKey(name))
                    {
                        if(isChecked)
                        {

                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        if (!isChecked)
                        {

                        }
                        else
                        {
                            bills[name] = 0;
                        }
                    }
                }
            }
        }

        #endregion
    }
}