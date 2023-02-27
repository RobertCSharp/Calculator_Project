using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        private float number;
        string result;
        private char sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += 9;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string text = display.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = true;
                    break;
                } 
                flag = false;
                
            }

            if (flag == false) display.Text += ".";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            number = float.Parse(display.Text);
            display.Clear();
            display.Focus();
            sign = '-';
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            number = float.Parse(display.Text);
            display.Clear();
            display.Focus();
            sign = '*';
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            number = float.Parse(display.Text);
            display.Clear();
            display.Focus();
            sign = '/';
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            number = float.Parse(display.Text);
            display.Clear();
            display.Focus();
            sign = '+';
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (sign == '+')
                result = (number + float.Parse(display.Text)).ToString();

            else if (sign == '-')
                result = (number - float.Parse(display.Text)).ToString();

            else if (sign == '*')
                result = (number * float.Parse(display.Text)).ToString();

            else if (sign == '/')
                result = (number / float.Parse(display.Text)).ToString();

            display.Text = result;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            display.Clear();
            //result = "0";
        }

        private void afisaj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
