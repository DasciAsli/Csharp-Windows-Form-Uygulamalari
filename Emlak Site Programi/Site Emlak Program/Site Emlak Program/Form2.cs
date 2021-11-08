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

namespace Site_Emlak_Program
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASLI\\SQLEXPRESS;Initial Catalog=siteler;Integrated Security=True");
        private void verilerigoruntule()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sitebilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void verilerikaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into sitebilgi (id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" +textBox3.Text.ToString()+ "','" + comboBox1.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox7.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + comboBox2.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        private void verilerisil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from sitebilgi where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void verileriduzenle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update sitebilgi Set id='" + textBox3.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',oda='" + comboBox3.Text.ToString()+"',metre ='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox7.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox6.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "' where id="+id+" ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Zambak Sitesi")
            {
                BtnZambak.BackColor = Color.Blue;
                BtnGül.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGül.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Blue;
            }
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGül.BackColor = Color.Gray;
                BtnMenekse.BackColor = Color.Blue;
                BtnPapatya.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Gül Sitesi")
            {
                BtnZambak.BackColor = Color.Gray;
                BtnGül.BackColor = Color.Blue;
                BtnMenekse.BackColor = Color.Gray;
                BtnPapatya.BackColor = Color.Gray;
            }
        }

        private void btnGrntle_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void btnKydt_Click(object sender, EventArgs e)
        {
            verilerikaydet();
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            verilerisil();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;
           
        }

        private void btnDznle_Click(object sender, EventArgs e)
        {
            verileriduzenle();
        }
    }
}
