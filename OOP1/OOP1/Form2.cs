using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil ikinciArac = new Otomobil();
            ikinciArac.Marka = "Hyundai";
            ikinciArac.Model = "Accent";
            ikinciArac.ModelYili = 2015;
            ikinciArac.Renk = "Mavi";
            ikinciArac.VitesTipi = "Otomatik";

            string marka = ikinciArac.MarkaGetir();
            label6.Text = ikinciArac.Marka.ToString();
            label7.Text = ikinciArac.Model.ToString();
            label8.Text = ikinciArac.ModelYili.ToString();
            label9.Text = ikinciArac.Renk.ToString();
            label10.Text = ikinciArac.VitesTipi.ToString();
        }
    }
}
