using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Boolean Perfect(int n)
        {
            int sum = 0;
            for (int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    sum = sum + i;
                }
            }
            if (n==sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if(Perfect(x))
            {
                textBox2.Text = "It's Perfect";
            }
            else
            {
                textBox2.Text = "Not Perfect";
            }
        }
    }
}
