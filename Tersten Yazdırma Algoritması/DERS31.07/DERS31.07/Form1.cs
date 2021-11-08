using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERS31._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            count = Convert.ToInt32(listBox1.Items.Count.ToString());
            label3.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = Convert.ToInt32(listBox1.Items.Count.ToString());
            label3.Text = count.ToString();

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = listBox1.SelectedItem.ToString();
            textBox2.Enabled = false;
            textBox2.Text=(Convert.ToInt32(listBox1.SelectedIndex.ToString())).ToString();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int numara = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(numara);
            listBox1.Items.Insert(numara, textBox3.Text);
 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string secili = textBox4.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString()== secili )
                {
                    listBox1.SelectedIndex = i;
                    break;
                }
                else
                {
                    listBox1.SelectedIndex = -1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] duzdizi = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                duzdizi[i] = listBox1.Items[i].ToString();
            }
            listBox1.Items.Clear();

            for (int i= duzdizi.Count()-1; i >= 0; i--)
            {
                listBox1.Items.Add(duzdizi[i].ToString());
            }
           

        }
    }
}
