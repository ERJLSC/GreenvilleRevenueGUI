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
    public partial class contestantDataForm : Form
    {
        int x=1;
        string printout;

        public contestantDataForm()
        {
            InitializeComponent();           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t;
            nameLabel.Text = "SFSADAFASDF";
            if (radioButton1.Checked == true)
            {
                Variables.contestant[x, 0]=nameTextBox.Text;
                Variables.contestant[x, 1] = "Singing";
            }
            if (radioButton2.Checked == true)
            {
                Variables.contestant[x, 0] = nameTextBox.Text;
                Variables.contestant[x, 1] = "Dancing";
            }
            if (radioButton3.Checked == true)
            {
                Variables.contestant[x, 0] = nameTextBox.Text;
                Variables.contestant[x, 1] = "Playing Instrument";
            }
            if (radioButton4.Checked == true)
            {
                Variables.contestant[x, 0] = nameTextBox.Text;
                Variables.contestant[x, 1] = "Other";
            }
            printout = "Roster Number     Name      Event\n";
            for (t = 1; t < Variables.contestants; t++)
            {
                
                nameLabel.Text = nameLabel.Text + t + "  " + Variables.contestant[t, 0] + "\n";
                eventLabel.Text = eventLabel.Text + Variables.contestant[t, 1] + "\n";
                nameLabel.Text = printout;
            }
            x++;
        }

       
    }
}
