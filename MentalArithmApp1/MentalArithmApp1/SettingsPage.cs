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
    public partial class SettingsPage : Form
    {
        public Form ancestor;
        private Point lastPoint;
        public SettingsPage()
        {
            InitializeComponent();

            if (Program.settings.ScreenSize == "Fixed")
            {
                radioButtonScreenSizeFixed.Checked = true;
            }
            else if (Program.settings.ScreenSize == "Full")
            {
                radioButtonScreenSizeFull.Checked = true;
                this.MaximumSize = new Size();
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else if (Program.settings.ScreenSize == "Adaptive")
            {
                radioButtonScreenSizeAdaptive.Checked = true;
                this.MaximumSize = new Size();
            }

            if (Program.settings.isTopPanel)
            {
                radioButtonTopPanelYes.Checked = true;
                if (Program.settings.ScreenSize != "Full")
                {
                    labelSettingsPageClose.Hide();
                    labelSettingsPageHelp.Hide();
                }
            }
            else
            {
                radioButtonTopPanelNo.Checked = true;
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void SettingsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettingsPageToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            this.Hide();
        }

        private void buttonSettingsSet_Click(object sender, EventArgs e)
        {
            if (radioButtonScreenSizeFixed.Checked)
            {
                Program.settings.ScreenSize = "Fixed";
            }
            else if (radioButtonScreenSizeFull.Checked)
            {
                Program.settings.ScreenSize = "Full";
            }
            else if (radioButtonScreenSizeAdaptive.Checked)
            {
                Program.settings.ScreenSize = "Adaptive";
            }

            if (radioButtonTopPanelYes.Checked)
            {
                Program.settings.isTopPanel = true;
            }
            else
            {
                Program.settings.isTopPanel = false;
            }

            Program.settings.Set();

            SettingsPage settingsPage = new();
            settingsPage.Show();
            this.Hide();
        }

        private void labelSettingsPageHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void SettingsPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void SettingsPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelSettingsPageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettingsPageToBack_Click(object sender, EventArgs e)
        {
            if (ancestor is TrainingPage)
                ((TrainingPage)ancestor).timerTrainingPage.Start();
            ancestor.Show();
            this.Hide();
        }
    }
}
