using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();

            if (sayi % 60 == 0)
            {
                label1.Text ="0"; 
                int sayi2 = Convert.ToInt32(label2.Text);
                sayi2++;
                label2.Text = sayi2.ToString();
                if (sayi2 % 60 == 0)
                {
                    label2.Text = "0";
                    int sayi3 = Convert.ToInt32(label3.Text);
                    sayi3++;
                    label3.Text = sayi3.ToString();

                }


            }

 
            //interval değerini özelliklerden 1000 yapman gerek.interval milisaniye olarak ölçmekte 1000 yaparsan normal saniye değerinde hareket eder.5000 yaparsan 5 saniyede bir değişir.
        }
    }
}
