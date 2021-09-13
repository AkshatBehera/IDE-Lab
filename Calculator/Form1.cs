using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool op_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((output.Text == "0")||(op_pressed))
                output.Clear();

            
            Button b = (Button)sender;
            output.Text = output.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(output.Text);
            op_pressed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            switch(operation)
            {
                case "+":
                    output.Text = (value + Double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (value - Double.Parse(output.Text)).ToString();
                    break;
                case "*":
                    output.Text = (value * Double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (value / Double.Parse(output.Text)).ToString();
                    break;
                case "Sqrt":
                    output.Text = (value * value).ToString();
                    break;
                default:
                    break;
            }

            op_pressed = false;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            output.Clear();
            value = 0;
        }
    }
}
