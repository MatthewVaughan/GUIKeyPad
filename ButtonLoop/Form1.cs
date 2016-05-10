using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// Project: Keypad
// Date: 03/24/2016 11:23:19 am
//
// I declare that the following code was written by me. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace ButtonLoop
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
       
        }
        //Declare some constants
        const int
            ZERO = 0,
            ONE = 1,
            TWO = 2,
            THREE = 3,
            FOUR = 4,
            FIVE = 5,
            SIX = 6,
            SEVEN = 7,
            EIGHT = 8,
            NINE = 9;
            
        /// <summary>
        /// Btn 1 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            //Add the number 1 to the number
            txtNum.Text = ($"{txtNum.Text}{ONE}");

        }

        /// <summary>
        /// Btn 2 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            //Add the number 2 to the number
            txtNum.Text = ($"{txtNum.Text}{TWO}");
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box showing my credentials
            MessageBox.Show("Program Master: Matthew Vaughan\n\nHis take on the Keypad.");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }

        /// <summary>
        /// Btn 3 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            //Add the number 3 to the number
            txtNum.Text = ($"{txtNum.Text}{THREE}");
        }

        /// <summary>
        /// Btn 4 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            //Add the number 4 to the number
            txtNum.Text = ($"{txtNum.Text}{FOUR}");
        }

        /// <summary>
        /// Btn 5 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            //Add the number 5 to the number
            txtNum.Text = ($"{txtNum.Text}{FIVE}");
        }

        /// <summary>
        /// Btn 6 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn6_Click(object sender, EventArgs e)
        {
            //Add the number 6 to the number
            txtNum.Text = ($"{txtNum.Text}{SIX}");
        }

        /// <summary>
        /// Btn 7 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn7_Click(object sender, EventArgs e)
        {
            //Add the number 7 to the number
            txtNum.Text = ($"{txtNum.Text}{SEVEN}");
        }

        /// <summary>
        /// Btn 8 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn8_Click(object sender, EventArgs e)
        {
            //Add the number 8 to the number
            txtNum.Text = ($"{txtNum.Text}{EIGHT}");
        }

        /// <summary>
        /// Btn 9 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn9_Click(object sender, EventArgs e)
        {
            //Add the number 9 to the number
            txtNum.Text = ($"{txtNum.Text}{NINE}");
        }

        /// <summary>
        /// Btn 0 handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Add the number 0 to the number
            txtNum.Text = ($"{txtNum.Text}{ZERO}");
        }

        /// <summary>
        /// Btn Clear handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the text box
            txtNum.Text = "";
        }
    }
}
