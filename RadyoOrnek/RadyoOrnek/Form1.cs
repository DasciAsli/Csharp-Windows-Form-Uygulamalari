using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadyoOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\VİRGİN.png";
            pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\KRAL.png";
            pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\POWER.png";
            pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\JOY.png";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/VIRGIN_RADIO.mp3";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com:80/;";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerfm/abr/powerfm/128/playlist.m3u8 ";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://17703.live.streamtheworld.com/JOY_FM.mp3";
        }
    }
}
