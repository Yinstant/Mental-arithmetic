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
        public TrainingPage()
        {
            InitializeComponent();
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
    }
}
