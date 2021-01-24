using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonComponent
{
    public partial class Form1 : Form
    {
        ParticipantFormular participant = new ParticipantFormular();
        public Form1()
        {
            InitializeComponent();
        }

        private void rbGen_CheckedChanged(object sender, EventArgs e)
        {
            participant.Genul = (sender as RadioButton).Text;
        }

        private void rbStareCivila_CheckedChanged(object sender, EventArgs e)
        {
            participant.StareaCivila = (sender as RadioButton).Text;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            participant.Nume = tbNumePrenume.Text;

            MessageBox.Show($"Participant: {participant.Nume} \n" +
                $"Genul: {participant.Genul}\n" +
                $"Starea Civila: {participant.StareaCivila}");
        }
    }
}
