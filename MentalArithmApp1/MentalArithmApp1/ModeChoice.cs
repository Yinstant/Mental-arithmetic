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
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceSubtraction_Click(object sender, EventArgs e)
        {
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceMultiplication_Click(object sender, EventArgs e)
        {
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }

        private void buttonModeChoiceDivision_Click(object sender, EventArgs e)
        {
            ComplexityChoice complexityChoice = new();
            complexityChoice.Show();
            this.Hide();
        }
    }
}
