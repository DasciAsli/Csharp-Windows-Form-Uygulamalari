using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YordamOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Temizle()
        {

            txtBxS1.Clear();
            txtBxS2.Clear();
            txtBxSonuc.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(txtBxS1.Text);
                int sayi2 = Convert.ToInt32(txtBxS2.Text);
                int carpim = sayi1 * sayi2;
                txtBxSonuc.Text = carpim.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Geçerli bir deger giriniz!");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
