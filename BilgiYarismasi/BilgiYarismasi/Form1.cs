using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno=0;
        private void button5_Click(object sender, EventArgs e)
        {
            soruno++;
            label1.Text = soruno.ToString();
            if (soruno == 5)
            {
                button5.Enabled = false;
            }
            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur ?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur ?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = button1.Text;
            label4.Text = "1881";
            
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevap Doğru");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = button4.Text;

            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevap Doğru");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = button2.Text;

            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevap Doğru");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = button3.Text;

            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevap Doğru");
            }
        }
    }
}
