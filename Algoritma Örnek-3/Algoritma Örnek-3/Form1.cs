using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_Örnek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int bolentoplami = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i ==0)
                {
                    bolentoplami = bolentoplami + i;
                   
                }
            }
            if (bolentoplami == sayi)
            {
                label1.Text = sayi + " mükemmel sayidir";
            }
            else
            {
                label1.Text = sayi + " mükemmel sayi değildir.";
            }
        }
    }
}
