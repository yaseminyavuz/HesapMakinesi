using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Toplama İşlemi için 
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = sayi1 + sayi2;
            textBox3.Text = sonuc.ToString();
            
        }
        //Çıkartma

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = sayi1 - sayi2;
            textBox3.Text = sonuc.ToString();

        }
        //Çarpma
        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();

        }
        //Bölme

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            if(sayi2 !=0)
            {
                double sonuc = sayi1 / sayi2;
                textBox3.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Sıfıra bölüm tanımsızdır.");
            }
           
        }
    }
}
