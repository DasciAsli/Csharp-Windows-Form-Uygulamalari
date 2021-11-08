using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasiProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASLI\\SQLEXPRESS;Initial Catalog=sorularim;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (button1.Text==lblDgru.Text)
            {
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            
            btnBasla.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (button2.Text == lblDgru.Text)
            {
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (button3.Text == lblDgru.Text)
            {
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (button4.Text == lblDgru.Text)
            {
                puan = puan + 20;
                lblPuan.Text = puan.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;

        }


        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            btnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnBasla.Text = "Sonraki";
            sayac++;
            lblSoru.Text = sayac.ToString();

            if (sayac==1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from soru1 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    lblDgru.Text = oku["dogru"].ToString();
                }
                baglanti.Close();

            }
            if (sayac == 2)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from soru2 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                
                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    lblDgru.Text = oku["dogru"].ToString();
                }
                baglanti.Close();

            }
            if (sayac == 3)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from soru3 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    lblDgru.Text = oku["dogru"].ToString();
                }
                baglanti.Close();

            }
            if (sayac == 4)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from soru4 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    lblDgru.Text = oku["dogru"].ToString();
                }
                baglanti.Close();

            }
            if (sayac == 5)
            {
                
                btnBasla.Text = "Oyun bitti";
                btnBasla.Enabled = false;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from soru5 order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    textBox1.Text = oku["soru"].ToString();
                    button1.Text = oku["a"].ToString();
                    button2.Text = oku["b"].ToString();
                    button3.Text = oku["c"].ToString();
                    button4.Text = oku["d"].ToString();
                    lblDgru.Text = oku["dogru"].ToString();
                }
                baglanti.Close();
              

            }
            if (sayac==6)
            {
                timer1.Enabled = false;
                zaman = 0;
                btnBasla.Text = "Oyun bitti";
                lblSoru.Text = "-";
                btnBasla.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSoru.Text = sayac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblSüre.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnBasla.Enabled = true;
                MessageBox.Show("Süreniz doldu!");
            }

        }
    }
}
