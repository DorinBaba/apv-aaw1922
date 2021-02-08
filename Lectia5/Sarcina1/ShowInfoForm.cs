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
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm(string info)
        {
            InitializeComponent();

            lbInfo.Text = info;
        }
    }
}
