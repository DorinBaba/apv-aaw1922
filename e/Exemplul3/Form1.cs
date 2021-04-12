using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CentreazaImaginea();
            
        }

        private void btMareste_Click(object sender, EventArgs e)
        {
            // 1: Mareste lungimea
            // 2: Mareste latimea
            // 3: Pozitioneaza imaginea in centrul ferestrei
            picture.Width += 5;
            picture.Height += 5;
            CentreazaImaginea();
        }

        private void btMicsoreaza_Click(object sender, EventArgs e)
        {
            picture.Width -= 5;
            picture.Height -= 5;
            CentreazaImaginea();
        }

        private void CentreazaImaginea()
        {
            picture.Left = Width / 2 - picture.Width / 2;
            picture.Top = Height / 2 - picture.Height/ 2;
        }

        private void btSus_Click(object sender, EventArgs e)
        {
            picture.Top -= 5;
        }

        private void btCentru_Click(object sender, EventArgs e)
        {
            CentreazaImaginea();
        }

        private void btJos_Click(object sender, EventArgs e)
        {
            picture.Top += 5;
        }
    }
}
