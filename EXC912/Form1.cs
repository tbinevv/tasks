using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(a1.Text) + int.Parse(a2.Text) + int.Parse(a3.Text) == 15) &&
                (int.Parse(b1.Text) + int.Parse(b2.Text) + int.Parse(b3.Text) == 15) &&
                (int.Parse(c1.Text) + int.Parse(c2.Text) + int.Parse(c3.Text) == 15) &&
                (int.Parse(a1.Text) + int.Parse(b2.Text) + int.Parse(c3.Text) == 15) &&
                (int.Parse(a3.Text) + int.Parse(b2.Text) + int.Parse(c1.Text) == 15) &&
                (int.Parse(a1.Text) + int.Parse(b1.Text) + int.Parse(c1.Text) == 15) &&
                (int.Parse(a2.Text) + int.Parse(b2.Text) + int.Parse(c2.Text) == 15) &&
                (int.Parse(a3.Text) + int.Parse(b3.Text) + int.Parse(c3.Text) == 15) &&
                (int.Parse(a1.Text) + int.Parse(b1.Text) + int.Parse(c1.Text) + int.Parse(a2.Text) + int.Parse(b2.Text) + int.Parse(c2.Text) + (int.Parse(a3.Text) + int.Parse(b3.Text) + int.Parse(c3.Text) == 45))
                label1.Show();
        }
    }
}
