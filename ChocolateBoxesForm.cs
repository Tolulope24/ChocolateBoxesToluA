using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...
*/

namespace ChocolateBarToluA
{
    public partial class frmChocolateBar : Form
    {
        public frmChocolateBar()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Identify The Variables and Constants
            int BoxNumber;
            // Get The Integer From The Text Box
            BoxNumber = int.Parse(txtBoxNumber.Text);
             // Classify The Prizes
            if (BoxNumber > 20)
            {
                lblPrizes.Text = "The Reward Is A Prize !!";
            }
            else
                if (BoxNumber < 10)
            {
                lblPrizes.Text = "The Reward Is An Honorable Mention ";
            }
            else
            {
                lblPrizes.Text = "The Reward is a small Prize !! ";
            }
        }
    }
}
