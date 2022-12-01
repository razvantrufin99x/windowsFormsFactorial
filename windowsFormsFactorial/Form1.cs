using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace windowsFormsFactorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int64 fact(Int64 n)
        {
            /*****************************************************************************
            * *
            * Compute a factorial recursively. *
            * *
            *****************************************************************************/
            if (n < 0)
                return 0;
            else if (n == 0)
                return 1;
            else if (n == 1)
                return 1;
            else
                return n * fact(n - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 f = fact(35);
            textBox1.Text = f.ToString();
        }
    }
}
