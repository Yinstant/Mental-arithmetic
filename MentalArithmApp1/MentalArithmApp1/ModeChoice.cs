﻿using System;
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
        public ModeChoice()
        {
            Program.training = new DataClasses.Training();
            InitializeComponent();
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
            settingsPage.Show();
            this.Hide();
        }
    }
}
