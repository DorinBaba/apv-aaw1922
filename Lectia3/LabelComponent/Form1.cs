using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int valoareContor = 0;

        private void btDecrement_Click(object sender, EventArgs e)
        {
            valoareContor--;
            lblContor.Text = $"Contor: {valoareContor}";
        }

        private void btIncrement_Click(object sender, EventArgs e)
        {
            valoareContor++;
            lblContor.Text = $"Contor: {valoareContor}";
        }
    }
}
