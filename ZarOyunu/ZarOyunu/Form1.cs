using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamPuan = 0;
        int toplamPuan2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            
            int sayi= rastgele.Next(1, 7);
            int sayi2 = rastgele.Next(1, 7);
            label2.Text = sayi.ToString();
            label3.Text = sayi2.ToString();
            toplamPuan = toplamPuan + sayi + sayi2;
            label5.Text = toplamPuan.ToString();
            label17.Text = label5.Text;
            if (sayi == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar1.png";
            }
            if (sayi == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar2.png";
            }
            if (sayi == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar3.png";
            }
            if (sayi == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar4.png";
            }
            if (sayi == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar5.png";
            }
            if (sayi == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar6.png";
            }
            if (sayi2 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar1.png";
            }
            if (sayi2 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar2.png";
            }
            if (sayi2 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar3.png";
            }
            if (sayi2 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar4.png";
            }
            if (sayi2 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar5.png";
            }
            if (sayi2 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar6.png";
            }
            if (Convert.ToInt32(label17.Text) >= 100 && Convert.ToInt32(label17.Text) > Convert.ToInt32(label15.Text))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                label13.Visible = true;
                label13.Text = "1.OYUNCU KAZANDI!";

            }
            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            int sayi3 = rastgele.Next(1, 7);
            int sayi4 = rastgele.Next(1, 7);
            label11.Text = sayi3.ToString();
            label9.Text = sayi4.ToString();
            toplamPuan2 = toplamPuan2 + sayi3+ sayi4;
            label7.Text = toplamPuan2.ToString();
            label15.Text = label7.Text;
            if (sayi3 == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar1.png";
            }
            if (sayi3 == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar2.png";
            }
            if (sayi3 == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar3.png";
            }
            if (sayi3 == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar4.png";
            }
            if (sayi3 == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar5.png";
            }
            if (sayi3 == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\zar6.png";
            }
            if (sayi4 == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar1.png";
            }
            if (sayi4 == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar2.png";
            }
            if (sayi4 == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar3.png";
            }
            if (sayi4 == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar4.png";
            }
            if (sayi4 == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar5.png";
            }
            if (sayi4 == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\zar6.png";
            }
            if (Convert.ToInt32(label15.Text) >= 100 && Convert.ToInt32(label15.Text) > Convert.ToInt32(label17.Text))
            {
                button2.Enabled = false;
                button1.Enabled = false;
                label13.Visible = true;
                label13.Text = "2.OYUNCU KAZANDI!";

            }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
