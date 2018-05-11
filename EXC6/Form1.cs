using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label1.Show();
            if (maskedTextBox1.MaskFull) label1.Hide();
        }
    }
}
