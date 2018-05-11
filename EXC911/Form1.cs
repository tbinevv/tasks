using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC911
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i; int max = 0, min = 500;
            
            Random r = new Random();
            a = r.Next() % 500;
            for (i = 0; i < 50; i++)
            {
                if (a > max) max = a;
            }

            a = r.Next() % 500;
            for (i = 0; i < 50; i++)
            {
                if (min > a) min = a;
            }

            MessageBox.Show("Min=" + min.ToString() + "  Max=" + max.ToString());
        }

    }
}
