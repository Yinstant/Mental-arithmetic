namespace MentalArithmApp1
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonMainMenuStart = new Button();
            buttonMainMenuTextbook = new Button();
            buttonMainMenuStatistics = new Button();
            buttonMainMenuSettings = new Button();
            labelMainMenuHeading = new Label();
            buttonMainMenuAchievements = new Button();
            panelMainMenu = new Panel();
            panelMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMainMenuStart
            // 
            buttonMainMenuStart.BackColor = Color.Transparent;
            buttonMainMenuStart.BackgroundImageLayout = ImageLayout.None;
            buttonMainMenuStart.FlatAppearance.BorderSize = 0;
            buttonMainMenuStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuStart.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStart.Font = new Font("Cascadia Code", 22F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuStart.ForeColor = Color.FromArgb(255, 0, 98);
            buttonMainMenuStart.Image = (Image)resources.GetObject("buttonMainMenuStart.Image");
            buttonMainMenuStart.Location = new Point(36, 25);
            buttonMainMenuStart.Name = "buttonMainMenuStart";
            buttonMainMenuStart.Size = new Size(304, 90);
            buttonMainMenuStart.TabIndex = 0;
            buttonMainMenuStart.Text = "Начать тренировку";
            buttonMainMenuStart.UseVisualStyleBackColor = false;
            buttonMainMenuStart.Click += buttonMainMenuStart_Click;
            buttonMainMenuStart.MouseEnter += buttonMainMenuStart_MouseEnter;
            // 
            // buttonMainMenuTextbook
            // 
            buttonMainMenuTextbook.BackColor = Color.Transparent;
            buttonMainMenuTextbook.FlatAppearance.BorderSize = 0;
            buttonMainMenuTextbook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuTextbook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuTextbook.FlatStyle = FlatStyle.Flat;
            buttonMainMenuTextbook.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuTextbook.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuTextbook.Image = (Image)resources.GetObject("buttonMainMenuTextbook.Image");
            buttonMainMenuTextbook.Location = new Point(46, 139);
            buttonMainMenuTextbook.Name = "buttonMainMenuTextbook";
            buttonMainMenuTextbook.Size = new Size(274, 68);
            buttonMainMenuTextbook.TabIndex = 1;
            buttonMainMenuTextbook.Text = "Учебные материалы";
            buttonMainMenuTextbook.UseVisualStyleBackColor = false;
            buttonMainMenuTextbook.Click += buttonMainMenuTextbook_Click;
            // 
            // buttonMainMenuStatistics
            // 
            buttonMainMenuStatistics.BackColor = Color.Transparent;
            buttonMainMenuStatistics.FlatAppearance.BorderSize = 0;
            buttonMainMenuStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuStatistics.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStatistics.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuStatistics.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuStatistics.Image = (Image)resources.GetObject("buttonMainMenuStatistics.Image");
            buttonMainMenuStatistics.Location = new Point(46, 229);
            buttonMainMenuStatistics.Name = "buttonMainMenuStatistics";
            buttonMainMenuStatistics.Size = new Size(281, 68);
            buttonMainMenuStatistics.TabIndex = 2;
            buttonMainMenuStatistics.Text = "Статистика";
            buttonMainMenuStatistics.UseVisualStyleBackColor = false;
            buttonMainMenuStatistics.Click += buttonMainMenuStatistics_Click;
            // 
            // buttonMainMenuSettings
            // 
            buttonMainMenuSettings.FlatAppearance.BorderSize = 0;
            buttonMainMenuSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuSettings.FlatStyle = FlatStyle.Flat;
            buttonMainMenuSettings.Image = (Image)resources.GetObject("buttonMainMenuSettings.Image");
            buttonMainMenuSettings.Location = new Point(28, 12);
            buttonMainMenuSettings.Name = "buttonMainMenuSettings";
            buttonMainMenuSettings.Size = new Size(91, 88);
            buttonMainMenuSettings.TabIndex = 4;
            buttonMainMenuSettings.UseVisualStyleBackColor = true;
            buttonMainMenuSettings.Click += buttonMainMenuSettings_Click;
            // 
            // labelMainMenuHeading
            // 
            labelMainMenuHeading.Anchor = AnchorStyles.Top;
            labelMainMenuHeading.AutoSize = true;
            labelMainMenuHeading.BackColor = Color.Transparent;
            labelMainMenuHeading.FlatStyle = FlatStyle.Flat;
            labelMainMenuHeading.Font = new Font("Arial Black", 64F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelMainMenuHeading.ForeColor = Color.FromArgb(255, 0, 98);
            labelMainMenuHeading.Location = new Point(275, 65);
            labelMainMenuHeading.Name = "labelMainMenuHeading";
            labelMainMenuHeading.Size = new Size(499, 90);
            labelMainMenuHeading.TabIndex = 5;
            labelMainMenuHeading.Text = "Устный счёт";
            // 
            // buttonMainMenuAchievements
            // 
            buttonMainMenuAchievements.BackColor = Color.Transparent;
            buttonMainMenuAchievements.FlatAppearance.BorderSize = 0;
            buttonMainMenuAchievements.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuAchievements.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuAchievements.FlatStyle = FlatStyle.Flat;
            buttonMainMenuAchievements.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuAchievements.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuAchievements.Image = (Image)resources.GetObject("buttonMainMenuAchievements.Image");
            buttonMainMenuAchievements.Location = new Point(46, 328);
            buttonMainMenuAchievements.Name = "buttonMainMenuAchievements";
            buttonMainMenuAchievements.Size = new Size(281, 68);
            buttonMainMenuAchievements.TabIndex = 6;
            buttonMainMenuAchievements.Text = "Достижения";
            buttonMainMenuAchievements.UseVisualStyleBackColor = false;
            // 
            // panelMainMenu
            // 
            panelMainMenu.BackgroundImage = (Image)resources.GetObject("panelMainMenu.BackgroundImage");
            panelMainMenu.BackgroundImageLayout = ImageLayout.Center;
            panelMainMenu.Controls.Add(buttonMainMenuAchievements);
            panelMainMenu.Controls.Add(buttonMainMenuStart);
            panelMainMenu.Controls.Add(buttonMainMenuTextbook);
            panelMainMenu.Controls.Add(buttonMainMenuStatistics);
            panelMainMenu.Location = new Point(335, 179);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(378, 427);
            panelMainMenu.TabIndex = 7;
            // 
            // MainMenu
            // 
            AcceptButton = buttonMainMenuStart;
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelMainMenuHeading);
            Controls.Add(buttonMainMenuSettings);
            Controls.Add(panelMainMenu);
            Font = new Font("Segoe UI", 9F);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            HelpButtonClicked += MainMenu_HelpButtonClicked;
            FormClosed += MainMenu_FormClosed;
            HelpRequested += MainMenu_HelpRequested;
            panelMainMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenuStart;
        private Button buttonMainMenuTextbook;
        private Button buttonMainMenuStatistics;
        private Button buttonMainMenuSettings;
        private Label labelMainMenuHeading;
        private Button buttonMainMenuAchievements;
        private Panel panelMainMenu;
    }
}
