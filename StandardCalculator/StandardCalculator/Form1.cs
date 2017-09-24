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

        string topValue;
        string bottomValue;
        string symbol;
        Calculate calc = new Calculate();
        
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {

        }

        //displays 0 when pressed to the lower display
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "0";
            lowerLbl.Text = bottomValue;
        }
        //displays 1 when pressed to the lower display
        private void oneBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "1";
            lowerLbl.Text = bottomValue;
        }
        //displays 2 when pressed to the lower display
        private void twoBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "2";
            lowerLbl.Text = bottomValue;
        }
        //displays 3 when pressed to the lower display
        private void threeBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "3";
            lowerLbl.Text = bottomValue;
        }
        //displays 4 when pressed to the lower display
        private void fourBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "4";
            lowerLbl.Text = bottomValue;
        }
        //displays 5 when pressed to the lower display
        private void fiveBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "5";
            lowerLbl.Text = bottomValue;
        }
        //displays 6 when pressed to the lower display
        private void sixBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "6";
            lowerLbl.Text = bottomValue;
        }
        //displays 7 when pressed to the lower display
        private void sevenBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "7";
            lowerLbl.Text = bottomValue;
        }
        //displays 8 when pressed to the lower display
        private void eightBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "8";
            lowerLbl.Text = bottomValue;
        }
        //displays 9 when pressed to the lower display
        private void nineBtn_Click(object sender, EventArgs e)
        {
            bottomValue += "9";
            lowerLbl.Text = bottomValue;
        }
        //addition button that sets a value in the calculate class to a parsed bottom value
        private void additionBtn_Click(object sender, EventArgs e)
        {
            calc.Symbol = additionBtn.Text;
            calc.Input1 = Int32.Parse(bottomValue);
            topValue += bottomValue + " +";
            upperLbl.Text = topValue;
            bottomValue = clear();
        }
        //sends values to inputs in Calculator class and runds the calculate method and returns the value
        private void equalBtn_Click(object sender, EventArgs e)
        {
            calc.Input2 = Int32.Parse(bottomValue);
            int answer = calc.math();
            upperLbl.Text = "";
            lowerLbl.Text = answer.ToString();
        }
        //method to clear text
        private string clear()
        {
            string text;
            text = "";
            return text;
        }
        //clears all text and sets the bottomValue
        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            bottomValue = "0";
            lowerLbl.Text = bottomValue;
            topValue = clear();
            upperLbl.Text = topValue;

        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            calc.Symbol = subtractionBtn.Text;
            calc.Input1 = Int32.Parse(bottomValue);
            topValue += bottomValue + " -";
            upperLbl.Text = topValue;
            bottomValue = clear();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            calc.Symbol = multiplyBtn.Text;
            calc.Input1 = Int32.Parse(bottomValue);
            topValue += bottomValue + " x";
            upperLbl.Text = topValue;
            bottomValue = clear();
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            calc.Symbol = divisionBtn.Text;
            calc.Input1 = Int32.Parse(bottomValue);
            topValue += bottomValue + " ÷";
            upperLbl.Text = topValue;
            bottomValue = clear();
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            bottomValue += ".";
            lowerLbl.Text = bottomValue;
        }
    }
}
