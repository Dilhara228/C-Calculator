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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        string sign = "";
        string firstTime = "Yes";
        double firstNo = 0.0;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "1";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "1";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "1";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "1";
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
                if (txt.Text == "0")
                {
                    txt.Text = "2";
                }
                else
                {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "2";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "2";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "2";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "3";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "3";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "3";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "3";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "4";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "4";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "4";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "4";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "5";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "5";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "5";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "5";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "6";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "6";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "6";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "6";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "7";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "7";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "7";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "7";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "8";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "8";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "8";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "8";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "9";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "9";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "9";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "9";
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt.Text == "0")
            {
                txt.Text = "0";
            }
            else
            {
                if (sign != "")
                {

                    if (firstTime == "Yes")
                    {
                        txt.Text = "0";
                        firstTime = "No";
                    }
                    else
                    {
                        txt.Text = txt.Text + "0";
                    }
                }
                else
                {
                    txt.Text = txt.Text + "0";
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            sign = "+";
            firstTime = "Yes";
            firstNo = Convert.ToDouble(txt.Text);

            if (firstTime == "No")
            {
                if (sign == "+")
                {
                    txt.Text = Convert.ToString(firstNo + Convert.ToDouble(txt.Text));
                }
                else if (sign == "-")
                {
                    txt.Text = Convert.ToString(firstNo - Convert.ToDouble(txt.Text));
                }
                else if (sign == "/")
                {
                    txt.Text = Convert.ToString(firstNo / Convert.ToDouble(txt.Text));
                }
                else if (sign == "*")
                {
                    txt.Text = Convert.ToString(firstNo * Convert.ToDouble(txt.Text));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign = "-";
            firstTime = "Yes";
            firstNo = Convert.ToDouble(txt.Text);

            if (firstTime == "No")
            {
                if (sign == "+")
                {
                    txt.Text = Convert.ToString(firstNo + Convert.ToDouble(txt.Text));
                }
                else if (sign == "-")
                {
                    txt.Text = Convert.ToString(firstNo - Convert.ToDouble(txt.Text));
                }
                else if (sign == "/")
                {
                    txt.Text = Convert.ToString(firstNo / Convert.ToDouble(txt.Text));
                }
                else if (sign == "*")
                {
                    txt.Text = Convert.ToString(firstNo * Convert.ToDouble(txt.Text));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign = "*";
            firstTime = "Yes";
            firstNo = Convert.ToDouble(txt.Text);

            if (firstTime == "No")
            {
                if (sign == "+")
                {
                    txt.Text = Convert.ToString(firstNo + Convert.ToDouble(txt.Text));
                }
                else if (sign == "-")
                {
                    txt.Text = Convert.ToString(firstNo - Convert.ToDouble(txt.Text));
                }
                else if (sign == "/")
                {
                    txt.Text = Convert.ToString(firstNo / Convert.ToDouble(txt.Text));
                }
                else if (sign == "*")
                {
                    txt.Text = Convert.ToString(firstNo * Convert.ToDouble(txt.Text));
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign = "/";
            firstTime = "Yes";
            firstNo = Convert.ToDouble(txt.Text);

            if (firstTime == "No")
            {
                if (sign == "+")
                {
                    txt.Text = Convert.ToString(firstNo + Convert.ToDouble(txt.Text));
                }
                else if (sign == "-")
                {
                    txt.Text = Convert.ToString(firstNo - Convert.ToDouble(txt.Text));
                }
                else if (sign == "/")
                {
                    txt.Text = Convert.ToString(firstNo / Convert.ToDouble(txt.Text));
                }
                else if (sign == "*")
                {
                    txt.Text = Convert.ToString(firstNo * Convert.ToDouble(txt.Text));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sign == "+")
            {
                txt.Text = Convert.ToString(firstNo + Convert.ToDouble(txt.Text));
            }
            else if(sign == "-")
            {
                txt.Text = Convert.ToString(firstNo - Convert.ToDouble(txt.Text));
            }
            else if (sign == "/")
            {
                txt.Text = Convert.ToString(firstNo / Convert.ToDouble(txt.Text));
            }
            else if (sign == "*")
            {
                txt.Text = Convert.ToString(firstNo * Convert.ToDouble(txt.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!txt.Text.Contains("."))
            {
                txt.Text = txt.Text + ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt.Text = "0";
            sign = "";
            firstTime = "";
            firstNo = 0.0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                if(txt.Text.Length==0)
                {
                    txt.Text = "0";
                }
            }
        }
    }
}
