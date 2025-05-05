namespace MentalArithmApp1
{
    partial class ResultPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultPage));
            labelResultPageCorrectCnt = new Label();
            labelResultPageIncorrectCnt = new Label();
            labelResultPageHeading = new Label();
            buttonResultPageToMenu = new Button();
            buttonResultPageToModeChoice = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultPageCorrectCnt
            // 
            labelResultPageCorrectCnt.AutoSize = true;
            labelResultPageCorrectCnt.BackColor = Color.FromArgb(192, 255, 192);
            labelResultPageCorrectCnt.FlatStyle = FlatStyle.Flat;
            labelResultPageCorrectCnt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelResultPageCorrectCnt.ForeColor = Color.Green;
            labelResultPageCorrectCnt.Location = new Point(48, 47);
            labelResultPageCorrectCnt.Name = "labelResultPageCorrectCnt";
            labelResultPageCorrectCnt.Size = new Size(719, 46);
            labelResultPageCorrectCnt.TabIndex = 1;
            labelResultPageCorrectCnt.Text = "Количество верно решённых примеров: _";
            // 
            // labelResultPageIncorrectCnt
            // 
            labelResultPageIncorrectCnt.AutoSize = true;
            labelResultPageIncorrectCnt.BackColor = Color.FromArgb(192, 255, 192);
            labelResultPageIncorrectCnt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelResultPageIncorrectCnt.ForeColor = Color.Red;
            labelResultPageIncorrectCnt.Location = new Point(48, 144);
            labelResultPageIncorrectCnt.Name = "labelResultPageIncorrectCnt";
            labelResultPageIncorrectCnt.Size = new Size(758, 46);
            labelResultPageIncorrectCnt.TabIndex = 2;
            labelResultPageIncorrectCnt.Text = "Количество неверно решённых примеров: _";
            // 
            // labelResultPageHeading
            // 
            labelResultPageHeading.AutoSize = true;
            labelResultPageHeading.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelResultPageHeading.ForeColor = Color.Crimson;
            labelResultPageHeading.Location = new Point(288, 77);
            labelResultPageHeading.Name = "labelResultPageHeading";
            labelResultPageHeading.Size = new Size(520, 57);
            labelResultPageHeading.TabIndex = 3;
            labelResultPageHeading.Text = "Тренировка завершена!";
            // 
            // buttonResultPageToMenu
            // 
            buttonResultPageToMenu.FlatAppearance.BorderSize = 0;
            buttonResultPageToMenu.FlatStyle = FlatStyle.Flat;
            buttonResultPageToMenu.Image = (Image)resources.GetObject("buttonResultPageToMenu.Image");
            buttonResultPageToMenu.Location = new Point(184, 457);
            buttonResultPageToMenu.Name = "buttonResultPageToMenu";
            buttonResultPageToMenu.Size = new Size(171, 132);
            buttonResultPageToMenu.TabIndex = 4;
            buttonResultPageToMenu.Text = "Вернуться в меню";
            buttonResultPageToMenu.UseVisualStyleBackColor = true;
            buttonResultPageToMenu.Click += buttonResultPageToMenu_Click;
            // 
            // buttonResultPageToModeChoice
            // 
            buttonResultPageToModeChoice.FlatAppearance.BorderSize = 0;
            buttonResultPageToModeChoice.FlatStyle = FlatStyle.Flat;
            buttonResultPageToModeChoice.Image = (Image)resources.GetObject("buttonResultPageToModeChoice.Image");
            buttonResultPageToModeChoice.Location = new Point(637, 457);
            buttonResultPageToModeChoice.Name = "buttonResultPageToModeChoice";
            buttonResultPageToModeChoice.Size = new Size(171, 132);
            buttonResultPageToModeChoice.TabIndex = 5;
            buttonResultPageToModeChoice.Text = "Вернуться к выбору режима";
            buttonResultPageToModeChoice.UseVisualStyleBackColor = true;
            buttonResultPageToModeChoice.Click += buttonResultPageToModeChoice_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(labelResultPageCorrectCnt);
            panel1.Controls.Add(labelResultPageIncorrectCnt);
            panel1.Location = new Point(94, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 246);
            panel1.TabIndex = 0;
            // 
            // ResultPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonResultPageToModeChoice);
            Controls.Add(buttonResultPageToMenu);
            Controls.Add(labelResultPageHeading);
            Controls.Add(panel1);
            Name = "ResultPage";
            Text = "ResultPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultPageCorrectCnt;
        private Label labelResultPageIncorrectCnt;
        private Label labelResultPageHeading;
        private Button buttonResultPageToMenu;
        private Button buttonResultPageToModeChoice;
        private Panel panel1;
    }
}