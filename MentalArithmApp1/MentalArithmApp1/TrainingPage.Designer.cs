namespace MentalArithmApp1
{
    partial class TrainingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingPage));
            buttonTrainingPageToTimeChoice = new Button();
            buttonTrainingPageEnd = new Button();
            buttonTrainingPageSettings = new Button();
            labelTrainingPageTime = new Label();
            textBoxTrainingPage = new TextBox();
            labelTrainingPageExample = new Label();
            SuspendLayout();
            // 
            // buttonTrainingPageToTimeChoice
            // 
            buttonTrainingPageToTimeChoice.Click += buttonTrainingPageToTimeChoice_Click;
            buttonTrainingPageToTimeChoice.FlatAppearance.BorderSize = 0;
            buttonTrainingPageToTimeChoice.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageToTimeChoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonTrainingPageToTimeChoice.Image = (Image)resources.GetObject("buttonTrainingPageToTimeChoice.Image");
            buttonTrainingPageToTimeChoice.Location = new Point(61, 501);
            buttonTrainingPageToTimeChoice.Name = "buttonTrainingPageToTimeChoice";
            buttonTrainingPageToTimeChoice.Size = new Size(177, 129);
            buttonTrainingPageToTimeChoice.TabIndex = 0;
            buttonTrainingPageToTimeChoice.Text = "Вернуться к выбору режима";
            buttonTrainingPageToTimeChoice.UseVisualStyleBackColor = true;
            buttonTrainingPageToTimeChoice.Click += buttonTrainingPageTo_Click;
            // 
            // buttonTrainingPageEnd
            // 
            buttonTrainingPageEnd.FlatAppearance.BorderSize = 0;
            buttonTrainingPageEnd.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonTrainingPageEnd.Image = (Image)resources.GetObject("buttonTrainingPageEnd.Image");
            buttonTrainingPageEnd.Location = new Point(833, 508);
            buttonTrainingPageEnd.Name = "buttonTrainingPageEnd";
            buttonTrainingPageEnd.Size = new Size(177, 115);
            buttonTrainingPageEnd.TabIndex = 1;
            buttonTrainingPageEnd.Text = "Закончить досрочно";
            buttonTrainingPageEnd.UseVisualStyleBackColor = true;
            // 
            // buttonTrainingPageSettings
            // 
            buttonTrainingPageSettings.FlatAppearance.BorderSize = 0;
            buttonTrainingPageSettings.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageSettings.Image = (Image)resources.GetObject("buttonTrainingPageSettings.Image");
            buttonTrainingPageSettings.Location = new Point(928, 35);
            buttonTrainingPageSettings.Name = "buttonTrainingPageSettings";
            buttonTrainingPageSettings.Size = new Size(119, 91);
            buttonTrainingPageSettings.TabIndex = 2;
            buttonTrainingPageSettings.UseVisualStyleBackColor = true;
            // 
            // labelTrainingPageTime
            // 
            labelTrainingPageTime.AutoSize = true;
            labelTrainingPageTime.Image = (Image)resources.GetObject("labelTrainingPageTime.Image");
            labelTrainingPageTime.Location = new Point(100, 9);
            labelTrainingPageTime.Name = "labelTrainingPageTime";
            labelTrainingPageTime.Padding = new Padding(120);
            labelTrainingPageTime.Size = new Size(240, 260);
            labelTrainingPageTime.TabIndex = 3;
            // 
            // textBoxTrainingPage
            // 
            textBoxTrainingPage.Font = new Font("Segoe UI", 25F);
            textBoxTrainingPage.Location = new Point(306, 413);
            textBoxTrainingPage.Name = "textBoxTrainingPage";
            textBoxTrainingPage.Size = new Size(500, 63);
            textBoxTrainingPage.TabIndex = 4;
            // 
            // labelTrainingPageExample
            // 
            labelTrainingPageExample.AutoSize = true;
            labelTrainingPageExample.ForeColor = Color.Red;
            labelTrainingPageExample.Location = new Point(447, 258);
            labelTrainingPageExample.Name = "labelTrainingPageExample";
            labelTrainingPageExample.Padding = new Padding(100, 50, 50, 50);
            labelTrainingPageExample.Size = new Size(216, 120);
            labelTrainingPageExample.TabIndex = 5;
            labelTrainingPageExample.Text = "Пример";
            // 
            // TrainingPage
            // 
            buttonTrainingPageEnd.Click += buttonTrainingPageEnd_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelTrainingPageExample);
            Controls.Add(textBoxTrainingPage);
            Controls.Add(labelTrainingPageTime);
            Controls.Add(buttonTrainingPageSettings);
            Controls.Add(buttonTrainingPageEnd);
            Controls.Add(buttonTrainingPageToTimeChoice);
            Name = "TrainingPage";
            Text = "TrainingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTrainingPageToTimeChoice;
        private Button buttonTrainingPageEnd;
        private Button buttonTrainingPageSettings;
        private Label labelTrainingPageTime;
        private TextBox textBoxTrainingPage;
        private Label labelTrainingPageExample;
    }
}