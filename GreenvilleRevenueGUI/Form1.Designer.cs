namespace GreenvilleRevenueGUI
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.expectedRevenueLabel = new System.Windows.Forms.Label();
            this.greaterLabel = new System.Windows.Forms.Label();
            this.contestantDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the number of contestants last year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the number of contestants this year:";
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.Location = new System.Drawing.Point(264, 16);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(56, 20);
            this.lastYearTextBox.TabIndex = 3;
            this.lastYearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastYearTextBox.TextChanged += new System.EventHandler(this.lastYearTextBox_TextChanged);
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.Location = new System.Drawing.Point(264, 40);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(56, 20);
            this.thisYearTextBox.TabIndex = 4;
            this.thisYearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expectedRevenueLabel
            // 
            this.expectedRevenueLabel.AutoSize = true;
            this.expectedRevenueLabel.Location = new System.Drawing.Point(16, 128);
            this.expectedRevenueLabel.Name = "expectedRevenueLabel";
            this.expectedRevenueLabel.Size = new System.Drawing.Size(35, 13);
            this.expectedRevenueLabel.TabIndex = 5;
            this.expectedRevenueLabel.Text = "label3";
            this.expectedRevenueLabel.Visible = false;
            // 
            // greaterLabel
            // 
            this.greaterLabel.AutoSize = true;
            this.greaterLabel.Location = new System.Drawing.Point(16, 160);
            this.greaterLabel.Name = "greaterLabel";
            this.greaterLabel.Size = new System.Drawing.Size(35, 13);
            this.greaterLabel.TabIndex = 6;
            this.greaterLabel.Text = "label3";
            this.greaterLabel.Visible = false;
            // 
            // contestantDataButton
            // 
            this.contestantDataButton.Enabled = false;
            this.contestantDataButton.Location = new System.Drawing.Point(96, 184);
            this.contestantDataButton.Name = "contestantDataButton";
            this.contestantDataButton.Size = new System.Drawing.Size(200, 32);
            this.contestantDataButton.TabIndex = 7;
            this.contestantDataButton.Text = "Enter Contestant Data";
            this.contestantDataButton.UseVisualStyleBackColor = true;
            this.contestantDataButton.Click += new System.EventHandler(this.contestantDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.contestantDataButton);
            this.Controls.Add(this.greaterLabel);
            this.Controls.Add(this.expectedRevenueLabel);
            this.Controls.Add(this.thisYearTextBox);
            this.Controls.Add(this.lastYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Greenville Revenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.Label expectedRevenueLabel;
        private System.Windows.Forms.Label greaterLabel;
        private System.Windows.Forms.Button contestantDataButton;
    }
}

