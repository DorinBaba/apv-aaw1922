using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarciina3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();

            if(logInForm.ShowDialog() == DialogResult.OK)
            {
                label2.Text = $"Username: {logInForm.tbUsername.Text} \n";
                label2.Text += $"Pasword: {logInForm.tbPassword.Text}";
            }
        }
    }
}
