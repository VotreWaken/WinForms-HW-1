using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DialogResult result = MessageBox.Show("Start The Guess?", "Guess Window", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                StartGuess();
            }
        }

        static void StartGuess()
        {
            // Management Variable
            int i = 0;

            // Main Loop
            while (i < 2000)
            {
                // Main Guess Window
                DialogResult guess = MessageBox.Show($"The Number Is {i}", "Guess Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // If Catch Yes Dialog Result
                if (guess == DialogResult.Yes)
                {
                    // Show Guess Count 
                    MessageBox.Show($"Guess Count {i}");

                    // Start Again Window 
                    DialogResult startAgain = MessageBox.Show("Start Again?", "Start Again Window", MessageBoxButtons.YesNo);

                    // If Catch Yes Dialog Result in Start Again Window
                    if (startAgain == DialogResult.Yes)
                    {
                        i = 0;
                        continue;
                    }

                    // Else Return
                    else
                    {
                        return;
                    }
                }

                // If Catch Cancel Dialog Result in Main Window
                else if (guess == DialogResult.Cancel)
                {
                    return;
                }

                // Catch Other Application Behavior And Exit
                else
                {
                    Application.Exit();
                }
                i++;
            }
        }

    }
}
