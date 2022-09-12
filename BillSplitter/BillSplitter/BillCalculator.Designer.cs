namespace BillSplitter
{
    partial class BillCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PeopleGridBox = new System.Windows.Forms.DataGridView();
            this.AddCostButton = new System.Windows.Forms.Button();
            this.ReceiptBox = new System.Windows.Forms.ListBox();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.AddCostBox = new System.Windows.Forms.TextBox();
            this.AddCostLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayingCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(12, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(139, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Calculate Your Bill!";
            // 
            // PeopleGridBox
            // 
            this.PeopleGridBox.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PeopleGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.PayingCol});
            this.PeopleGridBox.Location = new System.Drawing.Point(34, 69);
            this.PeopleGridBox.Name = "PeopleGridBox";
            this.PeopleGridBox.RowHeadersVisible = false;
            this.PeopleGridBox.RowHeadersWidth = 51;
            this.PeopleGridBox.RowTemplate.Height = 29;
            this.PeopleGridBox.Size = new System.Drawing.Size(209, 286);
            this.PeopleGridBox.TabIndex = 1;
            // 
            // AddCostButton
            // 
            this.AddCostButton.Location = new System.Drawing.Point(87, 428);
            this.AddCostButton.Name = "AddCostButton";
            this.AddCostButton.Size = new System.Drawing.Size(94, 29);
            this.AddCostButton.TabIndex = 2;
            this.AddCostButton.Text = "Add";
            this.AddCostButton.UseVisualStyleBackColor = true;
            this.AddCostButton.Click += new System.EventHandler(this.AddCostButton_Click);
            // 
            // ReceiptBox
            // 
            this.ReceiptBox.FormattingEnabled = true;
            this.ReceiptBox.ItemHeight = 20;
            this.ReceiptBox.Items.AddRange(new object[] {
            "Totals:"});
            this.ReceiptBox.Location = new System.Drawing.Point(326, 69);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(150, 284);
            this.ReceiptBox.TabIndex = 3;
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.AutoSize = true;
            this.ReceiptLabel.Location = new System.Drawing.Point(352, 46);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(103, 20);
            this.ReceiptLabel.TabIndex = 4;
            this.ReceiptLabel.Text = "Running Total:";
            // 
            // AddCostBox
            // 
            this.AddCostBox.Location = new System.Drawing.Point(73, 395);
            this.AddCostBox.Name = "AddCostBox";
            this.AddCostBox.Size = new System.Drawing.Size(125, 27);
            this.AddCostBox.TabIndex = 5;
            // 
            // AddCostLabel
            // 
            this.AddCostLabel.AutoSize = true;
            this.AddCostLabel.Location = new System.Drawing.Point(87, 372);
            this.AddCostLabel.Name = "AddCostLabel";
            this.AddCostLabel.Size = new System.Drawing.Size(94, 20);
            this.AddCostLabel.TabIndex = 7;
            this.AddCostLabel.Text = "Price to Add:";
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(306, 372);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(50, 20);
            this.HelpLabel.TabIndex = 8;
            this.HelpLabel.Text = "Help...";
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MaxInputLength = 12;
            this.NameCol.MinimumWidth = 6;
            this.NameCol.Name = "NameCol";
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameCol.ToolTipText = "Name of Payer";
            this.NameCol.Width = 125;
            // 
            // PayingCol
            // 
            this.PayingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PayingCol.HeaderText = "Paying";
            this.PayingCol.MinimumWidth = 6;
            this.PayingCol.Name = "PayingCol";
            this.PayingCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PayingCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PayingCol.Width = 81;
            // 
            // BillCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 505);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.AddCostLabel);
            this.Controls.Add(this.AddCostBox);
            this.Controls.Add(this.ReceiptLabel);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.AddCostButton);
            this.Controls.Add(this.PeopleGridBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.Name = "BillCalculatorForm";
            this.Text = "Bill Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private DataGridView PeopleGridBox;
        private Button AddCostButton;
        private ListBox ReceiptBox;
        private Label ReceiptLabel;
        private TextBox AddCostBox;
        private Label AddCostLabel;
        private Label HelpLabel;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewCheckBoxColumn PayingCol;
    }
}