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
    //class Variables      This cannot be here!  Create a class outside of this form or the form will not be seen in edit mode.
   // {
   //     public static string  [,] contestant= new string[30,2];
   //     public static int contestants;
  //  }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Variables.contestant[0, 0] = "Name";
            Variables.contestant[0, 1] = "Category";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lastYearContestants, thisYearContestants; 
                double expectedRevenue;
            
            
            lastYearContestants = Convert.ToInt32(lastYearTextBox.Text);
            thisYearContestants = Convert.ToInt32(thisYearTextBox.Text);
            if (lastYearContestants > 30) MessageBox.Show("You entered a number that is too high for last year.\nPlease try again.");
            if (lastYearContestants < 0) MessageBox.Show("You entered a number that is too low for last year.\nPlease try again.");
            if (thisYearContestants > 30) MessageBox.Show("You entered a number that is too high for this year.\nPlease try again.");
            if (thisYearContestants < 0) MessageBox.Show("You entered a number that is too low for this year.\nPlease try again.");

            if (thisYearContestants >= 0 && lastYearContestants >= 0 
                && thisYearContestants <= 30 && lastYearContestants <= 30)
            {
                expectedRevenue = thisYearContestants * 25; // entrence fee is $25
                expectedRevenueLabel.Text=("This year's projected income is "+ expectedRevenue.ToString("C"));
           
                expectedRevenueLabel.Visible = true;
                greaterLabel.Visible = true;
                contestantDataButton.Enabled = true;// allow contestant data to be entered
                Variables.contestants =thisYearContestants;
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

        private void contestantDataButton_Click(object sender, EventArgs e)
        {
            
            contestantDataForm contestantDataForm = new contestantDataForm();
            contestantDataForm.ShowDialog(); // ShowDialog makes the form modal.
            
        }
    }

}
