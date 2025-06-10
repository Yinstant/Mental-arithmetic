using DataClasses;
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
    public partial class ResultPage : Form
    {
        public ResultPage()
        {
            InitializeComponent();
            
            Statistics.SetTrainig(Program.training);

            labelResultPageMode.Text = Program.training.ToString();

            labelResultPageCorrectCnt.Text = $"Решено {Program.training.CorrectSolved} примеров";
            labelResultPageIncorrectCnt.Text = $"Допущено {Program.training.IncorrectSolved} ошибок";

            labelResultPageAccuracy.Text = $"Точность {Program.training.Accuracy}%";

            progressBar1.Step = Program.training.Accuracy;
            progressBar1.PerformStep();

        }

        private void buttonResultPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonResultPageToModeChoice_Click(object sender, EventArgs e)
        {
            ModeChoice modeChoice = new();
            modeChoice.Show();
            this.Hide();
        }

        private void buttonResultPageToStatistics_Click(object sender, EventArgs e)
        {
            StatisticPage statisticPage = new();
            statisticPage.Show();
            this.Hide();
        }

        private void ResultPage_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void ResultPage_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "avarijnye_situatsii.htm");
        }

        private void ResultPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonResultPageSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
