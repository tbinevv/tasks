using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox1.Text);

            double D = b * b - 4 * a * c;

            if (D == 0)
            {
                label5.Text = (-b / 2 * a).ToString();
                label7.Text = (-b / 2 * a).ToString();
            }
            else if (D < 0)
            {
                label5.Text = "Not a real number";
                label7.Text = "Not a real number";
            }
            else
            {
                label5.Text = (-b + Math.Sqrt(D)/ 2 * a).ToString();
                label7.Text = (-b - Math.Sqrt(D) / 2 * a).ToString();
            } 
        }
    }
}
