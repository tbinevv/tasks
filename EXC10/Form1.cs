using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = (double.Parse(textBox1.Text)*0.61).ToString();
            label10.Text = (double.Parse(textBox2.Text) * 0.45).ToString();
            label12.Text = (double.Parse(textBox3.Text) * 0.51).ToString();
        }
    }
}
