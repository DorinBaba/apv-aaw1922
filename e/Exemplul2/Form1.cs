using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 360, 100, 130, 130);
        }

        private void btCalculeaza_Click(object sender, EventArgs e)
        {
            try
            {
                double latura = double.Parse(tbLatura.Text);

                lbAria.Text = $"Aria: {latura * latura:f2}";
                lbPerimetru.Text = $"Perimetru: {4*latura:f2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Nu.");
            }
        }
    }
}
