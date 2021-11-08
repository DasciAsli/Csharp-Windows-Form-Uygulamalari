using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaktoriyelHesaplamaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fak = 1;
            for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                fak = fak * i;
            }
            label2.Text = fak.ToString();
        }
    }
}
