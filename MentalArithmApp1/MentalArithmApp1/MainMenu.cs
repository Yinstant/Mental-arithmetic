namespace MentalArithmApp1
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMainMenuStart_Click(object sender, EventArgs e)
        {
            ModeChoice modeChoice = new ModeChoice();
            modeChoice.Show();
            this.Hide();
        }

        private void buttonMainMenuTextbook_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMainMenuStatistics_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMainMenuManual_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMainMenuSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
