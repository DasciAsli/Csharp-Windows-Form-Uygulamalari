using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLigOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random ySkor = new Random();
        int gPuan = 0;
        int fPuan = 0;
        int bPuan = 0;
        int tPuan = 0;
        
        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            
            int g1 = ySkor.Next(0, 5);
            label4.Text = g1.ToString();

            int f1 = ySkor.Next(0, 5);
            label5.Text = f1.ToString();

            int b1 = ySkor.Next(0, 5);
            label8.Text = b1.ToString();


            int t1 = ySkor.Next(0, 5);
            label6.Text = t1.ToString();
            



            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gPuan = gPuan + 3;
                labelgPuan.Text = gPuan.ToString();
                
                

            }
            if(Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fPuan = fPuan + 3;
                labelfpuan.Text = fPuan.ToString();
                
            }
            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gPuan = gPuan + 1;
                fPuan = fPuan + 1;
                labelgPuan.Text = gPuan.ToString(); 
                labelfpuan.Text = fPuan.ToString();
                

            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                bPuan = bPuan + 3;
                labelbPuan.Text = bPuan.ToString();
         
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tPuan = tPuan + 3;
                labeltPuan.Text = tPuan.ToString();
                
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label6.Text))
            {
                bPuan = bPuan + 1;
                tPuan = tPuan + 1;
                labelbPuan.Text = bPuan.ToString();    
                labeltPuan.Text = tPuan.ToString();
                
            }


             button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int g1 = ySkor.Next(0, 5);
            label16.Text = g1.ToString();
            
            int f1 = ySkor.Next(0, 5);
            label15.Text = f1.ToString();
            
            int b1 = ySkor.Next(0, 5);
            label12.Text = b1.ToString();

            
            int t1 = ySkor.Next(0, 5);
            label11.Text = t1.ToString();

            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label12.Text))
            {
                gPuan = gPuan + 3;
                labelgPuan.Text = gPuan.ToString();

            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label16.Text))
            {
                bPuan = bPuan + 3;
                labelbPuan.Text = bPuan.ToString();
            }
            if (Convert.ToInt32(label16.Text) == Convert.ToInt32(label12.Text))
            {
                gPuan = gPuan + 1;
                bPuan = bPuan + 1;
                labelgPuan.Text = gPuan.ToString();
                labelbPuan.Text = bPuan.ToString();

            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label11.Text))
            {
                fPuan = fPuan + 3;
                labelfpuan.Text = fPuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label15.Text))
            {
                tPuan = tPuan + 3;
                labeltPuan.Text = tPuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label11.Text))
            {
                bPuan = bPuan + 1;
                tPuan = tPuan + 1;
                labelbPuan.Text = bPuan.ToString();
                labeltPuan.Text = tPuan.ToString();
            }
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int g1 = ySkor.Next(0, 5);
            label29.Text = g1.ToString();

            int f1 = ySkor.Next(0, 5);
            label30.Text = f1.ToString();

            int b1 = ySkor.Next(0, 5);
            label26.Text = b1.ToString();


            int t1 = ySkor.Next(0, 5);
            label25.Text = t1.ToString();

            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label26.Text))
            {
                fPuan = fPuan + 3;
                labelfpuan.Text = fPuan.ToString();

            }
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label30.Text))
            {
                bPuan = bPuan + 3;
                labelbPuan.Text = bPuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) == Convert.ToInt32(label30.Text))
            {
                fPuan = fPuan + 1;
                bPuan = bPuan + 1;
                labelfpuan.Text = fPuan.ToString();
                labelbPuan.Text = bPuan.ToString();

            }
            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label25.Text))
            {
                gPuan = gPuan + 3;
                labelgPuan.Text = gPuan.ToString();
                
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label29.Text))
            {
                tPuan = tPuan + 3;
                labeltPuan.Text = tPuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label29.Text))
            {
                gPuan = gPuan + 1;
                tPuan = tPuan + 1;
                labelgPuan.Text = gPuan.ToString();
                labeltPuan.Text = tPuan.ToString();
            }
            button3.Enabled = false;

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgPuan.Text) > Convert.ToInt32(labelbPuan.Text) && Convert.ToInt32(labelgPuan.Text) > Convert.ToInt32(labelfpuan.Text) && Convert.ToInt32(labelgPuan.Text) > Convert.ToInt32(labeltPuan.Text))
            {
                label35.Text = "ŞAMPİYON GALATASARAY!";
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\G.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\G1.mp3";
            }
            if (Convert.ToInt32(labelbPuan.Text) > Convert.ToInt32(labelgPuan.Text) && Convert.ToInt32(labelbPuan.Text) > Convert.ToInt32(labelfpuan.Text) && Convert.ToInt32(labelbPuan.Text) > Convert.ToInt32(labeltPuan.Text))
            {
                label35.Text = "ŞAMPİYON BEŞİKTAŞ!";
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\BEE.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\B1.mp3";
            }
            if (Convert.ToInt32(labelfpuan.Text) > Convert.ToInt32(labelgPuan.Text) && Convert.ToInt32(labelfpuan.Text) > Convert.ToInt32(labelbPuan.Text) && Convert.ToInt32(labelfpuan.Text) > Convert.ToInt32(labeltPuan.Text))
            {
                label35.Text = "ŞAMPİYON FENERBAHÇE!";
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\F.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\F1.mp3";
            }
            if (Convert.ToInt32(labeltPuan.Text) > Convert.ToInt32(labelgPuan.Text) && Convert.ToInt32(labeltPuan.Text) > Convert.ToInt32(labelbPuan.Text) && Convert.ToInt32(labeltPuan.Text) > Convert.ToInt32(labelfpuan.Text))
            {
                label35.Text = "ŞAMPİYON TRABZONSPOR!";
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\T.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\T1.mp3";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelgPuan.Visible = true;
        }
    }
}
