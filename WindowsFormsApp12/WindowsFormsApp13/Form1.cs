using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV = 0.18, OTV = 0.45;
            double Ham_Fiyat = 0, KDV_Tutari = 0, OTV_Tutari = 0, Toplam_Fiyat = 0;
            Ham_Fiyat = Convert.ToDouble(textBox1.Text);
            OTV_Tutari = Ham_Fiyat * OTV;
            KDV_Tutari = (Ham_Fiyat + OTV_Tutari) * KDV;
            Toplam_Fiyat = Ham_Fiyat + OTV_Tutari + KDV_Tutari;
            textBox3.Text = Convert.ToString(OTV_Tutari);
            textBox2.Text = Convert.ToString(KDV_Tutari);
            textBox4.Text = Convert.ToString(Toplam_Fiyat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
