using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplul4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAutentificare_Click(object sender, EventArgs e)
        {
            if(tbNume.Text.Length < 9 || tbParola.Text.Length < 9)
            {
                MessageBox.Show("Date invalide");
                return;
            }

            MessageBox.Show("Success");
        }
    }
}
