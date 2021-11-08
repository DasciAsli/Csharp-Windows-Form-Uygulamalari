using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomUygulamas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rSayi = new Random();
            int sayi = rSayi.Next(0, 50);
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\1.mp3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\2.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
