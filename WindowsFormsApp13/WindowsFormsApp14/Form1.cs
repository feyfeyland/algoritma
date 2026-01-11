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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="OPEL")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] opelModeller = { "Corsa", "Crossland", "Grandland" };
                comboBox2.Items.AddRange(opelModeller);
            }
            else if(comboBox1.Text=="RENAULT")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] renaultModeller = { "Taliant", "Clio", "Captur" };
                comboBox2.Items.AddRange(renaultModeller);
            }
            else if (comboBox1.Text == "BMW")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                string[] bmwModeller = { "İX", "İ7", "İ4" };
                comboBox2.Items.AddRange(bmwModeller);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("OPEL");
            //comboBox1.Items.Add("RENAULT");
            //comboBox1.Items.Add("BMW");

            string[] markalar = { "OPEL", "RENAULT", "BMW" };
            comboBox1.Items.AddRange(markalar);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Corsa")
            {
                comboBox3.Items.Clear();
                string[] corsaVersiyon = { "Edition", "Elegance", "Ultimate" };
                comboBox3.Items.AddRange(corsaVersiyon);
            }
            else if(comboBox2.Text=="Crossland")
            {
                comboBox3.Items.Clear();
                string[] crosslandVersiyon = { "Essential", "Edition", "Elegance" };
                comboBox3.Items.AddRange(crosslandVersiyon);
            }
            else if (comboBox2.Text == "Grandland")
            {
                comboBox3.Items.Clear();
                string[] grandlandVersiyon = {"Ultimate", "Elegance" };
                comboBox3.Items.AddRange(grandlandVersiyon);
            }

            //

            else if (comboBox2.Text == "Taliant")
            {
                comboBox3.Items.Clear();
                string[] taliantVersiyon = {"Joy", "Touch" };
                comboBox3.Items.AddRange(taliantVersiyon);
            }
            else if (comboBox2.Text == "Clio")
            {
                comboBox3.Items.Clear();
                string[] clioVersiyon = { "Joy", "Touch", "Icon" };
                comboBox3.Items.AddRange(clioVersiyon);
            }
            else if (comboBox2.Text == "Captur")
            {
                comboBox3.Items.Clear();
                string[] capturVersiyon = { "Touch+", "Icon","r.s. line" };
                comboBox3.Items.AddRange(capturVersiyon);
            }


            //

            else if (comboBox2.Text == "İX")
            {
                comboBox3.Items.Clear();
                string[] ixVersiyon = { "First Edition Essence", "First Edition Sport"};
                comboBox3.Items.AddRange(ixVersiyon);
            }
            else if (comboBox2.Text == "İ7")
            {
                comboBox3.Items.Clear();
                string[] i7Versiyon = { "Pure Excellence", "M Excellence"};
                comboBox3.Items.AddRange(i7Versiyon);
            }
            else if (comboBox2.Text == "İ4")
            {
                comboBox3.Items.Clear();
                string[] i4Versiyon = { "eDrive40-M Sport", "M50" };
                comboBox3.Items.AddRange(i4Versiyon);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Marka: " + comboBox1.Text + " | " + "Model: " + comboBox2.Text + " | " + "Versiyon: " + comboBox3.Text);
        }
    }
}
