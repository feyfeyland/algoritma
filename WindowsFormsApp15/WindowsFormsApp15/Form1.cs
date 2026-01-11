using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> sayilar = new List<int>();
            List<int> tahmin = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                sayilar.Add(i);
            }
            for (int x = 1; x <= 6; x++)
            {

                int index = rnd.Next(0, sayilar.Count);
                tahmin.Add(sayilar[index]);
                sayilar.RemoveAt(index);
            }
            tahmin.Sort();
            label1.Text = tahmin[0].ToString();
            label2.Text = tahmin[1].ToString();
            label3.Text = tahmin[2].ToString();
            label4.Text = tahmin[3].ToString();
            label5.Text = tahmin[4].ToString();
            label6.Text = tahmin[5].ToString();
        }
    }
}
