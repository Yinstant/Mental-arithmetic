using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalArithmApp1
{
    public partial class TextbookChoice : Form
    {
        private Point lastPoint;
        public TextbookChoice()
        {
            InitializeComponent();

            if (Program.settings.ScreenSize == "Fixed")
            {
            }
            else if (Program.settings.ScreenSize == "Full")
            {
                this.MaximumSize = new Size();
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Program.settings.ScreenSize == "Adaptive")
            {
                this.MaximumSize = new Size();
            }

            if (Program.settings.isTopPanel)
            {
                if (Program.settings.ScreenSize != "Full") { 
                    labelTextbookChoiceClose.Hide();
                    labelTextbookChoiceHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void buttonTextbookChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceAddition_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(1, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceSubtraction_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(2, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceMultiplication_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(3, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceDivision_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(4, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void TextbookChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTextbookChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.ancestor = this;
            settingsPage.Show();
            this.Hide();
        }

        private void TextbookChoice_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void TextbookChoice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTextbookChoiceClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
