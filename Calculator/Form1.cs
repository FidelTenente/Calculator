using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            work("+");              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            work("-");         
        }


        private void work(string str)
        {
            double ar1 = Convert.ToDouble(textBox1.Text);
            double ar2 = Convert.ToDouble(textBox2.Text);
            Operation sum = Fabrica.fabricaCalc(str);
            textBox3.Text = Convert.ToString(sum.Calculation(ar1, ar2));
            label1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            work("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            work("/");
            
        }

        private void singleWork(string str)
        {
            double ar1 = Convert.ToDouble(textBox1.Text);
            singleOperation rez = singleFabrica.fabricaSingleCalc(str);
            textBox3.Text = Convert.ToString(rez.singleCalculation(ar1));
            label1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            singleWork("sqrt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            work("X^Y");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            singleWork("Logarithm");
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            singleWork("Sin");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            singleWork("Cos");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            singleWork("Tan");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            singleWork("Atan");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            singleWork("1/X");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            singleWork("Exp");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            singleWork("Acos");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            singleWork("Asin");
        }

        
     }
}
