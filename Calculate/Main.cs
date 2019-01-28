using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Main : Form
    {
        double num1;
        double num2;
        double final;
        string op;
        public Main()
        {
            InitializeComponent();
            btnZero.Click += ShowNumber;
            btnOne.Click += ShowNumber;
            btnTwo.Click += ShowNumber;
            btnThree.Click += ShowNumber;
            btnFour.Click += ShowNumber;
            btnFive.Click += ShowNumber;
            btnSix.Click += ShowNumber;
            btnSeven.Click += ShowNumber;
            btnEight.Click += ShowNumber;
            btnNine.Click += ShowNumber;
            btnFractional.Click += ShowNumber;

            btnAddition.Click += Operation;
            btnMultiplication.Click += Operation;
            btnDivision.Click += Operation;
            btnEmission.Click += Operation;

            btnClear.Click += Clear;
            btnEquality.Click += Equality;
            btnPercent.Click += Percent;
            btnNegative.Click += Negative;
        }

        private void Negative(object sender, EventArgs e)
        {
            tbxCalcResult.Text = (0 - Convert.ToDouble(tbxCalcResult.Text)).ToString();
        }

        private void Percent(object sender, EventArgs e)
        {
            tbxCalcResult.Text = (Convert.ToDouble(tbxCalcResult.Text) / 100).ToString();
        }

        private void Equality(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    num2 = Convert.ToDouble(tbxCalcResult.Text);
                    final = num1 + num2;
                    tbxCalcResult.Text = final.ToString();
                    break;

                case "-":
                    num2 = Convert.ToDouble(tbxCalcResult.Text);
                    final = num1 - num2;
                    tbxCalcResult.Text = final.ToString();
                    break;

                case "*":
                    num2 = Convert.ToDouble(tbxCalcResult.Text);
                    final = num1 * num2;
                    tbxCalcResult.Text = final.ToString();
                    break;

                case "/":
                    num2 = Convert.ToDouble(tbxCalcResult.Text);
                    if (num2 != 0)
                    {
                        final = num1 / num2;
                        tbxCalcResult.Text = final.ToString();
                    }
                    else
                    {
                        tbxCalcResult.Text = "Error";
                    }
                    break;
            }
            
        }

        private void Clear(object sender, EventArgs e)
        {

            tbxCalcResult.Text = "0";
        }

        private void Operation(object sender, EventArgs e)
        {
            var btnOperation = sender as Button;
            switch (btnOperation.Text)
            {
                case "+":
                    num1 = Convert.ToDouble(tbxCalcResult.Text);
                    tbxCalcResult.Clear();
                    op = "+";
                    break;

                case "-":
                    num1 = Convert.ToDouble(tbxCalcResult.Text);
                    tbxCalcResult.Clear();
                    op = "-";
                    break;

                case "X":
                    num1 = Convert.ToDouble(tbxCalcResult.Text);
                    tbxCalcResult.Clear();
                    op = "*";
                    break;

                case "/":
                    num1 = Convert.ToDouble(tbxCalcResult.Text);
                    tbxCalcResult.Clear();
                    op = "/";
                    break;
                default:
                    break;
            }
        }

        private void ShowNumber(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (tbxCalcResult.Text == "0")
            {
                tbxCalcResult.Clear();
            }
            tbxCalcResult.Text += btn.Text;
        }
    }
}
