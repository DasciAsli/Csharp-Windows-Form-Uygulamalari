using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointİleAsansörUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
            label7.BackColor = Color.MediumTurquoise;
            label5.BackColor = Color.MediumTurquoise;
            label6.BackColor = Color.MediumTurquoise;
            label4.BackColor = Color.MediumTurquoise;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
            label7.BackColor = Color.MediumTurquoise;
            label5.BackColor = Color.MediumTurquoise;
            label6.BackColor = Color.MediumTurquoise;
            label4.BackColor = Color.MediumTurquoise;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label8.Text=="1")
            {
                pictureBox2.Top = pictureBox2.Top - 50;
            }
            if (label8.Text == "0")
            {
                pictureBox2.Top = pictureBox2.Top + 50;
            }

            if (pictureBox2.Location.Y <= 110)
            {
                
                timer1.Stop();
                label7.BackColor = Color.Green;
                label5.BackColor = Color.Green;

            }
            if (pictureBox2.Location.Y >= 310)
            {
                timer1.Stop();
                label6.BackColor = Color.Green;
                label4.BackColor = Color.Green;
            }
        }

        
    }
}
