using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(label7.Text);
            sayac++;
            label7.Text = sayac.ToString();
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;
            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            if (pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left> pictureBox3.Left+5)
            {
                label6.Text = "1.at önde gidiyor";
            }
            if (pictureBox2.Left > pictureBox1.Left+5 && pictureBox2.Left> pictureBox3.Left + 5)
            {
                label6.Text = "2.at önde gidiyor";
            }
            if(pictureBox3.Left > pictureBox1.Left + 5 &&  pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3.at önde gidiyor";
            }
            if (birinciatingenisligi+pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text=("1 numaralı at yarışı kazandı");
                
                
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("2 numaralı at yarışı kazandı");
               

            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("3 numaralı at yarışı kazandı");
         
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }
    }
}
