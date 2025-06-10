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
    public partial class StatisticPage : Form
    {
        public StatisticPage()
        {
            InitializeComponent();

            Statistics statistics = new();
            statistics.Get();
            labelStatisticPageCorrectGeneral.Text = $"Количество решённых: {statistics.correctCountGeneral.ToString()}";
            labelStatisticPageCorrectAdd.Text = statistics.correctCountAdd.ToString();
            labelStatisticPageCorrectSub.Text = statistics.correctCountSub.ToString();
            labelStatisticPageCorrectMult.Text = statistics.correctCountMult.ToString();
            labelStatisticPageCorrectDiv.Text = statistics.correctCountDiv.ToString();

            labelStatisticPageCountGeneral.Text = $"Всего тренировок: {statistics.trainingCountGeneral.ToString()}";
            labelStatisticPageCountAdd.Text = statistics.trainingCountAdd.ToString();
            labelStatisticPageCountSub.Text = statistics.trainingCountSub.ToString();
            labelStatisticPageCountMult.Text = statistics.trainingCountMult.ToString();
            labelStatisticPageCountDiv.Text = statistics.trainingCountDiv.ToString();

            labelStatisticPageMistakeGeneral.Text = $"Количество ошибок: {statistics.incorrectCountGeneral.ToString()}";
            labelStatisticPageMistakeAdd.Text = statistics.incorrectCountAdd.ToString();
            labelStatisticPageMistakeSub.Text = statistics.incorrectCountSub.ToString();
            labelStatisticPageMistakeMult.Text = statistics.incorrectCountMult.ToString();
            labelStatisticPageMistakeDiv.Text = statistics.incorrectCountDiv.ToString();

            labelStatisticPageAccuracyGeneral.Text = $"Текущая точность: {statistics.incorrectCountGeneral.ToString()}%";
            labelStatisticPageAccuracyAdd.Text = $"{statistics.accuracyAdd.ToString()}%";
            labelStatisticPageAccuracySub.Text = $"{statistics.accuracySub.ToString()}%";
            labelStatisticPageAccuracyMult.Text = $"{statistics.accuracyMult.ToString()}%";
            labelStatisticPageAccuracyDiv.Text = $"{statistics.accuracyDiv.ToString()}%";
        }

        private void buttonStatisticPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void StatisticPage_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void StatisticPage_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "avarijnye_situatsii.htm");
        }

        private void StatisticPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonStatisticPageSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void buttonStatisticPageDelete_Click(object sender, EventArgs e)
        {
            Statistics.DeleteStat();
            StatisticPage statisticPage = new();
            statisticPage.Show();
            this.Hide();
        }
    }
}
