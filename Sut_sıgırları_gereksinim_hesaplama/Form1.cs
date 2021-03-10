using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sut_sıgırları_gereksinim_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ca, caa, km, met, hp, kal, fos;
            ca = Convert.ToDouble(maskedTextBox1.Text);
            caa = Convert.ToDouble(maskedTextBox2.Text);
            

            // gereksinizmlerin formülize edilmesi;
            km = 1.09 + (0.017 * ca) + (0.0007 * caa);
            met = (0.04 * ca) + (0.0069 * caa) - 1.63;
            hp = (0.79 * ca) + (0.298 * caa) + 224.62;
            kal = (0.02 * caa) - (0.0035 * ca) + 11.9;
            fos = (0.022 * ca) + (0.0066 * caa) + 3.73;

            // formüllerin textboxlarda çözülüp görülmesi;
            textBox1.Text = km.ToString();
            textBox2.Text = met.ToString();
            textBox3.Text = hp.ToString();
            textBox4.Text = kal.ToString();
            textBox5.Text = fos.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Temizlendi");
            maskedTextBox1.Focus();

                
                
        }
    }
}
