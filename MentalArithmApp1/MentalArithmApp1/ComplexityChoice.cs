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
        public ComplexityChoice()
        {
            InitializeComponent();
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
    }
}
