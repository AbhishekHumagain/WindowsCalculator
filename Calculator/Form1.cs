using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((calculation_result.Text == "0") || (isOperationPerformed))
                calculation_result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            { 
               if(!calculation_result.Text.Contains("."))
                   calculation_result.Text = calculation_result.Text + button.Text;

            }else
            calculation_result.Text = calculation_result.Text + button.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equals.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(calculation_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void ButtonC(object sender, EventArgs e)
        {
            calculation_result.Text = "0";
        }

        private void ButtonCE(object sender, EventArgs e)
        {
            calculation_result.Text = "0";
            resultValue = 0;
        }

        private void Calculation(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    calculation_result.Text = (resultValue + Double.Parse(calculation_result.Text)).ToString();
                    break;
                case "-":
                    calculation_result.Text = (resultValue - Double.Parse(calculation_result.Text)).ToString();
                    break;
                case "*":
                    calculation_result.Text = (resultValue * Double.Parse(calculation_result.Text)).ToString();
                    break;
                case "/":
                    calculation_result.Text = (resultValue / Double.Parse(calculation_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(calculation_result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
//How to Create a Calculator in Visual Studio C#
//