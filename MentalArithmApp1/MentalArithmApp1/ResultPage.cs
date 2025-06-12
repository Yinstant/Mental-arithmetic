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
        private Point lastPoint;
        public ResultPage()
        {
            InitializeComponent();

            if (Program.settings.ScreenSize == "Fixed")
            {
            }
            else if (Program.settings.ScreenSize == "Full")
            {
                this.MaximumSize = new Size();
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Program.settings.ScreenSize == "Adaptive")
            {
                this.MaximumSize = new Size();
            }

            if (Program.settings.isTopPanel)
            {
                if (Program.settings.ScreenSize != "Full") { 
                    labelResultPageClose.Hide();
                    labelResultPageHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            Statistics.SetTrainig(Program.training);


            Achievement achievement = new(Program.training.Mode);
            achievement.GetLevel();

            if (achievement.Level != "Diamond" && achievement.IsChanged()) {
                while (achievement.Level != "Diamond" && achievement.IsChanged()) {
                    achievement.IncreaseLevel();
                }
                achievement.SetLevel();

                DialogResult result = MessageBox.Show(
                    $"Вы получили достижение уровня {achievement.Level} в данном режиме! Перейти к достижениям?",
                    "Новое достижение!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );
            }

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
            SettingsPage settingsPage = new();
            settingsPage.ancestor = this;
            settingsPage.Show();
            this.Hide();
        }

        private void ResultPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void ResultPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelResultPageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
