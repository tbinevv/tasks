using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXC4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int monthNum = int.Parse(textBox1.Text);
            if (monthNum < 0 || monthNum > 12) label2.Text = "Non-existing month";
            else
            {
                if (monthNum == 12 || monthNum == 1 || monthNum == 2) label2.Text = "Winter";
                else if (monthNum == 3 || monthNum == 4 || monthNum == 5) label2.Text = "Spring";
                else if (monthNum == 6 || monthNum == 7 || monthNum == 8) label2.Text = "Summer";
                else if (monthNum == 9 || monthNum == 10 || monthNum == 11) label2.Text = "Autumn";
            }
        }
    }
}
