using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonKayitUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = "admin";
            string kParola = "123";
            if (txtBxKad.Text==kAdi || txtBxParola.Text==kParola)
            {
                Form2 kayitsayfasi = new Form2();
                kayitsayfasi.Show();
                this.Hide();
            }
        }
    }
}
