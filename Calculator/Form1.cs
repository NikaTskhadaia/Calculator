﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 9) return;
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = "+";
            label2.Text = label1.Text;
            label1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Text = "-";
            label2.Text = label1.Text;
            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = "/";
            label2.Text = label1.Text;
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label3.Text = "*";
            label2.Text = label1.Text;
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "") return;
            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "" || label2.Text == "") return;

            double a = double.Parse(label1.Text);
            double b = double.Parse(label2.Text);

            if (label3.Text == "+")
            {
                label1.Text = (a+b).ToString();
                label2.Text = "";
                label3.Text = "";
            }

            if (label3.Text == "-")
            {
                label1.Text = (a - b).ToString();
                label2.Text = "";
                label3.Text = "";
            }

            if (label3.Text == "/")
            {
                label1.Text = (a / b).ToString();
                label2.Text = "";
                label3.Text = "";
            }

            if (label3.Text == "*")
            {
                label1.Text = (a * b).ToString();
                label2.Text = "";
                label3.Text = "";
            }
        }
    }
}
