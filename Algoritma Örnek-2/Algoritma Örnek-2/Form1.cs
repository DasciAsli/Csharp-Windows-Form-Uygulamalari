using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_Örnek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int adet = 0;
            for (int i = 1; i <= 25; i++)
            {
                if (i % 7==0)
                {
                    listBox1.Items.Add(i);
                    adet = adet + 1;
                    toplam = toplam + i;       
                }
            }
            lblAdet.Text = adet.ToString();
            lblToplam.Text = toplam.ToString();
        }
    }
}
