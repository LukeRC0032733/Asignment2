using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // calculates resistance for 2 resistors in series  
            try
            {
                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox2.Text);
                double ans = A + B;
                label4.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { // calculates resistance for 2 resistors in parallel

                double A = double.Parse(textBox6.Text);
                double B = double.Parse(textBox7.Text);
                double ans = 1 / (1 / A + 1 / B);
                label3.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number"); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {  // calculates resistance for 3 resistors in series  
                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox2.Text);
                double C = double.Parse(textBox3.Text);
                double ans = A + B + C;
                label4.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {  // calculates resistance for 4 resistors in series  
                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox2.Text);
                double C = double.Parse(textBox3.Text);
                double D = double.Parse(textBox4.Text);
                double ans = A + B + C + D;
                label4.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {  // calculates resistance for 5 resistors in series  
                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox2.Text);
                double C = double.Parse(textBox3.Text);
                double D = double.Parse(textBox4.Text);
                double E = double.Parse(textBox5.Text);
                double ans = A + B + C + D + E;
                label4.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            { // calculates resistance for 3 resistors in parallel

                double A = double.Parse(textBox6.Text);
                double B = double.Parse(textBox7.Text);
                double C = double.Parse(textBox8.Text);
                double ans = 1 / (1 / A + 1 / B + 1 / C);
                label3.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            { // calculates resistance for 4 resistors in parallel

                double A = double.Parse(textBox6.Text);
                double B = double.Parse(textBox7.Text);
                double C = double.Parse(textBox8.Text);
                double D = double.Parse(textBox9.Text);
                double ans = 1 / (1 / A + 1 / B + 1 / C + 1 / D);
                label3.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            { // calculates resistance for 5 resistors in parallel

                double A = double.Parse(textBox6.Text);
                double B = double.Parse(textBox7.Text);
                double C = double.Parse(textBox8.Text);
                double D = double.Parse(textBox9.Text);
                double E = double.Parse(textBox10.Text);
                double ans = 1 / (1 / A + 1 / B + 1 / C + 1 / D + 1 / E);
                label3.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a Number");
            }
        }
    }
}
    
