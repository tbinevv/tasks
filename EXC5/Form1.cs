using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Multiline = true;
            maskedTextBox1.Hide();
            maskedTextBox1.Text = "Biology\nMaths\nIT\nIT\nPhysics\nPhilosphy";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < (char)48) || (e.KeyChar > (char)55)) && (e.KeyChar != (char)8))
                e.KeyChar = (char)0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            MessageBox.Show(maskedTextBox1.Lines[n - 1]);
        }
    }
}
