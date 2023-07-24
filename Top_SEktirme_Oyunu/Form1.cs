using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Top_SEktirme_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_BASLA_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        int topy = 1;
        int sayi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi<=20) 
            {
                top.Top += topy;
                if (top.Top >= 140) 
                {
                    topy *= -2;

                }
                else if (top.Top<=100)
                {
                    topy *= -2;

                }
                if (top.Top ==140) 
                {
                    sayi++;
                    textBox2.Text=sayi.ToString();
                }
            }
            else
            {
                timer1.Stop();
                textBox2.Text = sayi.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox2.Text =(sayi.ToString()+" kere sektirildi.") ;
            textBox2.Visible = true;
            MessageBox.Show("Şimdi Sonuçları Karşılaştırrr");
           
        }

        private void top_Click(object sender, EventArgs e)
        {

        }
    }
}
