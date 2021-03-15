using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rezultat = "";

            if (checkBox1.Checked)
                rezultat += "Optiune1\n";

            if (checkBox2.Checked)
                rezultat += "Optiune2\n";

            if (checkBox3.Checked)
                rezultat += "Optiune3\n";

            MessageBox.Show(rezultat);
        }
    }
}
