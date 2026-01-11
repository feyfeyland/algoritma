using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1: Form
    {
        private int rastgeleSayi;
        private int tahminSayisi;
        private int puan;

        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rastgeleSayi = rnd.Next(0, 101); 
            tahminSayisi = 0;
            puan = 1000;

            textBox1.Enabled = true;
            button2.Enabled = true;
            textBox1.Text = "";
            label5.Text = "Tahmin giriniz...";
            label6.Text = "0";
            label7.Text = puan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                return;
            }

            int tahmin = Convert.ToInt32(textBox1.Text);

            tahminSayisi++;
            label6.Text = tahminSayisi.ToString();

            if (tahmin == rastgeleSayi)
            {
                label5.Text = "Tebrikler! Doğru tahmin.";
                textBox1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                puan -= 100;
                label7.Text = puan.ToString();

                if (tahmin < rastgeleSayi)
                    label5.Text = "Daha büyük bir sayı girin.";
                else
                    label5.Text = "Daha küçük bir sayı girin.";

                if (tahminSayisi >= 10)
                {
                    label5.Text = $"Oyun bitti! Doğru sayı: {rastgeleSayi}";
                    textBox1.Enabled = false;
                    button2.Enabled = false;
                }
            }

            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
