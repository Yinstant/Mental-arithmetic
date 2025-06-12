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
    public partial class ModeChoice : Form
    {
        private Point lastPoint;
        public ModeChoice()
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
                    labelModeChoiceClose.Hide();
                    labelModeChoiceHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void buttonModeChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonModeChoiceAddition_Click(object sender, EventArgs e)
        {
            Program.training.Mode = 1;
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceSubtraction_Click(object sender, EventArgs e)
        {
            Program.training.Mode = 2;
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceMultiplication_Click(object sender, EventArgs e)
        {
            Program.training.Mode = 3;
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceDivision_Click(object sender, EventArgs e)
        {
            Program.training.Mode = 4;
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void ModeChoice_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void ModeChoice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "opisanie_operatsij.htm");
        }

        private void ModeChoice_Load(object sender, EventArgs e)
        {

        }

        private void ModeChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonModeChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.ancestor = this;
            settingsPage.Show();
            this.Hide();
        }

        private void ModeChoice_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void ModeChoice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelModeChoiceClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
