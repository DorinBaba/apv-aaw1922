using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAfiseazaOra_Click(object sender, EventArgs e)
        {
            string ora = $"Este ora {DateTime.Now.ToString("hh:mm")}";
            ShowInfoForm showInfoForm = new ShowInfoForm(ora);

            // Afisam fereastra in mod obisnuit
            showInfoForm.Show();
        }

        private void btAfiseazaData_Click(object sender, EventArgs e)
        {
            string data = $"Este data de {DateTime.Now.ToString("dd/MM/yyyy")}";
            ShowInfoForm showInfoForm = new ShowInfoForm(data);

            // Afisam fereastra modal
            showInfoForm.ShowDialog();
        }
    }
}
