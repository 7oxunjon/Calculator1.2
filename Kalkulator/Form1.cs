using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class natija : Form
    {
        String operations = " ";
        Double first, secont;
        public natija()
        {
            InitializeComponent();
        }
        private void number_clic(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (rezultat.Text == "0")
            {
                rezultat.Text = " ";
            }
                
           
            if(b.Text == ".")
            {
                if (!rezultat.Text.Contains("."))
                    rezultat.Text = rezultat.Text + b.Text;
            }
            else rezultat.Text = rezultat.Text + b.Text;
        }

        private void cleare_clic(object sender, EventArgs e)
        {
            rezultat.Text = "0";
        }

        private void operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            first = Double.Parse(rezultat.Text);
            operations = b.Text;
            rezultat.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (rezultat.Text.Length > 0)
            {
                rezultat.Text = rezultat.Text.Remove(rezultat.Text.Length - 1, 1);
            }
            if (rezultat.Text == " ")
            {
                rezultat.Text = "0";
            }
        }



        private void button24_Click(object sender, EventArgs e)
        {
            if (rezultat.Text.Contains("-"))
            {
                rezultat.Text = rezultat.Text.Remove(0, 1);
            }
            else
            {
                rezultat.Text = "-" + rezultat.Text;
            }

        }
        private void button17_Click(object sender, EventArgs e)
          {
            secont = double.Parse(rezultat.Text);
            switch (operations)
            {
                case "+":
                    rezultat.Text = (first + secont).ToString();
                    break;
                case "-":
                    rezultat.Text = (first - secont).ToString();
                    break;
                case "*":
                    rezultat.Text = (first * secont).ToString();
                    break;
                case "/":
                    rezultat.Text = (first / secont).ToString();
                    break;
                default:
                    break;
            }
                

          }

    }
}
