using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yangi
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation_job = "";
        bool operators = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_clic(object sender, EventArgs e)
        {
            if (natija.Text == "0"||operators) natija.Text = "";
            Button b = (Button)sender;
            natija.Text = natija.Text + b.Text;
            operators = false;
        }

        private void null_job(object sender, EventArgs e)
        {
            //natija.Clear();
            natija.Text = "0";
        }

        private void operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation_job = b.Text;
            value = Double.Parse(natija.Text);
            operators = true;
            coppi.Text = value + " " + operation_job;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            coppi.Text = "";
            switch (operation_job)
            {
                case "+": 
                    natija.Text = (value + Double.Parse(natija.Text)).ToString();
                    break;
                case "-":
                    natija.Text = (value - Double.Parse(natija.Text)).ToString();
                    break;
                case "*":
                    natija.Text = (value * Double.Parse(natija.Text)).ToString();
                    break;
                case "/":
                    natija.Text = (value / Double.Parse(natija.Text)).ToString();
                    break;
                
                default:
                    break;
            }

        }

        private void operation_clic(object sender, EventArgs e)
        {
             Button b = (Button)sender;
            operation_job = b.Text;
            value = Double.Parse(natija.Text);
            natija.Text = Math.Sqrt(value).ToString();
            coppi.Text = value + " " + operation_job;
        }

        private void degree_clic(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation_job = b.Text;
            value = double.Parse(natija.Text);
            natija.Text =(value * value).ToString();
            coppi.Text = value + " " + operation_job;
        }

        private void remov(object sender, EventArgs e)
        {
            if (natija.Text.Length > 0)
            {
                natija.Text = natija.Text.Remove(natija.Text.Length - 1, 1);
            }
            if (natija.Text == "")
            {
                natija.Text = "0"; 
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (natija.Text.Contains("-"))
            {
                natija.Text = natija.Text.Remove(0, 1);
            }
            else
            {
                natija.Text = "-" + natija.Text;
            }

        }

        
    }
}
