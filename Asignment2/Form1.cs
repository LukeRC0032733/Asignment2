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
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
            {

                double A = double.Parse(textBox6.Text);
                double B = double.Parse(textBox7.Text);
                double C = double.Parse(textBox8.Text);
                double D = double.Parse(textBox9.Text);
                double E = double.Parse(textBox10.Text);
                double ans = 1 / 1 / A + 1 / B + 1 / C + 1 / D + 1 / E;
                label3.Text = ans.ToString();
            }       
        }
    }
}
