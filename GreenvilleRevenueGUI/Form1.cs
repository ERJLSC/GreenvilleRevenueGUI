// Program written by: Erik Johnson, Jake Frasier
//       Program date: 2/22/17
//Program description:  Greenville Revenue Chapter 5, Case Problem 1
// Encountered issues: 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lastYearContestants, thisYearContestants, expectedRevenue;
            
            
            lastYearContestants = Convert.ToDouble(lastYearTextBox.Text);
            thisYearContestants = Convert.ToDouble(thisYearTextBox.Text);
            if (lastYearContestants > 30) MessageBox.Show("You entered a number that is too high for last year.\nPlease try again.");
            if (lastYearContestants < 0) MessageBox.Show("You entered a number that is too low for last year.\nPlease try again.");
            if (thisYearContestants > 30) MessageBox.Show("You entered a number that is too high for this year.\nPlease try again.");
            if (thisYearContestants < 0) MessageBox.Show("You entered a number that is too low for this year.\nPlease try again.");

            if (thisYearContestants > 0 && lastYearContestants > 0 
                && thisYearContestants < 30 && lastYearContestants < 30)
            {
                expectedRevenue = thisYearContestants * 25; // entrence fee is $25
                expectedRevenueLabel.Text=("This year's projected income is "+ expectedRevenue.ToString("C"));
           
                expectedRevenueLabel.Visible = true;
                greaterLabel.Visible = true;
                
                // check for twice as many contestants
                if ((lastYearContestants * 2) + 1 <= thisYearContestants)
                {
                    greaterLabel.Text = "The competition is more than twice as big this year!";
                }
                // less than double
                else
                {
                    greaterLabel.Text = "The competition is bigger than ever!";
                }
                // less than or equal to last year
                if (lastYearContestants >= thisYearContestants)
                {
                    greaterLabel.Text = "A tighter race this year! Come out and cast your vote!";

                }
            }
        }

        private void lastYearTextBox_TextChanged(object sender, EventArgs e)
        { }
        

    }

}
