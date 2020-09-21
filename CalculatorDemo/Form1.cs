using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        Refactor ref_calculator;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string left;
            string right;
            string operand;
            string result;

            left = txtLeft1.Text.Trim();
            right = txtRight1.Text.Trim();
            operand = txtOperand1.Text.Trim();

            // set values
            if (calculator is null)
                calculator = new Calculator(left, right, operand);
            else
            {
                calculator.setLeft(left);
                calculator.setRight(right);
                calculator.setOperand(operand);
            }

            // calculate
            calculator.Calculate();

            // display value
            result = calculator.getResult();
            lblResult1.Text = result;
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            string equation;
            string result;

            // set values
            if (ref_calculator is null)
                ref_calculator = new Refactor();

            equation = txtEquation.Text.Trim();

            // calculate
            ref_calculator.Calculate(equation);

            // display result
            result = ref_calculator.getResult();
            lblResult2.Text = result;

        }

        private void btnLookup1_Click(object sender, EventArgs e)
        {
            int index;

            // check valid input
            if (!Int32.TryParse(txtLookup1.Text, out index))
            {
                lblLookupResult1.Text = "Error: Enter a valid integer";
                return;
            }
                
            // find result
            lblLookupResult1.Text = calculator.getPreviousResult(index);

        }

        private void btnLookup2_Click(object sender, EventArgs e)
        {
            int index;

            // check valid input
            if (!Int32.TryParse(txtLookup2.Text, out index))
            {
                lblLookupResult2.Text = "Error: Enter a valid integer";
                return;
            }

            // find result
            lblLookupResult2.Text = ref_calculator.getPreviousResult(index);

        }
    }
}
