using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina2
{
    public partial class Form1 : Form
    {
        double[,] RateleDeConversie = new double[4,4];

        readonly int MDL = 0;
        readonly int EUR = 1;
        readonly int USD = 2;
        readonly int RON = 3;

        public Form1()
        {
            InitializeComponent();

            RateleDeConversie[MDL, MDL] = 1;
            RateleDeConversie[MDL, EUR] = 0.05;
            RateleDeConversie[MDL, USD] = 0.06;
            RateleDeConversie[MDL, RON] = 0.23;

            RateleDeConversie[EUR, MDL] = 20;
            RateleDeConversie[EUR, EUR] = 1;
            RateleDeConversie[EUR, USD] = 1.18;
            RateleDeConversie[EUR, RON] = 4.91;

            RateleDeConversie[USD, MDL] = 18.07;
            RateleDeConversie[USD, EUR] = 0.85;
            RateleDeConversie[USD, USD] = 1;
            RateleDeConversie[USD, RON] = 4.17;

            RateleDeConversie[RON, MDL] = 4.33;
            RateleDeConversie[RON, EUR] = 0.2;
            RateleDeConversie[RON, USD] = 0.24;
            RateleDeConversie[RON, RON] = 1;

            List<object> valute1 = new List<object>() { "MDL", "EUR", "USD", "RON" };
            List<object> valute2 = new List<object>() { "MDL", "EUR", "USD", "RON" };
            cmbInitial.DataSource = valute1;
            cmbFinal.DataSource = valute2;
        }

        private void btConvertire_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Extragem valoarea
                // 2. Extragem valuta initiala
                // 3. Extragem valuta finala
                // 4. Afisam rezultatul final

                // 1.
                double valoareInitiala = double.Parse(tbInitial.Text);

                // 2.
                int valutaInitiala = cmbInitial.SelectedIndex;

                // 3. 
                int valutaFinala = cmbFinal.SelectedIndex;

                // 4.
                tbFinal.Text = (valoareInitiala * RateleDeConversie[valutaInitiala, valutaFinala]).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Asigurati-va ca ati introdus valori valide.");
            }
        }
    }
}
