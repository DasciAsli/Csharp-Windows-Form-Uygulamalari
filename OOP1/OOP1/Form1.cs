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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil ilkarac = new Otomobil();
            ilkarac.Marka = "Hyundai";
            ilkarac.Model = "Getz";
            ilkarac.ModelYili = 2013;
            ilkarac.Renk = "Beyaz";
            ilkarac.VitesTipi = "Manuel";
            string marka = ilkarac.MarkaGetir();
            label6.Text = ilkarac.Marka.ToString();
            label7.Text = ilkarac.Model.ToString();
            label8.Text = ilkarac.ModelYili.ToString();
            label9.Text = ilkarac.Renk.ToString();
            label10.Text = ilkarac.VitesTipi.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 otherpage = new Form2();
            otherpage.Show();
            
        }
    }
}
