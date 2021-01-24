using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouthCalendarComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Preluam data selectata de catre utilizator
            var dataSelectata = monthCalendar1.SelectionRange.Start;

            // Cream data calendaristica a revelionului din anul pe care l-a selectat utilizatorul
            var dataRevelion = DateTime.Parse($"12/31/{dataSelectata.Year}");

            // Calculam cate zile au ramas
            var zileRamase = (dataRevelion - dataSelectata).Days;

            label1.Text = $"{zileRamase} zile ramase pana la revelion";
        }
    }
}
