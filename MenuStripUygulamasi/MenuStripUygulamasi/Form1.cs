using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aksiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Esaretin Bedeli, Andy ve Red isimli iki mahkumun parmaklıklar ardında kurdukları dünyanın hikayesini anlatıyor";
        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bu Fransız komedisi bizi genç ve özel bir kadınla tanışmaya davet ediyor; her daim hayat dolu, yaşama sevgi dolu gözlerle tanıklık eden ve sahip olduğu özel ışıltıyı her anında yanında taşıyan Amelie'nin hikayesine.";
        }

        private void theNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sararmış bir not defterinden anlatılan ve yıllar önceden kopup gelen bir aşk hikâyesi. 40'lı yıllarda ABD, Kuzey Carolina'daki sahil kasabası Seabrook'a genç bir kız gelir. Ailesiyle geçireceği sakin bir yazı hayal eden Allie bir karnavalda tanıştığı Noah'la yakınlaşır.";
        }

        private void gladyatörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " General Maximus'un imparatorluk içerisinde yükselmesi karşısında kıskançlığa kapılan tahtın varisi Commodus, general ile ailesinin derhâl öldürülmesi emrini çıkarır. Ölümden zor kurtulan Maximus'u artık kölelik yaşamı beklemektedir. Arenaya gönderilerek orada bir gladyatör olarak eğitilir.";
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yüzük Kardeşliği, dünyanın kaderini değişterecek olan yüzükten kurtulmak için verilen mücadeleyi konu ediyor. Yıllar önce üretilen ve Orta Dünya topraklarına kandan başka hiçbir şey getirmeyen yüzüklerin sonuncusu, üretiminden yüz yıllar sonra ortaya çıkar.";
        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Filmde arkadaşlarının düğününden iki gün önce bekârlığa veda partisi vermek için Las Vegas'a giden dört tuhaf arkadaşın, sarhoş oldukları parti gecesinin sabahında odalarında bir kaplan, tavuklar ve dolapta ağlayan altı aylık bir bebek ile uyanmaları üzerine gelişen olağanüstü maceralar aktarılmaktadır.";
        }
    }
}
