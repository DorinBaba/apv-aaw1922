using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplu01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Lectia2";

            Label lbUsername = new Label();
            lbUsername.Text = "Username";
            lbUsername.Location = new Point(80, 100);
            lbUsername.Size = new Size(240, 20);
            Controls.Add(lbUsername);

            TextBox tbUsername = new TextBox();
            tbUsername.Location = new Point(80, 130);
            tbUsername.Size = new Size(240, 20);
            tbUsername.Focus();
            Controls.Add(tbUsername);

            Label lbPassword = new Label();
            lbPassword.Text = "Password";
            lbPassword.Location = new Point(80, 170);
            lbPassword.Size = new Size(240, 20);
            Controls.Add(lbPassword);

            TextBox tbPassword = new TextBox();
            tbPassword.Location = new Point(80, 200);
            tbPassword.PasswordChar = '☻';
            tbPassword.Size = new Size(240, 20);
            Controls.Add(tbPassword);

            Button btLogIn = new Button();
            btLogIn.Dock = DockStyle.Bottom;
            btLogIn.Text = "Log In";
            btLogIn.Height = 40;
            Controls.Add(btLogIn);
        }

    }
}
