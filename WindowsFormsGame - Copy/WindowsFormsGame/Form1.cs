using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public bool left;
        public bool right;
        public bool jump;
        public int jumps;
        public int maxHeight = 60;
        public int currentHeight = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (left == false)
                    {
                        TurnLeft();
                        left = true;
                        right = false;
                    }
                    break;
                case Keys.Right:
                    if (right == false)
                    {
                        TurnRight();
                        left = false;
                        right = true;
                    }
                    break;
                case Keys.Space:
                    if (jumps < 2)
                    {
                        jump = true;
                        jumps++;
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
            }
        }

        bool lookingRight = false;
        public void TurnRight()
        {
            if (!lookingRight)
            {
                Image img = player.Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                player.Image = img;
                lookingRight = true;
            }
        }

        public void TurnLeft()
        {
            if (lookingRight)
            {
                Image img = player.Image;
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
                player.Image = img;
                lookingRight = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bool onGround = false;
            if (left)
                player.Left -= 2;

            if (right)
                player.Left += 2;

            if (jump)
            {
                player.Top -= 5;
                currentHeight += 5;

                if (currentHeight > maxHeight)
                {
                    currentHeight = 0;
                    onGround = false;
                    jump = false;
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "ground" && !jump)
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        if (player.Top + player.Height <= control.Top + 5)
                        {
                            onGround = true;
                            jumps = 0;
                        }
                    }
                }
            }


            if (!onGround && !jump)
                player.Top += 3;
        }



        bool enemyRight = true;
        bool enemy1Right = true;
        bool enemy2Right = true;


        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "ground")
                {
                    if (enemy.Top + enemy.Height == control.Top)
                    {
                        if (enemy.Left + enemy.Width / 2 < control.Left || enemy.Left + enemy.Width / 2 > control.Left + control.Width)
                            enemyRight = !enemyRight;
                    }
                }
            }

            if (enemyRight)
                enemy.Left += 1;
            else
                enemy.Left -= 1;

            if (enemy1Right)
                enemy1.Left += 1;
            else
                enemy1.Left -= 1;

            if (enemy2Right)
                enemy2.Left += 1;
            else
                enemy2.Left -= 1;
        }
    }
}
