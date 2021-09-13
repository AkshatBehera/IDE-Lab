using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeOrNot_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Boolean Prime(int n)
        {
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i==0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if(Prime(x))
            {
                textBox2.Text = "Prime Number";
            }
            else
            {
                textBox2.Text = "Not A Prime Number";
            }
        }
    }
}
