﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LogInForm form = new LogInForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("done");
            }
        }
    }
}
