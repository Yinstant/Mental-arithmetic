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
            labelStatisticPageCorrectGeneral.Text = $"Всего правильно решённых: {statistics.correctCountGeneral.ToString()}";
            labelStatisticPageCorrectAdd.Text = $"На сложение: {statistics.correctCountAdd.ToString()}";
            labelStatisticPageCorrectSub.Text = $"На вычитание: {statistics.correctCountSub.ToString()}";
            labelStatisticPageCorrectMult.Text = $"На умножение: {statistics.correctCountMult.ToString()}";
            labelStatisticPageCorrectDiv.Text = $"На деление: {statistics.correctCountDiv.ToString()}";

            labelStatisticPageCountGeneral.Text = $"Всего тренировок было: {statistics.trainingCountGeneral.ToString()}";
            labelStatisticPageCountAdd.Text = $"На сложение: {statistics.trainingCountAdd.ToString()}";
            labelStatisticPageCountSub.Text = $"На вычитание: {statistics.trainingCountSub.ToString()}";
            labelStatisticPageCountMult.Text = $"На умножение: {statistics.trainingCountMult.ToString()}";
            labelStatisticPageCountDiv.Text = $"На деление: {statistics.trainingCountDiv.ToString()}";

            labelStatisticPageMistakeGeneral.Text = $"Всего ошибок было: {statistics.incorrectCountGeneral.ToString()}";
            labelStatisticPageMistakeAdd.Text = $"На сложение: {statistics.incorrectCountAdd.ToString()}";
            labelStatisticPageMistakeSub.Text = $"На вычитание: {statistics.incorrectCountSub.ToString()}";
            labelStatisticPageMistakeMult.Text = $"На умножение: {statistics.incorrectCountMult.ToString()}";
            labelStatisticPageMistakeDiv.Text = $"На деление: {statistics.incorrectCountDiv.ToString()}";
        }

        private void buttonStatisticPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }
    }
}
