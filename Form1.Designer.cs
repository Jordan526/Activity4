namespace Activity_4
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
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.numberOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.numberOfHoursTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSeconds = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.introductionTextBox = new System.Windows.Forms.TextBox();
            this.numberOfMinutesLabel = new System.Windows.Forms.Label();
            this.numberOfSecondsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfMinutesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(224, 79);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(155, 20);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numberOfDaysTextBox
            // 
            this.numberOfDaysTextBox.Location = new System.Drawing.Point(224, 152);
            this.numberOfDaysTextBox.Name = "numberOfDaysTextBox";
            this.numberOfDaysTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberOfDaysTextBox.TabIndex = 1;
            this.numberOfDaysTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numberOfHoursTextBox
            // 
            this.numberOfHoursTextBox.Location = new System.Drawing.Point(224, 229);
            this.numberOfHoursTextBox.Name = "numberOfHoursTextBox";
            this.numberOfHoursTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberOfHoursTextBox.TabIndex = 2;
            this.numberOfHoursTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numberOfSeconds
            // 
            this.numberOfSeconds.AutoSize = true;
            this.numberOfSeconds.Location = new System.Drawing.Point(73, 86);
            this.numberOfSeconds.Name = "numberOfSeconds";
            this.numberOfSeconds.Size = new System.Drawing.Size(132, 13);
            this.numberOfSeconds.TabIndex = 3;
            this.numberOfSeconds.Text = "Enter Number of Seconds:";
            this.numberOfSeconds.Click += new System.EventHandler(this.numberOfSeconds_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(73, 159);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(86, 13);
            this.daysLabel.TabIndex = 4;
            this.daysLabel.Text = "Number of Days:";
            this.daysLabel.Click += new System.EventHandler(this.daysLabel_Click);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(73, 236);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(90, 13);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "Number of Hours:";
            this.hoursLabel.Click += new System.EventHandler(this.hoursLabel_Click);
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(73, 311);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(104, 13);
            this.secondsLabel.TabIndex = 6;
            this.secondsLabel.Text = "Number of Seconds:";
            this.secondsLabel.Click += new System.EventHandler(this.secondsLabel_Click);
            // 
            // introductionTextBox
            // 
            this.introductionTextBox.Location = new System.Drawing.Point(125, 12);
            this.introductionTextBox.Name = "introductionTextBox";
            this.introductionTextBox.Size = new System.Drawing.Size(191, 20);
            this.introductionTextBox.TabIndex = 8;
            this.introductionTextBox.Text = "Number of Seconds Elapsed Converter";
            this.introductionTextBox.TextChanged += new System.EventHandler(this.introductionTextBox_TextChanged);
            // 
            // numberOfMinutesLabel
            // 
            this.numberOfMinutesLabel.AutoSize = true;
            this.numberOfMinutesLabel.Location = new System.Drawing.Point(73, 372);
            this.numberOfMinutesLabel.Name = "numberOfMinutesLabel";
            this.numberOfMinutesLabel.Size = new System.Drawing.Size(96, 13);
            this.numberOfMinutesLabel.TabIndex = 9;
            this.numberOfMinutesLabel.Text = "Number of Minutes";
            this.numberOfMinutesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfSecondsTextBox
            // 
            this.numberOfSecondsTextBox.Location = new System.Drawing.Point(224, 304);
            this.numberOfSecondsTextBox.Name = "numberOfSecondsTextBox";
            this.numberOfSecondsTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberOfSecondsTextBox.TabIndex = 7;
            this.numberOfSecondsTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numberOfMinutesTextBox
            // 
            this.numberOfMinutesTextBox.Location = new System.Drawing.Point(224, 365);
            this.numberOfMinutesTextBox.Name = "numberOfMinutesTextBox";
            this.numberOfMinutesTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberOfMinutesTextBox.TabIndex = 10;
            this.numberOfMinutesTextBox.TextChanged += new System.EventHandler(this.numberOfMinutesTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 453);
            this.Controls.Add(this.numberOfMinutesTextBox);
            this.Controls.Add(this.numberOfMinutesLabel);
            this.Controls.Add(this.introductionTextBox);
            this.Controls.Add(this.numberOfSecondsTextBox);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.numberOfSeconds);
            this.Controls.Add(this.numberOfHoursTextBox);
            this.Controls.Add(this.numberOfDaysTextBox);
            this.Controls.Add(this.userTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox numberOfDaysTextBox;
        private System.Windows.Forms.TextBox numberOfHoursTextBox;
        private System.Windows.Forms.Label numberOfSeconds;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.TextBox introductionTextBox;
        private System.Windows.Forms.Label numberOfMinutesLabel;
        private System.Windows.Forms.TextBox numberOfSecondsTextBox;
        private System.Windows.Forms.TextBox numberOfMinutesTextBox;
    }
}

