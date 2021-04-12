using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTrimite_Click(object sender, EventArgs e)
        {
            string sportulPreferat;
            string hobby;
            string descriere;
            string gen;
            string stareCivila;

            sportulPreferat = tbSport.Text;
            hobby = tbHobby.Text;
            descriere = rtbDescriere.Text;

            gen = (rbMasculin.Checked)
                ? rbMasculin.Text
                : (rbFeminin.Checked)
                    ? rbFeminin.Text
                    : "??";

            //if (rbMasculin.Checked)
            //    gen = rbMasculin.Text;
            //else
            //    if (rbFeminin.Checked)
            //    gen = rbFeminin.Text;
            //else
            //    gen = "??";

            stareCivila = (rbCasatorit.Checked) ? rbCasatorit.Text : rbNecasatorit.Text;

            MessageBox.Show("Datele culese din formular: \n" +
                $"Sportul preferat: {sportulPreferat}\n" +
                $"Hobby: {hobby}\n" +
                $"Descriere ca persoana: {descriere}\n" +
                $"Genul: {gen}\n" +
                $"Starea civila: {stareCivila}");
        }
    }
}
