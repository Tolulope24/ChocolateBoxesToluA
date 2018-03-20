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
            const int MY_NUMBER = 20;
            const int 
            int BoxNumber;
            BoxNumber = int.Parse(txtBoxNumber.Text);
             
            if (BoxNumber <= MY_NUMBER)
            {
                lblPrizes.Text = "The Reward Is A Small Prize";
            }
            else
                if (BoxNumber < MY_NUMBER)
            {
                lblPrizes.Text = "The Reward Is A ";
            }
        }
    }
}
