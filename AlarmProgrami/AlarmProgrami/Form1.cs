using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgrami
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
          
            if (comboBox2.Text == labeldk.Text && comboBox1.Text == labelsa.Text )
            {
                
                axWindowsMediaPlayer1.URL = "C:\\Users\\hp\\Desktop\\Alarm.mp3";
                
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labeldk.Text = DateTime.Now.Minute.ToString();
            labelsa.Text = DateTime.Now.Hour.ToString();

            for (int i = 0; i <= 24; i++)
            {
                
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 0; i <= 60; i++)
            {
                
                comboBox2.Items.Add(i.ToString());
            }
           

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        



        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
