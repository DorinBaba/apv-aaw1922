using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeheBoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Problema 1>
            // Doresc sa ma deplasez printre textbox-uri utilizand tasta tab.
            // La moment, daca selectez cu mouse-ul textbox-ul din stanga, la apasarea tastei TAB
            // este focusat butonul de extragere, iar mai apoi - textbox-ul din dreapta.
            
            // Doresc ca TAB-ul sa ma directioneze de la textbox-ul din stanga catre textbox-ul din dreapta, iar mai apoi - 
            // catre buton

            
            // Problema 2>
            // Doresc ca butonul de extragere sa fie mereu lipit de margina de jos a ferestrei.
            // Pentru a face acest lucru am setat proprietatea Dock cu valoarea Buttom.
            // Totusi, butonul nu este lipit de margina de jos a ferestrei, puteti sa va convingeti de acest lucru
            // prin a da la executie programul si a redimensiona fereastra. Veti vedea ca butonul sta chill
            // acolo unde are el chef si nu se deplaseaza dupa margina de jos.
            
            // Ajuta-ma sa andochez de marginea de jos a ferestrei butonul de extragere ;)
        }

        private void btExtrage_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbDela.Text, out int min) && int.TryParse(tbMax.Text, out int max))
            {
                try
                {
                    lbNumar.Text = RandomNumberBetween(min, max).ToString();
                }
                catch (Exception)
                {
                    lbNumar.Text = "???";
                }
            }
        }

        private int RandomNumberBetween(int minValue, int maxValue) => (new Random()).Next(minValue, maxValue);

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
