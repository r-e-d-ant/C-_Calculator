using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clickedNumber(string num)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = num;
            }
            else
            {
                resultBox.Text = resultBox.Text + num;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            operationPreview.Text = "";
        }

        private void btnDelOne_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else
            {
                resultBox.Text = resultBox.Text.Substring(0, resultBox.Text.Length - 1);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            clickedNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e) 
        {
            clickedNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            clickedNumber("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            clickedNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            clickedNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            clickedNumber("6");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            clickedNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            clickedNumber("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            clickedNumber("3");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            clickedNumber("0");
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            clickedNumber(".");
        }

        double firstNumber, secondNumber;  string ops;

        private void btnModulas_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else if (operationPreview.Text.Length > 0)
            {
                double sum = firstNumber % Double.Parse(resultBox.Text);
                firstNumber = sum;
                operationPreview.Text = firstNumber + "%";
                resultBox.Text = "0";
            }
            else
            {
                firstNumber = Double.Parse(resultBox.Text);
                resultBox.Text = "0";
                ops = "%";
                operationPreview.Text = firstNumber + ops;
            }
        }

        private void btnOneOver_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "1";
            }
            else
            {
                double num = Double.Parse(resultBox.Text);
                double overOne = 1 / Double.Parse(resultBox.Text);
                resultBox.Text = overOne.ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else
            {
                double num = Double.Parse(resultBox.Text);
                double sqrt = Math.Sqrt(num);
                resultBox.Text = sqrt.ToString();
            }
        }

        private void btnPowerTwo_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else
            {
                double num = Double.Parse(resultBox.Text);
                double power = Math.Pow(num, 2);
                resultBox.Text = power.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "0";
                resultBox.Focus();
            } else if (operationPreview.Text.Length > 0)
            {
                double sum = firstNumber + Double.Parse(resultBox.Text);
                firstNumber = sum;
                operationPreview.Text = firstNumber + "+";
                resultBox.Text = "0";
            } else
            {
                firstNumber = Double.Parse(resultBox.Text);
                resultBox.Text = "0";
                ops = "+";
                operationPreview.Text = firstNumber + ops;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else if (operationPreview.Text.Length > 0)
            {
                double subs = firstNumber - Double.Parse(resultBox.Text);
                firstNumber = subs;
                operationPreview.Text = firstNumber + "-";
                resultBox.Text = "0";
            }
            else
            {
                firstNumber = Double.Parse(resultBox.Text);
                resultBox.Text = "0";
                ops = "-";
                operationPreview.Text = firstNumber + ops;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else if (operationPreview.Text.Length > 0)
            {
                double prod = firstNumber * Double.Parse(resultBox.Text);
                firstNumber = prod;
                operationPreview.Text = firstNumber + "*";
                resultBox.Text = "0";
            }
            else
            {
                firstNumber = Double.Parse(resultBox.Text);
                resultBox.Text = "0";
                ops = "*";
                operationPreview.Text = firstNumber + ops;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = "0";
                resultBox.Focus();
            }
            else if (operationPreview.Text.Length > 0)
            {
                double divis = firstNumber / Double.Parse(resultBox.Text);
                firstNumber = divis;
                operationPreview.Text = firstNumber + "/";
                resultBox.Text = "0";
            }
            else
            {
                firstNumber = Double.Parse(resultBox.Text);
                resultBox.Text = "0";
                ops = "/";
                operationPreview.Text = firstNumber + ops;
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" && resultBox.Text != null)
            {
                resultBox.Text = "0";
                resultBox.Focus();
            } else if (resultBox.Text.Substring(0, 1) == "-")
            {
                resultBox.Text = "haha";
            }
            else
            {
                resultBox.Text = "-" + resultBox.Text;
            }
        }

        public void modulas()
        {
            secondNumber = Double.Parse(resultBox.Text);
            double modula = firstNumber % secondNumber;
            resultBox.Text = modula.ToString();
            operationPreview.Text = operationPreview.Text + secondNumber.ToString();
        }

        public void addition()
        {
            secondNumber = Double.Parse(resultBox.Text);
            double sum = firstNumber + secondNumber;
            resultBox.Text = sum.ToString();
            operationPreview.Text = operationPreview.Text + secondNumber.ToString();
        }
        public void subtraction()
        {
            secondNumber = Double.Parse(resultBox.Text);
            double substr = firstNumber - secondNumber;
            resultBox.Text = substr.ToString();
            operationPreview.Text = operationPreview.Text + secondNumber.ToString();
        }
        public void product()
        {
            secondNumber = Double.Parse(resultBox.Text);
            double prod = firstNumber * secondNumber;
            resultBox.Text = prod.ToString();
            operationPreview.Text = operationPreview.Text + secondNumber.ToString();
        }
        public void division()
        {
            secondNumber = Double.Parse(resultBox.Text);
            double div = firstNumber / secondNumber;
            resultBox.Text = div.ToString();
            operationPreview.Text = operationPreview.Text + secondNumber.ToString();
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (ops)
            {
                case "%":
                    modulas();
                    break;
                case "+":
                    addition();
                    break;
                case "-":
                    subtraction();
                    break;
                case "*":
                    product();
                    break;
                case "/":
                    division();
                    break;
                default:
                    resultBox.Text = secondNumber.ToString();
                    break;
            }
        }
    }
}
