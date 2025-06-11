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
            panelResultPage = new Panel();
            progressBar1 = new ProgressBar();
            labelResultPageAccuracy = new Label();
            labelResultPageMode = new Label();
            buttonResultPageToStatistics = new Button();
            buttonResultPageSettings = new Button();
            labelResultPageClose = new Label();
            labelResultPageHelp = new Label();
            panelResultPage.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultPageCorrectCnt
            // 
            labelResultPageCorrectCnt.BackColor = Color.Transparent;
            labelResultPageCorrectCnt.FlatStyle = FlatStyle.Flat;
            labelResultPageCorrectCnt.Font = new Font("Cascadia Code", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelResultPageCorrectCnt.ForeColor = Color.Green;
            labelResultPageCorrectCnt.Location = new Point(98, 235);
            labelResultPageCorrectCnt.Name = "labelResultPageCorrectCnt";
            labelResultPageCorrectCnt.Size = new Size(526, 46);
            labelResultPageCorrectCnt.TabIndex = 1;
            labelResultPageCorrectCnt.Text = "Решено примеров";
            labelResultPageCorrectCnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResultPageIncorrectCnt
            // 
            labelResultPageIncorrectCnt.BackColor = Color.Transparent;
            labelResultPageIncorrectCnt.Font = new Font("Cascadia Code", 35F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelResultPageIncorrectCnt.ForeColor = Color.Red;
            labelResultPageIncorrectCnt.Location = new Point(82, 292);
            labelResultPageIncorrectCnt.Name = "labelResultPageIncorrectCnt";
            labelResultPageIncorrectCnt.Size = new Size(566, 46);
            labelResultPageIncorrectCnt.TabIndex = 2;
            labelResultPageIncorrectCnt.Text = "Допущено ошибок";
            labelResultPageIncorrectCnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResultPageHeading
            // 
            labelResultPageHeading.AutoSize = true;
            labelResultPageHeading.BackColor = Color.Transparent;
            labelResultPageHeading.Font = new Font("Arial Black", 25F);
            labelResultPageHeading.ForeColor = Color.FromArgb(255, 0, 98);
            labelResultPageHeading.Location = new Point(274, 43);
            labelResultPageHeading.Name = "labelResultPageHeading";
            labelResultPageHeading.Size = new Size(600, 59);
            labelResultPageHeading.TabIndex = 3;
            labelResultPageHeading.Text = "Тренировка завершена!";
            // 
            // buttonResultPageToMenu
            // 
            buttonResultPageToMenu.BackColor = Color.Transparent;
            buttonResultPageToMenu.FlatAppearance.BorderSize = 0;
            buttonResultPageToMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonResultPageToMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonResultPageToMenu.FlatStyle = FlatStyle.Flat;
            buttonResultPageToMenu.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonResultPageToMenu.ForeColor = Color.FromArgb(106, 37, 0);
            buttonResultPageToMenu.Image = (Image)resources.GetObject("buttonResultPageToMenu.Image");
            buttonResultPageToMenu.Location = new Point(779, 485);
            buttonResultPageToMenu.Name = "buttonResultPageToMenu";
            buttonResultPageToMenu.Size = new Size(214, 127);
            buttonResultPageToMenu.TabIndex = 4;
            buttonResultPageToMenu.Text = "Вернуться в меню";
            buttonResultPageToMenu.UseVisualStyleBackColor = false;
            buttonResultPageToMenu.Click += buttonResultPageToMenu_Click;
            // 
            // buttonResultPageToModeChoice
            // 
            buttonResultPageToModeChoice.BackColor = Color.Transparent;
            buttonResultPageToModeChoice.FlatAppearance.BorderSize = 0;
            buttonResultPageToModeChoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonResultPageToModeChoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonResultPageToModeChoice.FlatStyle = FlatStyle.Flat;
            buttonResultPageToModeChoice.Font = new Font("Cascadia Code", 22F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonResultPageToModeChoice.ForeColor = Color.FromArgb(106, 37, 0);
            buttonResultPageToModeChoice.Image = (Image)resources.GetObject("buttonResultPageToModeChoice.Image");
            buttonResultPageToModeChoice.Location = new Point(94, 489);
            buttonResultPageToModeChoice.Name = "buttonResultPageToModeChoice";
            buttonResultPageToModeChoice.Size = new Size(212, 119);
            buttonResultPageToModeChoice.TabIndex = 5;
            buttonResultPageToModeChoice.Text = "Вернуться к выбору режима";
            buttonResultPageToModeChoice.UseVisualStyleBackColor = false;
            buttonResultPageToModeChoice.Click += buttonResultPageToModeChoice_Click;
            // 
            // panelResultPage
            // 
            panelResultPage.BackColor = Color.Transparent;
            panelResultPage.BackgroundImage = (Image)resources.GetObject("panelResultPage.BackgroundImage");
            panelResultPage.BackgroundImageLayout = ImageLayout.Center;
            panelResultPage.Controls.Add(progressBar1);
            panelResultPage.Controls.Add(labelResultPageAccuracy);
            panelResultPage.Controls.Add(labelResultPageMode);
            panelResultPage.Controls.Add(labelResultPageCorrectCnt);
            panelResultPage.Controls.Add(labelResultPageIncorrectCnt);
            panelResultPage.Location = new Point(192, 105);
            panelResultPage.Name = "panelResultPage";
            panelResultPage.Size = new Size(707, 374);
            panelResultPage.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.BackColor = Color.Red;
            progressBar1.Location = new Point(82, 145);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(542, 61);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // labelResultPageAccuracy
            // 
            labelResultPageAccuracy.Font = new Font("Cascadia Code", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelResultPageAccuracy.ForeColor = Color.FromArgb(255, 0, 204);
            labelResultPageAccuracy.Location = new Point(171, 73);
            labelResultPageAccuracy.Name = "labelResultPageAccuracy";
            labelResultPageAccuracy.Size = new Size(370, 59);
            labelResultPageAccuracy.TabIndex = 4;
            labelResultPageAccuracy.Text = "Точность %";
            labelResultPageAccuracy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelResultPageMode
            // 
            labelResultPageMode.Font = new Font("Arial Black", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelResultPageMode.ForeColor = Color.FromArgb(147, 15, 255);
            labelResultPageMode.Location = new Point(43, 29);
            labelResultPageMode.Name = "labelResultPageMode";
            labelResultPageMode.Size = new Size(623, 44);
            labelResultPageMode.TabIndex = 3;
            labelResultPageMode.Text = "Режим тренировки";
            labelResultPageMode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonResultPageToStatistics
            // 
            buttonResultPageToStatistics.BackColor = Color.Transparent;
            buttonResultPageToStatistics.FlatAppearance.BorderSize = 0;
            buttonResultPageToStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonResultPageToStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonResultPageToStatistics.FlatStyle = FlatStyle.Flat;
            buttonResultPageToStatistics.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonResultPageToStatistics.ForeColor = Color.FromArgb(106, 37, 0);
            buttonResultPageToStatistics.Image = (Image)resources.GetObject("buttonResultPageToStatistics.Image");
            buttonResultPageToStatistics.Location = new Point(436, 489);
            buttonResultPageToStatistics.Name = "buttonResultPageToStatistics";
            buttonResultPageToStatistics.Size = new Size(221, 118);
            buttonResultPageToStatistics.TabIndex = 6;
            buttonResultPageToStatistics.Text = "Общая статистика";
            buttonResultPageToStatistics.UseVisualStyleBackColor = false;
            buttonResultPageToStatistics.Click += buttonResultPageToStatistics_Click;
            // 
            // buttonResultPageSettings
            // 
            buttonResultPageSettings.BackColor = Color.Transparent;
            buttonResultPageSettings.FlatAppearance.BorderSize = 0;
            buttonResultPageSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonResultPageSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonResultPageSettings.FlatStyle = FlatStyle.Flat;
            buttonResultPageSettings.Image = (Image)resources.GetObject("buttonResultPageSettings.Image");
            buttonResultPageSettings.Location = new Point(28, 12);
            buttonResultPageSettings.Name = "buttonResultPageSettings";
            buttonResultPageSettings.Size = new Size(89, 90);
            buttonResultPageSettings.TabIndex = 7;
            buttonResultPageSettings.UseVisualStyleBackColor = false;
            buttonResultPageSettings.Click += buttonResultPageSettings_Click;
            // 
            // labelResultPageClose
            // 
            labelResultPageClose.AutoSize = true;
            labelResultPageClose.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelResultPageClose.Location = new Point(1010, 0);
            labelResultPageClose.Name = "labelResultPageClose";
            labelResultPageClose.Size = new Size(55, 56);
            labelResultPageClose.TabIndex = 20;
            labelResultPageClose.Text = "X";
            labelResultPageClose.Click += labelResultPageClose_Click;
            // 
            // labelResultPageHelp
            // 
            labelResultPageHelp.AutoSize = true;
            labelResultPageHelp.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelResultPageHelp.Location = new Point(950, 0);
            labelResultPageHelp.Name = "labelResultPageHelp";
            labelResultPageHelp.Size = new Size(48, 56);
            labelResultPageHelp.TabIndex = 19;
            labelResultPageHelp.Text = "?";
            // 
            // ResultPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelResultPageClose);
            Controls.Add(labelResultPageHelp);
            Controls.Add(buttonResultPageSettings);
            Controls.Add(buttonResultPageToStatistics);
            Controls.Add(buttonResultPageToModeChoice);
            Controls.Add(buttonResultPageToMenu);
            Controls.Add(labelResultPageHeading);
            Controls.Add(panelResultPage);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "ResultPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            HelpButtonClicked += ResultPage_HelpButtonClicked;
            FormClosed += ResultPage_FormClosed;
            HelpRequested += ResultPage_HelpRequested;
            MouseDown += ResultPage_MouseDown;
            MouseMove += ResultPage_MouseMove;
            panelResultPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultPageCorrectCnt;
        private Label labelResultPageIncorrectCnt;
        private Label labelResultPageHeading;
        private Button buttonResultPageToMenu;
        private Button buttonResultPageToModeChoice;
        private Panel panelResultPage;
        private Button buttonResultPageToStatistics;
        private Button buttonResultPageSettings;
        private Label labelResultPageAccuracy;
        private Label labelResultPageMode;
        private ProgressBar progressBar1;
        private Label labelResultPageClose;
        private Label labelResultPageHelp;
    }
}