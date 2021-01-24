using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbFont.Items.Add("Verdana");
            cbFont.Items.Add("Times New Roman");
            cbFont.Items.Add("Consolas");
            cbFont.Items.Add("Courier New");

            for (int i = 2; i <= 100; i+=2)
                cbSize.Items.Add(i);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(cbFont.SelectedItem.ToString(), richTextBox1.Font.Size);
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (int)cbSize.SelectedItem);
        }
    }
}
