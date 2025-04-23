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
        public TimeChoice()
        {
            InitializeComponent();
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
            TrainingPage trainingPage = new TrainingPage();
            trainingPage.Show();
            this.Hide();
        }
        private void buttonTimeChoiceOneMinute_Click(object sender, EventArgs e)
        {
            TrainingPage trainingPage = new TrainingPage();
            trainingPage.Show();
            this.Hide();
        }
        private void buttonTimeChoiceThreeMinute_Click(object sender, EventArgs e)
        {
            TrainingPage trainingPage = new TrainingPage();
            trainingPage.Show();
            this.Hide();
        }
        private void buttonTimeChoiceFiveMinute_Click(object sender, EventArgs e)
        {
            TrainingPage trainingPage = new TrainingPage();
            trainingPage.Show();
            this.Hide();
        }
        private void buttonTimeChoice15Minute_Click(object sender, EventArgs e)
        {
            TrainingPage trainingPage = new TrainingPage();
            trainingPage.Show();
            this.Hide();
        }
    }
}
