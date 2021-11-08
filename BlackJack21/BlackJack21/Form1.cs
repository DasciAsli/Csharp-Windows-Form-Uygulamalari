using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac1 = 0;
        int sayac2 = 0;
        int toplam1 = 0;
        int toplam2 = 0;
        int toplamsonuc1;
        int toplamsonuc2;
        int fark1;
        int fark2;
        int skor1 = 0;
        int skor2 = 0;

        private void temizle()
        {
            label1.Text = 0.ToString();
            label2.Text = 0.ToString();
            label3.Text = 0.ToString();
            label4.Text = 0.ToString();
            label5.Text = 0.ToString();
            label6.Text = 0.ToString();
            label7.Text = 0.ToString();
            label8.Text = 0.ToString();
            lblToplam1.Text = 0.ToString();
            lblToplam2.Text = 0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac1++;
            if (sayac1 == 1)
            {
                int a1, a2;
                a1 = rastgele.Next(1, 11);

                a2 = rastgele.Next(1, 11);
                if (a1 == 1 )
                {
                    pictureBox1.ImageLocation= "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (a1 == 2)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (a1 == 3)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (a1 == 4)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (a1 == 5)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (a1 == 6)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (a1 == 7)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (a1 == 8)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (a1 == 9)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (a1 == 10)
                {
                    pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }
                if (a2 == 1)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (a2 == 2)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (a2 == 3)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (a2 == 4)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (a2 == 5)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (a2 == 6)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (a2 == 7)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (a2 == 8)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (a2 == 9)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (a2 == 10)
                {
                    pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }


                toplam1 = a1 + a2;
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                lblToplam1.Text = toplam1.ToString();

            }

            if (sayac1 == 2)
            {
                int a3;
                a3 = rastgele.Next(1, 11);
                if (a3 == 1)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (a3 == 2)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (a3 == 3)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (a3 == 4)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (a3 == 5)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (a3 == 6)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (a3 == 7)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (a3 == 8)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (a3 == 9)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (a3 == 10)
                {
                    pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }


                toplam1 = toplam1 + a3;
                label3.Text = a3.ToString();
                lblToplam1.Text = toplam1.ToString();
            }
            if (sayac1 == 3)
            {
                int a4;
                a4 = rastgele.Next(1, 11);
                if (a4 == 1)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (a4 == 2)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (a4 == 3)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (a4 == 4)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (a4 == 5)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (a4 == 6)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (a4 == 7)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (a4 == 8)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (a4 == 9)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (a4 == 10)
                {
                    pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }

                toplam1 = toplam1 + a4;
                label4.Text = a4.ToString();
                lblToplam1.Text = toplam1.ToString();
            }
            if (sayac1 == 4)
            {
                button1.Enabled = false;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac2++;
            int b1, b2;
            b1 = rastgele.Next(1, 11);

            b2 = rastgele.Next(1, 11);
            if (b1 == 1)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
            }
            if (b1 == 2)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
            }
            if (b1 == 3)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
            }
            if (b1 == 4)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
            }
            if (b1 == 5)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
            }
            if (b1 == 6)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
            }
            if (b1 == 7)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
            }
            if (b1 == 8)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
            }
            if (b1 == 9)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
            }
            if (b1 == 10)
            {
                pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
            }
            if (b2 == 1)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
            }
            if (b2 == 2)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
            }
            if (b2 == 3)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
            }
            if (b2 == 4)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
            }
            if (b2 == 5)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
            }
            if (b2 == 6)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
            }
            if (b2 == 7)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
            }
            if (b2 == 8)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
            }
            if (b2 == 9)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
            }
            if (b2 == 10)
            {
                pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
            }
            toplam2 = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            lblToplam2.Text = toplam2.ToString();
            if (toplam2 < 16)
            {

                int b3;
                b3 = rastgele.Next(1, 11);
                if (b3 == 1)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (b3 == 2)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (b3 == 3)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (b3 == 4)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (b3 == 5)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (b3 == 6)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (b3 == 7)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (b3 == 8)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (b3 == 9)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (b3 == 10)
                {
                    pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }
                toplam2 = toplam2 + b3;
                label7.Text = b3.ToString();
                lblToplam2.Text = toplam2.ToString();


            }
            if (toplam2 < 16)
            {

                int b4;
                b4 = rastgele.Next(1, 11);
                if (b4 == 1)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\1.png";
                }
                if (b4 == 2)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\2.png";
                }
                if (b4 == 3)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\3.png";
                }
                if (b4 == 4)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\4.png";
                }
                if (b4 == 5)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\5.png";
                }
                if (b4 == 6)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\6.png";
                }
                if (b4 == 7)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\7.png";
                }
                if (b4 == 8)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\8.png";
                }
                if (b4 == 9)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\9.png";
                }
                if (b4 == 10)
                {
                    pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\10.png";
                }
                toplam2 = toplam2 + b4;
                label8.Text = b4.ToString();
                lblToplam2.Text = toplam2.ToString();


            }
            button2.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";

            button1.Enabled = true;
            button2.Enabled = true;
            toplamsonuc1 = toplam1;
            toplamsonuc2 = toplam2;
            if (toplamsonuc1 <= 21)
            {
                fark1 = 21 - toplamsonuc1;
            }
            if (toplamsonuc1 >= 21)
            {
                fark1 = toplamsonuc1 - 21;
            }
            if (toplamsonuc2 <= 21)
            {
                fark2 = 21 - toplamsonuc2;
            }
            if (toplamsonuc2 >= 21)
            {
                fark2 = toplamsonuc2 - 21;
            }
            if (fark1 > fark2)
            {
                MessageBox.Show("Bilgisayar kazandi!");
                skor2 = skor2 + 1;
                lbl2Skor.Text = skor2.ToString();
                temizle();
                sayac1 = 0;
                sayac2 = 0;

            }
            else if (fark2 > fark1)
            {
                MessageBox.Show("1.Oyuncu kazandi!");
                skor1 = skor1 + 1;
                lbl1Skor.Text = skor1.ToString();
                temizle();
                sayac1 = 0;
                sayac2 = 0;
            }
            else if (fark1 == fark2)
            {
                MessageBox.Show("Berabere!");
                skor2++;
                lbl2Skor.Text = skor2.ToString();
                skor1++;
                lbl1Skor.Text = skor1.ToString();
                temizle();
                sayac1 = 0;
                sayac2 = 0;
              
                }
            if (skor1 == 5 || skor2 == 5)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                if (skor1 > skor2)
                {
                    MessageBox.Show("KAZANAN 1.OYUNCU!!!");
                   
                    button3.Enabled = false;

                }
                if (skor2 > skor1)
                {
                    MessageBox.Show("KAZANAN BİLGİSAYAR!!!");
                    
                    button3.Enabled = false;
                }
                if (skor2 == skor1)
                {
                    MessageBox.Show("DOSTLUK KAZANDI!!!");
                    button3.Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox2.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox3.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox4.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox5.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox6.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox7.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";
            pictureBox8.ImageLocation = "C:\\Users\\hp\\Desktop\\arka.jpg";

        }
    }
    }

