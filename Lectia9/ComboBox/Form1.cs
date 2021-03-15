using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOperatia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operatie = cmbOperatia.SelectedItem.ToString();

            try
            {
                switch (operatie)
                {
                    case "+":
                        rezultat.Text = (double.Parse(numar1.Text) + double.Parse(numar2.Text)).ToString();
                        break;
                    case "-":
                        rezultat.Text = (double.Parse(numar1.Text) - double.Parse(numar2.Text)).ToString();
                        break;
                    case "*":
                        rezultat.Text = (double.Parse(numar1.Text) * double.Parse(numar2.Text)).ToString();
                        break;
                    case "/":
                        rezultat.Text = (double.Parse(numar1.Text) / double.Parse(numar2.Text)).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ati introdus numere invalide");
            }
        }
    }
}
