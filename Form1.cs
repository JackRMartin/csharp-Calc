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
    // currently supports 1 operation with two numbers. (ex: 2+2, 5*7, 10/2, 50-2 etc...)
    // update num1 by converting the contents of textbox to a double after an operator button has been clicked
    // using boolean variables to check if the user has already chosen an operator

    public partial class v : Form
    {
        double num1, num2, output;
        string num1String, num2String, outputString;
        bool usedMultiplication = false;
        bool usedAddition = false;
        bool usedSubtraction = false;
        bool usedDivision = false;
        bool calcCompleted = false;

        public v()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (usedAddition == false && usedDivision == false && usedMultiplication == false && usedSubtraction == false) // check if user has used an operator already
            {
                usedAddition = true; // addition operator has been used now
                num1String = textBox1.Text; // assign contents of text box to num1String
                num1 = Convert.ToDouble(num1String); // convert num1string to a double and assign it to num1
                textBox1.Text = num1String + '+'; // add an addition sign to the textbox              
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (usedAddition == false && usedDivision == false && usedMultiplication == false && usedSubtraction == false) // check if user has used an operator already
            {
                usedSubtraction = true; // subtraction has been used
                num1String = textBox1.Text; // assign contents of text box to num1String
                num1 = Convert.ToDouble(textBox1.Text); // assign num1 to current contents of the textbox
                textBox1.Text = textBox1.Text + '-'; // add subtraction sign to textbox
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (usedAddition == false && usedDivision == false && usedMultiplication == false && usedSubtraction == false) // check if user has used an operator already
            {
                usedDivision = true; // division has been used 
                num1String = textBox1.Text; // assign contents of text box to num1String
                num1 = Convert.ToDouble(textBox1.Text);// assign num1 to current contents of the textbox
                textBox1.Text = textBox1.Text + '/'; // assign division sign to the textbox
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (usedAddition == false && usedDivision == false && usedMultiplication == false && usedSubtraction == false) // check if user has used an operator already
            {
                usedMultiplication = true; // multiplication has been used
                num1String = textBox1.Text; // assign contents of text box to num1String
                num1 = Convert.ToDouble(textBox1.Text); // assign num1 to current contents of the textbox
                textBox1.Text = textBox1.Text + '*'; // add multiplication sign to the textbox
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            // we will convert num1 back to a string and subtract the num1String from the textBox1.Text string 
            // this will allow us to get a string that contains that data we need to store in num1 for the calculation

            if(usedAddition == true && calcCompleted == false)
            {
                num2String = textBox1.Text.Replace(num1String + "+", ""); // assign num2String to a the contents of textbox - num1String
                num2 = Convert.ToDouble(num2String); // assign double num2 to the converted version of the num2string
                output = num1 + num2; // calculation
                outputString = Convert.ToString(output); // convert calculation output to a string
                textBox1.Text = outputString; // output string in the textbox  
                calcCompleted = true;
            }
            if(usedDivision == true && calcCompleted == false)
            {
                num2String = textBox1.Text.Replace(num1String + "/", ""); // assign num2String to a the contents of textbox - num1String
                num2 = Convert.ToDouble(num2String); // assign double num2 to the converted version of the num2string
                output = num1 / num2; // calculation
                outputString = Convert.ToString(output); // convert calculation output to a string
                textBox1.Text = outputString; // output string in the textbox
                calcCompleted = true;
            }
            if(usedMultiplication == true && calcCompleted == false)
            {
                num2String = textBox1.Text.Replace(num1String + "*", ""); // assign num2String to a the contents of textbox - num1String
                num2 = Convert.ToDouble(num2String); // assign double num2 to the converted version of the num2string
                output = num1 * num2; // calculation
                outputString = Convert.ToString(output); // convert calculation output to a string
                textBox1.Text = outputString; // output string in the textbox
                calcCompleted = true;
            }
            if(usedSubtraction == true && calcCompleted == false)
            {
                num2String = textBox1.Text.Replace(num1String + "-", ""); // assign num2String to a the contents of textbox - num1String
                num2 = Convert.ToDouble(num2String); // assign double num2 to the converted version of the num2string
                output = num1 - num2; // calculation
                outputString = Convert.ToString(output); // convert calculation output to a string
                textBox1.Text = outputString; // output string in the textbox
                calcCompleted = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            usedAddition = false;
            usedSubtraction = false;
            usedDivision = false;
            usedMultiplication = false;
            calcCompleted = false; 
            textBox1.Text = "";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (calcCompleted != true)
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
