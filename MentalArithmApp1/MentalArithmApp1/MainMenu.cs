namespace MentalArithmApp1
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
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

        private void buttonMainMenuManual_Click(object sender, EventArgs e)
        {

        }

        private void buttonMainMenuSettings_Click(object sender, EventArgs e)
        {

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
    }
}
