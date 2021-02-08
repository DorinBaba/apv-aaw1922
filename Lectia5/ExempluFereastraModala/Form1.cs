using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempluFereastraModala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cream o instanta a clasei ModalForm (Fereastra recent creată)
            ModalForm modalForm = new ModalForm();

            // Afișăm fereastra modală
            modalForm.ShowDialog();
        }
    }
}
