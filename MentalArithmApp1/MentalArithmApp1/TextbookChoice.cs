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
    public partial class TextbookChoice : Form
    {
        public TextbookChoice()
        {
            InitializeComponent();
        }

        private void buttonTextbookChoiceToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceAddition_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(1, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceSubtraction_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(2, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceMultiplication_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(3, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookChoiceDivision_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(4, 1);
            textbookPage.Show();
            this.Hide();
        }

        private void TextbookChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTextbookChoiceSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }
    }
}
