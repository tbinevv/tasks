using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) + double.Parse(textBox2.Text) > double.Parse(textBox3.Text) && 
                double.Parse(textBox3.Text) + double.Parse(textBox1.Text) > double.Parse(textBox2.Text) &&
                double.Parse(textBox3.Text) + double.Parse(textBox3.Text) > double.Parse(textBox1.Text))
            {
                label6.Text = "It exists!";
                double p = (double.Parse(textBox3.Text) + double.Parse(textBox1.Text) + double.Parse(textBox2.Text))/2;
                label7.Text = Math.Sqrt(p*(p - double.Parse(textBox1.Text))*(p - double.Parse(textBox2.Text))*(p - double.Parse(textBox3.Text))).ToString();
            }
        }
    }
}
