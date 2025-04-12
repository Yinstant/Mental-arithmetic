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
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }
        private void buttonComplexityChoiceMedium_Click(object sender, EventArgs e)
        {
            TimeChoice timeChoice = new();
            timeChoice.Show();
            this.Hide();
        }

        private void buttonComplexityChoiceHard_Click(object sender, EventArgs e)
        {
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
    }
}
