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

namespace PansiyonKayitUygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASLI\\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");
        int id = 0;
        int kontrol = 0;
        private void temizle()
        {
            txtBxsirano.Clear();
            txtBxad.Clear();
            txtBxSoyad.Clear();
            txtBxOdaNo.Clear();
            txtBxHesap.Clear();
            txtBxTel.Clear();
            
        }
        private void listboxtemizle()
        {
            listView1.Items.Clear();
        }
        private void verilerigöster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from müsteri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["sirano"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["giristarih"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["hesap"].ToString());
                ekle.SubItems.Add(oku["cikistarih"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            listboxtemizle();
            verilerigöster();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol = 1;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into müsteri (sirano,ad,soyad,odano,giristarih,telefon,hesap,cikistarih) values ('" + txtBxsirano.Text.ToString() + "','" + txtBxad.Text.ToString() + "','" + txtBxSoyad.Text.ToString() + "','" + txtBxOdaNo.Text.ToString() + "','" + cmbBxGirisT.Text.ToString() + "','" + txtBxTel.Text.ToString() + "','" + txtBxHesap.Text.ToString() + "','" + cmbBxCikisT.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from müsteri where sirano =(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtBxsirano.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtBxad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtBxSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtBxOdaNo.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cmbBxGirisT.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtBxTel.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtBxHesap.Text = listView1.SelectedItems[0].SubItems[6].Text;
            cmbBxCikisT.Text = listView1.SelectedItems[0].SubItems[7].Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update müsteri set sirano= '" +txtBxsirano.Text.ToString()+ "',ad= '" + txtBxad.Text.ToString() + "',soyad= '" + txtBxSoyad.Text.ToString() + "',odano= '" + txtBxOdaNo.Text.ToString() + "',giristarih= '" + cmbBxGirisT.Text.ToString() + "',telefon= '" + txtBxTel.Text.ToString() + "',hesap= '" + txtBxHesap.Text.ToString() + "',cikistarih= '" + cmbBxCikisT.Text.ToString() + "' where sirano=" +id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBxOdaNo.Text = button6.Text;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBxOdaNo.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBxOdaNo.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBxOdaNo.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBxOdaNo.Text = button10.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
