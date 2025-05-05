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
        Time time = new Time(Program.training);
        MathTask task;
        public TrainingPage()
        {
            Program.training.Reset();
            InitializeComponent();
            // 
            // timerTrainingPage
            // 
            if (Program.training.TimerTime != 0)
            {
                timerTrainingPage.Enabled = true;
                timerTrainingPage.Interval = 1000;
                timerTrainingPage.Tick += timerTrainingPage_Tick;
            }
            else {
                labelTrainingPageTime.Text = "--:--";
            }

            task = new(Program.training.Complexity, Program.training.Mode);
            labelTrainingPageExample.Text = task.ToString();
        }

        private void buttonTrainingPageTo_Click(object sender, EventArgs e)
        {

        }
        private void buttonTrainingPageToTimeChoice_Click(object sender, EventArgs e)
        {
            TimeChoice timeChoice = new TimeChoice();
            timeChoice.Show();
            this.Hide();
        }
        private void buttonTrainingPageEnd_Click(object sender, EventArgs e)
        {
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
                string buf = textBoxTrainingPage.Text;
                int attempt;
                bool IsNum = int.TryParse(buf, out attempt);

                textBoxTrainingPage.Text = "";
                if (IsNum)
                {
                    if (task.IsRight(attempt))
                    {
                        labelTrainingPageReaction.Text = "Правильно!";
                        labelTrainingPageReaction.ForeColor = Color.Green;
                        Program.training.IfCorrect();
                        task = new(Program.training.Complexity, Program.training.Mode);
                        labelTrainingPageExample.Text = task.ToString();
                    }
                    else {
                        labelTrainingPageReaction.Text = "Неверно!";
                        labelTrainingPageReaction.ForeColor = Color.Red;
                        Program.training.IfIncorrect();
                    }
                }
                else {
                    labelTrainingPageReaction.Text = "Введите число!";
                    labelTrainingPageReaction.ForeColor = Color.Orange;
                }
            }
        }
    }
}
