using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[] { 1, 5, 4, 10, 8, 2 };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            for (int i = 0; i < dizi.Length; i++)
            {
                int buyuk;
                for (int j = i+1; j < dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        buyuk = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = buyuk;
                        
                    }

                }
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < dizi.Length; i++)
            {
                int kucuk;
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        kucuk = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = kucuk;

                    }

                }
                listBox1.Items.Add(dizi[i]);
            }

        }
    }
}
