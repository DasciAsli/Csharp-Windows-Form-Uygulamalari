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

namespace Örnek_Kayit_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ASLI\\SQLEXPRESS;Initial Catalog=kayitlar;Integrated Security=True");
        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from gelenler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void verileriKaydet()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into gelenler(AdSoyad,Firma) Values('" + textBox1.Text.ToString()+ "','" + textBox2.Text.ToString() + "')" , baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileriKaydet();
        }
    }
}
