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
    public partial class TimeIncrementChoice : Form
    {
        public TimeIncrementChoice()
        {
            InitializeComponent();
        }

        private void buttonTimeIncrementChoice0sec_Click(object sender, EventArgs e)
        {
            Program.training.IncrementTime = 0;
            TrainingPage trainingPage = new();
            trainingPage.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoice1sec_Click(object sender, EventArgs e)
        {
            Program.training.IncrementTime = 1;
            TrainingPage trainingPage = new();
            trainingPage.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoice3sec_Click(object sender, EventArgs e)
        {
            Program.training.IncrementTime = 3;
            TrainingPage trainingPage = new();
            trainingPage.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoice5sec_Click(object sender, EventArgs e)
        {
            Program.training.IncrementTime = 5;
            TrainingPage trainingPage = new();
            trainingPage.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoiceToBack_Click(object sender, EventArgs e)
        {
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }

        private void buttonTimeIncrementChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void TimeIncrementChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
