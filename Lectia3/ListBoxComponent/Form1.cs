using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> optiuni = new List<string>()
            {
                "Chisinau",
                "Cahul",
                "Leova",
                "Comrat",
                "Ialoveni",
                "Orhei",
                "Soroca",
            };

            listBox1.DataSource = optiuni;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
