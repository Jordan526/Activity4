using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void introductionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int userSeconds;
        int secondCount; 
        int minuteCount;
        int hourCount;
        int dayCount;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userSeconds = Convert.ToInt32(userTextBox.Text);
            for (int i = 0; i < userSeconds; i++)
            {
                secondCount++;
                if (secondCount >= 60)
                {
                    secondCount = 0;
                    minuteCount++;
                } 
                 if (minuteCount >= 60)
                {
                    minuteCount = 0;
                    hourCount++;
                } 
                 if(hourCount >= 24)
                {
                    hourCount = 0;
                    dayCount++;
                }
            
            }
            secondCount = Convert.ToInt32(secondCount);
            numberOfSecondsTextBox.Text = secondCount.ToString();
            numberOfMinutesTextBox.Text = minuteCount.ToString();
            numberOfHoursTextBox.Text = hourCount.ToString();
            numberOfDaysTextBox.Text = dayCount.ToString();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void numberOfSeconds_Click(object sender, EventArgs e)
        {

        }

        private void daysLabel_Click(object sender, EventArgs e)
        {

        }

        private void hoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void secondsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numberOfMinutesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
