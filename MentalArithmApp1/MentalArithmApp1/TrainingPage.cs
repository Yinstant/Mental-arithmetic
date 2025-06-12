using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataClasses;

namespace MentalArithmApp1
{
    public partial class TrainingPage : Form
    {
        private Point lastPoint;

        Time time = new Time(Program.training);
        MathTask task;
        public TrainingPage()
        {
            Program.training.Reset();
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
                    labelTrainingPageClose.Hide();
                    labelTrainingPageHelp.Hide();
                }
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            // 
            // timerTrainingPage
            // 
            if (Program.training.TimerTime != 0)
            {
                timerTrainingPage.Enabled = true;
                timerTrainingPage.Interval = 1000;
                timerTrainingPage.Tick += timerTrainingPage_Tick;
            }
            else
            {
                labelTrainingPageTime.Text = "--:--";
            }

            task = new(Program.training.Complexity, Program.training.Mode);
            labelTrainingPageExample.Text = task.ToString();
        }
        private void buttonTrainingPageToTimeIncrementChoice_Click(object sender, EventArgs e)
        {
            timerTrainingPage.Stop();
            if (Program.training.TimerTime == 0)
            {
                TimeChoice timeChoice = new();
                timeChoice.Show();
            }
            else
            {
                TimeIncrementChoice timeIncrementChoice = new();
                timeIncrementChoice.Show();
            }
            this.Hide();
        }
        private void buttonTrainingPageEnd_Click(object sender, EventArgs e)
        {
            timerTrainingPage.Stop();
            ResultPage resultPage = new ResultPage();
            resultPage.Show();
            this.Hide();
        }

        private void timerTrainingPage_Tick(object sender, EventArgs e)
        {
            labelTrainingPageTime.Text = time.ToString();
            time.Decrement();
            if (time.IsTimeEnd())
            {
                timerTrainingPage.Stop();
                ResultPage resultPage = new ResultPage();
                resultPage.Show();
                this.Hide();
            }
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string buf = textBoxTrainingPage.Text;
                int attempt;
                bool IsNum = int.TryParse(buf, out attempt);

                textBoxTrainingPage.Text = "";
                if (IsNum)
                {
                    if (task.IsRight(attempt))
                    {
                        time.Increment(Program.training.IncrementTime);

                        labelTrainingPageReaction.Text = "Правильно!";
                        labelTrainingPageReaction.ForeColor = Color.Green;

                        Program.training.IfCorrect();

                        task = new(Program.training.Complexity, Program.training.Mode);
                        labelTrainingPageExample.Text = task.ToString();
                    }
                    else
                    {
                        labelTrainingPageReaction.Text = "Неверно!";
                        labelTrainingPageReaction.ForeColor = Color.Red;
                        Program.training.IfIncorrect();
                    }
                }
                else
                {
                    labelTrainingPageReaction.Text = "Введите число!";
                    labelTrainingPageReaction.ForeColor = Color.Orange;
                }
            }
        }

        private void TrainingPage_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm");
        }

        private void TrainingPage_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Руководство_пользователя.chm", HelpNavigator.Topic, "avarijnye_situatsii.htm");
        }

        private void TrainingPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTrainingPageSettings_Click(object sender, EventArgs e)
        {
            timerTrainingPage.Stop();
            SettingsPage settingsPage = new();
            settingsPage.ancestor = this;
            settingsPage.Show();
            this.Hide();
        }

        private void TrainingPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new(e.X, e.Y);
        }

        private void TrainingPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTrainingPageClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
