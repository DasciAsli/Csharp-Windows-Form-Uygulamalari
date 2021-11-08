using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 100;
        int sayi2 = 20;


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            int carpim = sayi1 * sayi2;
            label1.Text = carpim.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
            int cikar = sayi1 - sayi2;
            label1.Text = cikar.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            int bol = sayi1 / sayi2;
            label1.Text = bol.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            int toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();
        }
    }
}
