using System.Drawing.Text;
namespace MentalArithmApp1
{
    public partial class MainMenu : Form
    {
        private Point lastPoint;
        public MainMenu()
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
                    labelMainMenuClose.Hide();
                    labelMainMenuHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void buttonMainMenuStart_Click(object sender, EventArgs e)
        {
            ModeChoice modeChoice = new ModeChoice();
            modeChoice.Show();
            this.Hide();
        }

        private void buttonMainMenuTextbook_Click(object sender, EventArgs e)
        {
            TextbookChoice textbookChoice = new();
            textbookChoice.Show();
            this.Hide();
        }

        private void buttonMainMenuStatistics_Click(object sender, EventArgs e)
        {
            StatisticPage statisticPage = new();
            statisticPage.Show();
            this.Hide();
        }

        private void buttonMainMenuSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.ancestor = this;
            settingsPage.Show();
            this.Hide();
        }

        private void MainMenu_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void MainMenu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "rekomendatsii_po_osvoeniyu.htm");
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMainMenuStart_MouseEnter(object sender, EventArgs e)
        {

        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelMainMenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMainMenuAchievements_Click(object sender, EventArgs e)
        {
            AchievementsPage achievementsPage = new();
            achievementsPage.Show();
            this.Hide();
        }
    }
}
