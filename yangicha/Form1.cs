using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yangicha
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = " ";
        bool holat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (natija.Text == "0")
                natija.Clear();
            Button b = (Button)sender;
            natija.Text = natija.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            natija.Text = "0";
        }

        private void operation_clic(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(natija.Text);
            holat = true;
        }
    }
}
