using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // Width & Height Variables 
        int left;
        int top;

        // Bool Variable to check Control Key Value
        bool controlKeyPressed;

        // Graphic Class to Paint Rectangle
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            // Set Width & Height
            left = (Screen.PrimaryScreen.Bounds.Width - 300) / 2;
            top = (Screen.PrimaryScreen.Bounds.Height - 300) / 2;
            Location = new Point(left, top);
            this.Width = 500;
        }

        // Paint Rectangle 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 30, 20, this.Width - 90, this.Height - 100);
        }


        // Mouse Move Handler
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format($"x = {e.X}, y = {e.Y}");
        }

        // Mouse Value Handler  Handler 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;

            // If Left Mouse Button === True 
            if (e.Button == MouseButtons.Left)
            {
                // Click Inside Border 
                if (e.Y < this.Height - 90 && e.Y > 30 && e.X - 30 < this.Width - 100 && e.X - 20 > 20)
                {
                    frm.Text = String.Format($"Inside");
                }

                // Click Outside Border
                else if (e.Y - 20 > this.Height - 90 || e.Y < 15 || e.X - 50 > this.Width - 100 || e.X < 20)
                {
                    frm.Text = String.Format($"Outside");
                }

                // Click On Border
                else
                {
                    frm.Text = String.Format($"In Rectangle Border");
                }
            }

            // If ControlKey & Left Mouse Button Click 
            if (e.Button == MouseButtons.Left && controlKeyPressed)
            {
                Application.Exit();
            }

            // Right Mouse Button Handler
            if (e.Button == MouseButtons.Right)
            {
                frm.Text = String.Format($"Width = {this.Width}, Height = {this.Height}");
            }
        }

        // KeyDown ControlKey Handler 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                controlKeyPressed = true;
            }
        }

        // KeyUp ControlKey Handler 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Control)
            {
                controlKeyPressed = false;
            }
        }
    }
}
