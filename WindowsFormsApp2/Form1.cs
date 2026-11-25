using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn0.Click += ChangeTextboxString;
            btn1.Click += ChangeTextboxString;
            btn2.Click += ChangeTextboxString;
            btn3.Click += ChangeTextboxString;
            btn4.Click += ChangeTextboxString;
            btn5.Click += ChangeTextboxString;
            btn6.Click += ChangeTextboxString;
            btn7.Click += ChangeTextboxString;
            btn8.Click += ChangeTextboxString;
            btn9.Click += ChangeTextboxString;
            btnadd.Click += ChangeTextboxString;
            btnsub.Click += ChangeTextboxString;
            btnMod.Click += ChangeTextboxString;
            btndivide.Click += ChangeTextboxString;
            btnmul.Click += ChangeTextboxString;
            btndot.Click += ChangeTextboxString;
        }
        private string prevalue = "";
        private string nextvalue = "";
        private void ChangeTextboxString(object sender, EventArgs e) {
            textBox1.Text += ((Button)sender).Tag.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        textBox1.Text = string.Empty;    
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float prenumber = 0;
            float nextnumber = 0;
            char swoperation = ' ';
            float result = 0;
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                char charoperation = (char)textBox1.Text[i];
                if (charoperation == '+' || charoperation == '-' || charoperation == '/' || charoperation == '%' || charoperation == '*')
                {
                    swoperation = charoperation;
                    prevalue = (textBox1.Text.Substring(0, i));
                    prenumber = float.Parse(prevalue);
                    nextvalue = textBox1.Text.Substring((i + 1));
                    nextnumber = float.Parse(nextvalue);
                    break;
                }
            }
            switch (swoperation)
            {
                case '+':
                    result = prenumber + nextnumber;
                    break;

                case '-':
                    result = prenumber - nextnumber;
                    break;

                case '*':
                    result = prenumber * nextnumber;
                    break;

                case '/':
                    result = prenumber / nextnumber;
                    break;
                case '%':
                    result = prenumber % nextnumber;
                    break;
            }
            textBox1.Text = result.ToString();
        }
    }
}
