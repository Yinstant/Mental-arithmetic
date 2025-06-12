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
    public partial class AchievementsPage : Form
    {
        public AchievementsPage()
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
                if (Program.settings.ScreenSize != "Full")
                {
                    labelAchievementsPageClose.Hide();
                    labelAchievementsPageHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            Achievement achievementAdd = new(1);
            Achievement achievementSub = new(2);
            Achievement achievementMult = new(3);
            Achievement achievementDiv = new(4);

            achievementAdd.GetLevel();
            achievementSub.GetLevel();
            achievementMult.GetLevel();
            achievementDiv.GetLevel();

            pictureBoxAdd.Image = achievementAdd.GetIcon();
            pictureBoxSub.Image = achievementSub.GetIcon();
            pictureBoxMult.Image = achievementMult.GetIcon();
            pictureBoxDiv.Image = achievementDiv.GetIcon();

            progressBarAdd.Step = achievementAdd.Progress;
            progressBarSub.Step = achievementSub.Progress;
            progressBarMult.Step = achievementMult.Progress;
            progressBarDiv.Step = achievementDiv.Progress;

            progressBarAdd.PerformStep();
            progressBarSub.PerformStep();
            progressBarMult.PerformStep();
            progressBarDiv.PerformStep();

            labelAchievementsPageAddLeft.Text = achievementAdd.LeftPoint.ToString();
            labelAchievementsPageSubLeft.Text = achievementSub.LeftPoint.ToString();
            labelAchievementsPageMultLeft.Text = achievementMult.LeftPoint.ToString();
            labelAchievementsPageDivLeft.Text = achievementDiv.LeftPoint.ToString();

            labelAchievementsPageAddRight.Text = achievementAdd.RightPoint.ToString();
            labelAchievementsPageSubRight.Text = achievementSub.RightPoint.ToString();
            labelAchievementsPageMultRight.Text = achievementMult.RightPoint.ToString();
            labelAchievementsPageDivRight.Text = achievementDiv.RightPoint.ToString();

            labelAchievementsPageAdd.Text = $"Сложение. Решённых: {achievementAdd.CorrectCount}";
            labelAchievementsPageSub.Text = $"Вычитание. Решённых: {achievementSub.CorrectCount}";
            labelAchievementsPageMult.Text = $"Умножение. Решённых: {achievementMult.CorrectCount}";
            labelAchievementsPageDiv.Text = $"Деление. Решённых: {achievementDiv.CorrectCount}";
        }

        private void labelAchievementsPageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAchievementsPageSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void buttonAchievementsPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }
    }
}
