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
            labelStatisticPageCorrectGeneral.Text = statistics.correctCountGeneral.ToString();
            labelStatisticPageCorrectAdd.Text = statistics.correctCountAdd.ToString();
            labelStatisticPageCorrectSub.Text = statistics.correctCountSub.ToString();
            labelStatisticPageCorrectMult.Text = statistics.correctCountMult.ToString();
            labelStatisticPageCorrectDiv.Text = statistics.correctCountDiv.ToString();

            labelStatisticPageCountGeneral.Text = statistics.trainingCountGeneral.ToString();
            labelStatisticPageCountAdd.Text = statistics.trainingCountAdd.ToString();
            labelStatisticPageCountSub.Text = statistics.trainingCountSub.ToString();
            labelStatisticPageCountMult.Text = statistics.trainingCountMult.ToString();
            labelStatisticPageCountDiv.Text = statistics.trainingCountDiv.ToString();

            labelStatisticPageMistakeGeneral.Text = statistics.incorrectCountGeneral.ToString();
            labelStatisticPageMistakeAdd.Text = statistics.incorrectCountAdd.ToString();
            labelStatisticPageMistakeSub.Text = statistics.incorrectCountSub.ToString();
            labelStatisticPageMistakeMult.Text = statistics.incorrectCountMult.ToString();
            labelStatisticPageMistakeDiv.Text = statistics.incorrectCountDiv.ToString();
        }
    }
}
