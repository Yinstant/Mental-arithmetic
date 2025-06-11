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
    public partial class ComplexityChoice : Form
    {
        private Point lastPoint;
        public ComplexityChoice()
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
                    labelComplexityChoiceClose.Hide();
                    labelComplexityChoiceHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void buttonComplexityChoiceEasy_Click(object sender, EventArgs e)
        {
            Program.training.Complexity = 1;
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }
        private void buttonComplexityChoiceMedium_Click(object sender, EventArgs e)
        {
            Program.training.Complexity = 2;
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }

        private void buttonComplexityChoiceHard_Click(object sender, EventArgs e)
        {
            Program.training.Complexity = 3;
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }

        private void buttonComplexityChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonComplexityChoiceToBack_Click(object sender, EventArgs e)
        {
            ModeChoice modeChoice = new();
            modeChoice.Show();
            this.Hide();
        }

        private void ComplexityChoice_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void ComplexityChoice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "opisanie_operatsij.htm");
        }

        private void ComplexityChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonComplexityChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void ComplexityChoice_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void ComplexityChoice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelComplexityChoiceClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
