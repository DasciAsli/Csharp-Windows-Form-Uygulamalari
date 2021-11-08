using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int alan;
        int cevre;
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = button1.Text;
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label2.Text = "Kenar uzunluğu girin";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == button1.Text)
            {
                alan = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                label5.Text = alan.ToString();
                cevre = Convert.ToInt32(textBox1.Text) * 4;
                label6.Text = cevre.ToString();
                
            }
            if (label1.Text== button2.Text)
            {
                alan = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                label5.Text = alan.ToString();
                cevre = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text))*2;
                label6.Text = cevre.ToString();

            }
     



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            label1.Text = button2.Text;
            panel1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            label7.Text = "Kısa kenarı girin";
            label2.Text = "Uzun kenarı girin";
            label5.Text = "";
            label6.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
