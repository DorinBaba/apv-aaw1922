using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieEcuatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MyInitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Forma ecuatia gr. I: AX + B = C

            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Programul are nevoie de A, B si C pentru a-l calcula pe X");
            }

            try
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                int C = int.Parse(textBox3.Text);

                double X = (double)((double)(C - B) / A);
                textBox4.Text = $"{X:F2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus numere? :/");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}
