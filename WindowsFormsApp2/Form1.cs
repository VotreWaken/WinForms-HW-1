using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Dialog Manage Variable for Program Behavior
            DialogResult result = MyMessageBox.Show("Press OK to Show Resume", "Resume Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Resume Fields Variables 
            string resumeName = "Name: Egor";
            string resumeLanguages = "Programming languages: С++, С#, Javascript (React)";
            string resumeStudying = "Studying at: ItStep";
            string resumeBye = "Thank you for your attention";

            // If Pressed OK
            if (result == DialogResult.OK)
            {
                MyMessageBox.Show("Pressed OK, Show Resume", "Show Resume Window");
                MyMessageBox.Show(resumeName, "Name Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyMessageBox.Show(resumeLanguages, "Languages Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyMessageBox.Show(resumeStudying, "Studying Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyMessageBox.Show(resumeBye, "Resume Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MyMessageBox.Show($"{(double)MyMessageBox.getCharCount() / MyMessageBox.getCount()}", "win");
            }
            // If Pressed Cancel
            else
            {
                MyMessageBox.Show("Pressed Cancel, Bye", "Bye Window");
                Application.Exit();
            }
        }
        // MessageBox Class Wrapper whos contain Static Counter Variable & Character Count Variable
        class MyMessageBox
        {
            private static int counter;
            private static int charCounter;

            public static int getCount()
            {
                return counter;
            }

            public static int getCharCount()
            {
                return charCounter;
            }
            public static DialogResult Show(string msg)
            {
                counter++;
                charCounter += msg.Length;
                return MessageBox.Show(msg);
            }
            public static DialogResult Show(string msg, string winName)
            {
                counter++;
                charCounter += msg.Length;
                return MessageBox.Show(msg, winName);
            }

            public static DialogResult Show(string msg, string winName, MessageBoxButtons buttons)
            {
                counter++;
                charCounter += msg.Length;
                return MessageBox.Show(msg, winName, buttons);
            }

            public static DialogResult Show(string msg, string winName, MessageBoxButtons buttons, MessageBoxIcon Icons)
            {
                counter++;
                charCounter += msg.Length;
                return MessageBox.Show(msg, winName, buttons, Icons);
            }
        }
    }
}
