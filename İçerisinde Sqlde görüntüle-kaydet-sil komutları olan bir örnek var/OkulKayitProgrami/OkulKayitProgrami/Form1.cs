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

namespace OkulKayitProgrami
{
    public partial class OgrenciFormu : Form
    {
        public OgrenciFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASLI\\SQLEXPRESS;Initial Catalog=Okul;Integrated Security=True");
        int id = 0;
        private void verilerigoruntule()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Ogrenci", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["DogumYeri"].ToString());
                ekle.SubItems.Add(oku["AnneAdi"].ToString());
                ekle.SubItems.Add(oku["BabaAdi"].ToString());
                ekle.SubItems.Add(oku["Sinif"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void verilerikaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into Ogrenci (Id,AdSoyad,DogumYeri,AnneAdi,BabaAdi,Sinif) values ('" +textBox1.Text.ToString()+ "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            

        }
        private void verilerisil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Ogrenci where Id=("+ id + ")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void verileriduzenle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Ogrenci set Id= '"+textBox1.Text.ToString()+ "',AdSoyad = '"+ textBox2.Text.ToString() + "',DogumYeri = '" + textBox3.Text.ToString() + "',AnneAdi = '" + textBox4.Text.ToString() + "',BabaAdi = '" + textBox5.Text.ToString() + "',Sinif = '" + textBox6.Text.ToString() + "' where Id=" +id+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerikaydet();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verilerisil();
            
            verilerigoruntule();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verileriduzenle();
        }
    }
}
