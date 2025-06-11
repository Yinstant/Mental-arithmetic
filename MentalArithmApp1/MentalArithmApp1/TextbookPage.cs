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
    public partial class TextbookPage : Form
    {
        private Point lastPoint;
        int Mode, PageNum;
        public TextbookPage(int mode, int pageNum)
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
                    labelTextbookPageClose.Hide();
                    labelTextbookPageHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            Mode = mode;
            PageNum = pageNum;

            string modePath;

            if (mode == 1)
                modePath = "Addition";
            else if (mode == 2)
                modePath = "Substraction";
            else if (mode == 3)
                modePath = "Multiplication";
            else
                modePath = "Division";

            string dir = Directory.GetCurrentDirectory();

            for (int i = 0; i < 5; i++)
                dir = Directory.GetParent(dir).FullName;
            string path = $"{dir}\\Textbook\\{modePath}\\page{pageNum}.png";

            try
            {
                pictureBoxTextbookPage.BackgroundImage = Image.FromFile(path);
            }
            catch
            {
                throw new Exception($"Не найден файл {path}!");
            }

            if (pageNum != 1)
                buttonTextbookPageToBack.Visible = true;
            if (pageNum != Directory.GetFiles($"{dir}\\Textbook\\{modePath}").Length)
                buttonTextbookPageToNext.Visible = true;
        }

        private void buttonTextbookPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonTextbookPageToNext_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(Mode, PageNum + 1);
            textbookPage.Show();
            this.Hide();
        }

        private void buttonTextbookPageToBack_Click(object sender, EventArgs e)
        {
            TextbookPage textbookPage = new(Mode, PageNum - 1);
            textbookPage.Show();
            this.Hide();
        }

        private void TextbookPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTextbookPageSettings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void buttonTextbookPageToChoice_Click(object sender, EventArgs e)
        {
            TextbookChoice textbookChoice = new();
            textbookChoice.Show();
            this.Hide();
        }

        private void TextbookPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TextbookPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void labelTextbookPageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
