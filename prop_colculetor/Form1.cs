using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prop_colculetor
{
    public partial class Form1 : Form
    {
        double var = 0;
        string clic = "";
        bool operators = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clic(object sender, EventArgs e)
        {
            if (natija.Text == "0"||operators) natija.Text ="";
            Button bt = (Button)sender;
            natija.Text += bt.Text;
            operators = false;
        }

        private void bnt_operator(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            clic = bt.Text;
            var = double.Parse(natija.Text);
            operators = true;
            copy.Text = var + "" + clic;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            copy.Text = "";
            switch (clic)
            {
                case "+":
                    natija.Text = (var + double.Parse(natija.Text)).ToString();
                    break;
                case "-":
                    natija.Text = (var - double.Parse(natija.Text)).ToString();
                    break;
                case "*":
                    natija.Text = (var * double.Parse(natija.Text)).ToString();
                    break;
                case "/":
                    natija.Text = (var / double.Parse(natija.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            clic = bt.Text;
            var = double.Parse(natija.Text);
            natija.Text = Math.Sqrt(var).ToString();
            copy.Text = var+clic;
        }

        private void delete(object sender, EventArgs e)
        {
            natija.Text = "0";
            copy.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            var = double.Parse(natija.Text);
            clic = bt.Text;
            natija.Text = (var*var).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (natija.Text.Length > 0)
            {
                natija.Text = natija.Text.Remove(natija.Text.Length - 1, 1);
            }
            if (natija.Text == "0")
            {
                natija.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
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
