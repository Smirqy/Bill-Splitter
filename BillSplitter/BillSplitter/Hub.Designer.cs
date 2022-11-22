namespace BillSplitter
{
    partial class Hub
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
            this.HubTitleLabel = new System.Windows.Forms.Label();
            this.BillCalculatorLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SplitCalculatorLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HubTitleLabel
            // 
            this.HubTitleLabel.AutoSize = true;
            this.HubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.HubTitleLabel.Location = new System.Drawing.Point(239, 42);
            this.HubTitleLabel.Name = "HubTitleLabel";
            this.HubTitleLabel.Size = new System.Drawing.Size(338, 45);
            this.HubTitleLabel.TabIndex = 0;
            this.HubTitleLabel.Text = "Choose a Calculator!";
            // 
            // BillCalculatorLink
            // 
            this.BillCalculatorLink.AutoSize = true;
            this.BillCalculatorLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BillCalculatorLink.Location = new System.Drawing.Point(11, 10);
            this.BillCalculatorLink.Name = "BillCalculatorLink";
            this.BillCalculatorLink.Size = new System.Drawing.Size(131, 28);
            this.BillCalculatorLink.TabIndex = 2;
            this.BillCalculatorLink.TabStop = true;
            this.BillCalculatorLink.Text = "Bill Calculator";
            this.BillCalculatorLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BillCalculatorLink_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BillCalculatorLink);
            this.panel1.Location = new System.Drawing.Point(161, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 53);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SplitCalculatorLink);
            this.panel3.Location = new System.Drawing.Point(494, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 53);
            this.panel3.TabIndex = 5;
            // 
            // SplitCalculatorLink
            // 
            this.SplitCalculatorLink.AutoSize = true;
            this.SplitCalculatorLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SplitCalculatorLink.Location = new System.Drawing.Point(4, 9);
            this.SplitCalculatorLink.Name = "SplitCalculatorLink";
            this.SplitCalculatorLink.Size = new System.Drawing.Size(145, 28);
            this.SplitCalculatorLink.TabIndex = 2;
            this.SplitCalculatorLink.TabStop = true;
            this.SplitCalculatorLink.Text = "Split Calculator";
            this.SplitCalculatorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SplitCalculatorLink_LinkClicked);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HubTitleLabel);
            this.Name = "Hub";
            this.Text = "Hub";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HubTitleLabel;
        private LinkLabel BillCalculatorLink;
        private Panel panel1;
        private Panel panel3;
        private LinkLabel SplitCalculatorLink;
    }
}