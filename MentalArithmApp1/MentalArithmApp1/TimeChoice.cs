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
    public partial class TimeChoice : Form
    {
        private Point lastPoint;
        public TimeChoice()
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
                    labelTimeChoiceClose.Hide();
                    labelTimeChoiceHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }
        private void labelTimeChoiceHeading_Click(object sender, EventArgs e)
        {

        }
        private void TimeChoice_Load(object sender, EventArgs e)
        {

        }
        private void buttonTimeChoiceToBack_Click(object sender, EventArgs e)
        {
            ComplexityChoice complexityChoice = new ComplexityChoice();
            complexityChoice.Show();
            this.Hide();
        }
        private void buttonTimeChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
        private void buttonTimeChoiceNoTime_Click(object sender, EventArgs e)
        {
            Program.training.TimerTime = 0;
            TrainingPage trainingPage = new();
            trainingPage.Show();
            this.Hide();
        }
        private void buttonTimeChoiceOneMinute_Click(object sender, EventArgs e)
        {
            Program.training.TimerTime = 1;
            TimeIncrementChoice timeIncrementChoice = new();
            timeIncrementChoice.Show();
            this.Hide();
        }
        private void buttonTimeChoiceThreeMinute_Click(object sender, EventArgs e)
        {
            Program.training.TimerTime = 3;
            TimeIncrementChoice timeIncrementChoice = new();
            timeIncrementChoice.Show();
            this.Hide();
        }
        private void buttonTimeChoiceFiveMinute_Click(object sender, EventArgs e)
        {
            Program.training.TimerTime = 5;
            TimeIncrementChoice timeIncrementChoice = new();
            timeIncrementChoice.Show();
            this.Hide();
        }
        private void buttonTimeChoice15Minute_Click(object sender, EventArgs e)
        {
            Program.training.TimerTime = 15;
            TimeIncrementChoice timeIncrementChoice = new();
            timeIncrementChoice.Show();
            this.Hide();
        }

        private void TimeChoice_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void TimeChoice_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "opisanie_operatsij.htm");
        }

        private void TimeChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTimeChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void TimeChoice_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void TimeChoice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTimeChoiceClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
