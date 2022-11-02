using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        Double values = 0;
        String opetarion = "";
        bool operation_job = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (natija.Text == "0" || (operation_job))
                natija.Clear();
            operation_job = false;
            Button b = (Button)sender;
             natija.Text = natija.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            natija.Text = "0";
        }

        private void operation_clic(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            opetarion = b.Text;
            values = Double.Parse(natija.Text);
            operation_job = true;
            coppi.Text = values + " " + opetarion;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            coppi.Text = "";
            switch (opetarion)
            {
                case "+":
                    natija.Text = (values + Double.Parse(natija.Text)).ToString();
                    break;
                case "-":
                    natija.Text = (values - Double.Parse(natija.Text)).ToString();
                    break;
                case "*":
                    natija.Text = (values * Double.Parse(natija.Text)).ToString();
                    break;
                case "/":
                    natija.Text = (values / Double.Parse(natija.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            natija.Text = "0";
            //values = 0;
        }

        private void natija_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
