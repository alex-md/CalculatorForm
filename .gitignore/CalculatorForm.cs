//Alexander Johnson
//ISM220 Section 02
//CalculatorForm.cs
//A GUI four function calculator that demonstrates the use of buttons
//messageboxes, and labels

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA08JohnsonA
{
    public partial class CalculatorForm : Form
    {
        //Declaring class level variables
        double operand1, operand2, result;

        private void addButton_Click(object sender, EventArgs e)
        {
            //Takes two operands entered by the user and adds the numbers
            operand1 = Convert.ToDouble(operand1TextBox.Text);
            operand2 = Convert.ToDouble(operand2TextBox.Text);
            result = operand1 + operand2;
            resultTextBox.Text = string.Format("{0:N3}", result);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            //Takes two operands entered by user and subtracts the difference
            operand1 = Convert.ToDouble(operand1TextBox.Text);
            operand2 = Convert.ToDouble(operand2TextBox.Text);
            result = operand1 - operand2;
            resultTextBox.Text = string.Format("{0:N3}", result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            //Takes two operands entered by user and multiplies the product
            operand1 = Convert.ToDouble(operand1TextBox.Text);
            operand2 = Convert.ToDouble(operand2TextBox.Text);
            result = operand1 * operand2;
            resultTextBox.Text = string.Format("{0:N3}", result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            //Takes two operands by the user and divides the quotient
            //as long as the number is not '0'
            operand1 = Convert.ToDouble(operand1TextBox.Text);
            operand2 = Convert.ToDouble(operand2TextBox.Text);
            if (operand2 != 0) 
            {
                result = operand1 / operand2;
                resultTextBox.Text = string.Format("{0:N3}", result);
            }
            //If the denominator is zero display an error messagebox and reset focus
            //to operand2
            else
            {
                MessageBox.Show("Cannot divide by zero. Re-enter the denominator.", "Error in denominator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                operand2TextBox.Focus();
                operand2TextBox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the form and resets the focus of the cursor to operand1
            operand1TextBox.Clear();
            operand2TextBox.Clear();
            resultTextBox.Clear();
            operand1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
