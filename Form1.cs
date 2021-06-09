using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaterNet
{
    public partial class Form1 : Form
    {
        private double savedValue;
        private double memory;
        private char op = '\0';
        bool opFlag = false;
        bool memFlag = false;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Click_Insert_number(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox_result.Text == "0" || opFlag == true || memFlag == true)
            {
                textBox_result.Text = btn.Text;
                opFlag = false;
                memFlag = false;
            }
            else
                textBox_result.Text = textBox_result.Text + btn.Text;
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("."))
                return;
            else
                textBox_result.Text = textBox_result.Text + ".";
        }

        private void button_ChangeSign_Click(object sender, EventArgs e)
        {
            double v = Double.Parse(textBox_result.Text);
            textBox_result.Text = (-v).ToString();
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            savedValue = Double.Parse(textBox_result.Text);
            txtExp.Text = textBox_result.Text + " + ";
            op = '+';
            opFlag = true;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 1);
            if (textBox_result.Text.Length == 0)
                textBox_result.Text = "0";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button_ClearAll_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            txtExp.Text = "";
            savedValue = 0;
            op = '\0';
            opFlag = false;
        }
    }
}
