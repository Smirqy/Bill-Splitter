namespace BillSplitter
{
    partial class SplitCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PeopleGridBox = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmntCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PeopleGridBox
            // 
            this.PeopleGridBox.AllowUserToAddRows = false;
            this.PeopleGridBox.AllowUserToDeleteRows = false;
            this.PeopleGridBox.AllowUserToResizeColumns = false;
            this.PeopleGridBox.AllowUserToResizeRows = false;
            this.PeopleGridBox.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PeopleGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeopleGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.AmntCol});
            this.PeopleGridBox.Location = new System.Drawing.Point(35, 80);
            this.PeopleGridBox.Name = "PeopleGridBox";
            this.PeopleGridBox.RowHeadersVisible = false;
            this.PeopleGridBox.RowHeadersWidth = 51;
            this.PeopleGridBox.RowTemplate.Height = 29;
            this.PeopleGridBox.Size = new System.Drawing.Size(254, 286);
            this.PeopleGridBox.TabIndex = 2;
            this.PeopleGridBox.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeopleGridBox_CellEndEdit);
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
            // AmntCol
            // 
            this.AmntCol.HeaderText = "Amount Paid";
            this.AmntCol.MinimumWidth = 6;
            this.AmntCol.Name = "AmntCol";
            this.AmntCol.Width = 125;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(35, 387);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(109, 29);
            this.AddRowButton.TabIndex = 3;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(180, 387);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(109, 29);
            this.RemoveRowButton.TabIndex = 4;
            this.RemoveRowButton.Text = "Remove Row";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 20;
            this.OutputListBox.Location = new System.Drawing.Point(378, 80);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(218, 284);
            this.OutputListBox.TabIndex = 5;
            // 
            // SplitCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 636);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.PeopleGridBox);
            this.Name = "SplitCalculator";
            this.Text = "SplitCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.PeopleGridBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView PeopleGridBox;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn AmntCol;
        private Button AddRowButton;
        private Button RemoveRowButton;
        private ListBox OutputListBox;
    }
}