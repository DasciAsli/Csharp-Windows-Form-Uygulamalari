using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random x = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = x.Next(0, 100);
            pictureBox1.Left = pictureBox1.Left + sayi;
            if (pictureBox1.Location.X>=544)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\arabasol.png";
                
                timer1.Stop();
                MessageBox.Show("Engelle karşılaşıldı");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
