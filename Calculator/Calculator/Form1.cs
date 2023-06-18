using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kisuna
{

   
    public partial class Calculator : Form
    {
        public double number, answer;
        double count;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 1;
            TextBox2.Text = TextBox2.Text + 1;
        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 2;
            TextBox2.Text = TextBox2.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 3;
            TextBox2.Text = TextBox2.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 4;
            TextBox2.Text = TextBox2.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 5;
            TextBox2.Text = TextBox2.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 6;
            TextBox2.Text = TextBox2.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 7;
            TextBox2.Text = TextBox2.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 8;
            TextBox2.Text = TextBox2.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 9;
            TextBox2.Text = TextBox2.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + 0;
            TextBox2.Text = TextBox2.Text + 0;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + '-';

            if(TextBox2.Text != "")
            {
                number = double.Parse(TextBox2.Text);
                TextBox2.Clear();
                TextBox2.Focus();
                count = 1;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //TextBox2.Text = TextBox2.Text + '+';
            DisplayTextBox.Text = DisplayTextBox.Text + '+';
            //number = double.Parse(DisplayTextBox.Text);
            //DisplayTextBox.Clear();
            //DisplayTextBox.Focus();
            //count = 2;

            number = double.Parse(TextBox2.Text);
            TextBox2.Clear();
            TextBox2.Focus();
            count = 2;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + '*';

            //number = double.Parse(DisplayTextBox.Text);
            //DisplayTextBox.Clear();
            //DisplayTextBox.Focus();
            //count = 3;
            number = double.Parse(TextBox2.Text);
            TextBox2.Clear();
            TextBox2.Focus();
            count = 3;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = DisplayTextBox.Text + '/';

            //number = double.Parse(DisplayTextBox.Text);
            //DisplayTextBox.Clear();
            //DisplayTextBox.Focus();
            //count = 4;
            number = double.Parse(TextBox2.Text);
            TextBox2.Clear();
            TextBox2.Focus();
            count = 4;
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Clear();
            TextBox2.Clear();
            count = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            int length = DisplayTextBox.TextLength;
            int flag = 0;
            string text = DisplayTextBox.Text;
            for (int i = 0; i < length; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1;
                    break;
                }
                else
                    flag = 0;

                if(flag == 0)
                {
                    DisplayTextBox.Text = DisplayTextBox.Text + '.';
                    TextBox2.Text = TextBox2.Text + '.';
                    //TextBox2.Clear();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text != string.Empty && TextBox2.Text != string.Empty)
            {
                int textLength = DisplayTextBox.Text.Length;
                int textLength2 = TextBox2.Text.Length;
                if(textLength != 1 && textLength2 != 1)
                {
                    DisplayTextBox.Text = DisplayTextBox.Text.Remove(textLength - 1);
                    TextBox2.Text = TextBox2.Text.Remove(textLength - 1);
                }
                else
                {
                    DisplayTextBox.Text = 0.ToString();
                    TextBox2.Text = 0.ToString();
                }
            }

        }

        public void compute(double count)
        {
            switch(count)
            {
                case 1:
                    answer = number - double.Parse(TextBox2.Text);
                    DisplayTextBox.Text = answer.ToString();
                    break;
                case 2:
                    //answer = number + double.Parse(DisplayTextBox.Text);
                    answer = number + double.Parse(TextBox2.Text);
                    DisplayTextBox.Text = answer.ToString();
                    break;
                case 3:
                    //answer = number * double.Parse(DisplayTextBox.Text);
                    answer = number * double.Parse(TextBox2.Text);
                    DisplayTextBox.Text = answer.ToString();
                    break;
                case 4:
                    //answer = number / double.Parse(DisplayTextBox.Text);
                    answer = number / double.Parse(TextBox2.Text);
                    DisplayTextBox.Text = answer.ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
