using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class calculatorForm : Form
    {

        string topDisplay;
        string bottomDisplay;
        Calculate calc = new Calculate();
        
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "0";
            lowerLbl.Text = bottomDisplay;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "1";
            lowerLbl.Text = bottomDisplay;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "2";
            lowerLbl.Text = bottomDisplay;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "3";
            lowerLbl.Text = bottomDisplay;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "4";
            lowerLbl.Text = bottomDisplay;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "5";
            lowerLbl.Text = bottomDisplay;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "6";
            lowerLbl.Text = bottomDisplay;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "7";
            lowerLbl.Text = bottomDisplay;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "8";
            lowerLbl.Text = bottomDisplay;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            bottomDisplay += "9";
            lowerLbl.Text = bottomDisplay;
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            topDisplay = "+"+bottomDisplay;
            upperLbl.Text = topDisplay;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            calc.Input1 = Int32.Parse(topDisplay);
            calc.Input2 = Int32.Parse(bottomDisplay);
            int answer = calc.Addition();
            MessageBox.Show("Answer " + answer, "parsed");
        }
    }
}
