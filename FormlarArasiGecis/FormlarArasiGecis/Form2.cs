using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiGecis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Beyaz")
            {
                label2.Text = "Beyaz saflığın, yeni başlangıçların ve barışın rengidir. Bozulmamış, değerini kaybetmemiş ve kutsal sayılan kavramlar beyaz renkle temsil edilir. ..";
                this.BackColor = Color.White;
            }
            else if (comboBox1.Text == "Mavi")
            {
                label2.Text = "Mavi renk huzurun, barışın rengidir. Güven verici ve sakinleştirici etkisi vardır. Sonsuzluğu ve özgürlüğü ifade eder.";
                this.BackColor = Color.Blue;
            }
            else if (comboBox1.Text == "Kırmızı")
            {
                label2.Text = "Kırmızı, sıcak, ateş, aşk, samimiyet, güç, heyecan ve agresifliği temsil etmektedir. Kan basıncını artırırken solunumu hızlandırabilir";
                this.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "Pembe")
            {
                label2.Text = "Pembe, sabah güneşinin rengi, dişi duyguların ifadesidir. Yaşam dolu, mükemmel ve enerji veren bir renktir. Sağlıklı olmanın ve daima genç kalmanın ifadesi olarak da tanımlanabilir. ";
                this.BackColor = Color.Pink;
            }
        }

       
    }
}
