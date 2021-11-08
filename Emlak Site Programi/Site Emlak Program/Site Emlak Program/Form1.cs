using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Emlak_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxKAd.Text=="Asli" && textBoxKParola.Text=="123")
            {
                Form2 emlakKayit = new Form2();
                emlakKayit.Show();
                this.Hide();
            }
        }
    }
}
