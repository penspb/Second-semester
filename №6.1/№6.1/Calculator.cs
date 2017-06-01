using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// result value
        /// </summary>
        private double result = 0;

        /// <summary>
        /// number for calculating
        /// </summary>
        private double value0 = 0;
        private double value1 = 0;

        /// <summary>
        /// operator
        /// </summary>
        private char buttonOperator = '-';

        private bool wasThereOperator = false;

        private void PrintResult()
        {
            CalculatorTextBox.Clear();
            CalculatorTextBox.Text = result.ToString();
        }

        private void Calculate()
        {
            value1 = double.Parse(CalculatorTextBox.Text.Substring(CalculatorTextBox.Text.IndexOf(buttonOperator) + 1, CalculatorTextBox.Text.Length - CalculatorTextBox.Text.IndexOf(buttonOperator) - 1));
            switch (buttonOperator)
            {
                case '+':
                    {
                        result = value0 + value1;
                        PrintResult();
                        break;
                    }

                case '-':
                    {
                        result = value0 - value1;
                        PrintResult();
                        break;
                    }

                case '*':
                    {
                        result = value0 * value1;
                        PrintResult();
                        break;
                    }

                case '/':
                    {
                        result = value0 / value1;
                        PrintResult();
                        break;
                    }
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            CalculatorTextBox.Text += button.Text;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text = CalculatorTextBox.Text.Substring(0, CalculatorTextBox.Text.Length - 1);
        }

        private void sign_Click(object sender, EventArgs e)
        {
            bool isItNumber = int.TryParse(CalculatorTextBox.Text, out int num);

            if (isItNumber)
            {
                if (double.Parse(CalculatorTextBox.Text) < 0)
                {
                    CalculatorTextBox.Text = CalculatorTextBox.Text.Substring(1, CalculatorTextBox.Text.Length - 1);
                }
                else if (double.Parse(CalculatorTextBox.Text) > 0)
                {
                    CalculatorTextBox.Text = "-" + CalculatorTextBox.Text;
                }
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (wasThereOperator)
            {
                Calculate();

                CalculatorTextBox.Text = CalculatorTextBox.Text + button.Text;
                buttonOperator = button.Text[0];
            }

            value0 = double.Parse(CalculatorTextBox.Text);
            wasThereOperator = true;
            CalculatorTextBox.Text = CalculatorTextBox.Text + button.Text;
            buttonOperator = button.Text[0];            
        }

        private void result_Click(object sender, EventArgs e)
        {
            Calculate();
            wasThereOperator = false;
        }

        private void point_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += ",";
        }
    }
}
