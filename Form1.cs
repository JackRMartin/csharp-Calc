using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class v : Form
    {
        double num1, num2, output;
        string num1String = "";
        string num2String = "";
        bool oppAdd = false;
        bool oppMult = false;
        bool oppDiv = false;
        bool oppSub = false;

        public v()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (oppAdd == false && oppSub == false && oppDiv == false && oppMult == false)
            {
                num1String = textBox1.Text;
                num1 = Convert.ToDouble(num1String);
                num2String = textBox1.Text.Remove(0, num1String.Length);
                num2 = Convert.ToDouble(num2String);
                textBox1.Text = "";
                output = num1 + num2;
                textBox1.Text = Convert.ToString(output);
                oppAdd = true;
            }

        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (oppAdd == false && oppSub == false && oppDiv == false && oppMult == false)
            {
                oppSub = true;
                num1String = textBox1.Text;
                num1 = Convert.ToDouble(num1String);
                num2String = textBox1.Text.Remove(0, num1String.Length);
                num2 = Convert.ToDouble(num2String);
                textBox1.Text = "";
                output = num1 + num2;
                textBox1.Text = Convert.ToString(output);
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (oppAdd == false && oppSub == false && oppDiv == false && oppMult == false)
                {
                    oppDiv = true;
                    num1String = textBox1.Text;
                    num1 = Convert.ToDouble(num1String);
                    num2String = textBox1.Text.Remove(0, num1String.Length);
                    num2 = Convert.ToDouble(num2String);
                    textBox1.Text = "";
                    output = num1 + num2;
                    textBox1.Text = Convert.ToString(output);
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + "/";
                }
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (oppAdd == false && oppSub == false && oppDiv == false && oppMult == false)
                {
                    oppMult = true;
                    num1String = textBox1.Text;
                    num1 = Convert.ToDouble(num1String);
                    num2String = textBox1.Text.Remove(0, num1String.Length);
                    num2 = Convert.ToDouble(num2String);
                    textBox1.Text = "";
                    output = num1 + num2;
                    textBox1.Text = Convert.ToString(output);
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = textBox1.Text + "*";
                }
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";            
        }

        private void equals_Click(object sender, EventArgs e)
        {
            textBox1.Text = "="; // logic for computing calculations
            

            // After output has been displayed
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
