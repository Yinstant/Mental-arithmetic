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
            labelMainMenuClose = new Label();
            labelMainMenuHelp = new Label();
            panelMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMainMenuStart
            // 
            buttonMainMenuStart.Anchor = AnchorStyles.None;
            buttonMainMenuStart.BackColor = Color.Transparent;
            buttonMainMenuStart.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMainMenuStart.FlatAppearance.BorderSize = 0;
            buttonMainMenuStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuStart.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStart.Font = new Font("Cascadia Code", 22F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuStart.ForeColor = Color.FromArgb(255, 0, 98);
            buttonMainMenuStart.Image = (Image)resources.GetObject("buttonMainMenuStart.Image");
            buttonMainMenuStart.Location = new Point(42, 25);
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
            buttonMainMenuTextbook.Anchor = AnchorStyles.None;
            buttonMainMenuTextbook.BackColor = Color.Transparent;
            buttonMainMenuTextbook.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMainMenuTextbook.FlatAppearance.BorderSize = 0;
            buttonMainMenuTextbook.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuTextbook.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuTextbook.FlatStyle = FlatStyle.Flat;
            buttonMainMenuTextbook.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuTextbook.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuTextbook.Image = (Image)resources.GetObject("buttonMainMenuTextbook.Image");
            buttonMainMenuTextbook.Location = new Point(59, 135);
            buttonMainMenuTextbook.Name = "buttonMainMenuTextbook";
            buttonMainMenuTextbook.Size = new Size(274, 68);
            buttonMainMenuTextbook.TabIndex = 1;
            buttonMainMenuTextbook.Text = "Учебные материалы";
            buttonMainMenuTextbook.UseVisualStyleBackColor = false;
            buttonMainMenuTextbook.Click += buttonMainMenuTextbook_Click;
            // 
            // buttonMainMenuStatistics
            // 
            buttonMainMenuStatistics.Anchor = AnchorStyles.None;
            buttonMainMenuStatistics.BackColor = Color.Transparent;
            buttonMainMenuStatistics.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMainMenuStatistics.FlatAppearance.BorderSize = 0;
            buttonMainMenuStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuStatistics.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStatistics.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuStatistics.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuStatistics.Image = (Image)resources.GetObject("buttonMainMenuStatistics.Image");
            buttonMainMenuStatistics.Location = new Point(52, 222);
            buttonMainMenuStatistics.Name = "buttonMainMenuStatistics";
            buttonMainMenuStatistics.Size = new Size(281, 68);
            buttonMainMenuStatistics.TabIndex = 2;
            buttonMainMenuStatistics.Text = "Статистика";
            buttonMainMenuStatistics.UseVisualStyleBackColor = false;
            buttonMainMenuStatistics.Click += buttonMainMenuStatistics_Click;
            // 
            // buttonMainMenuSettings
            // 
            buttonMainMenuSettings.BackColor = Color.Transparent;
            buttonMainMenuSettings.FlatAppearance.BorderSize = 0;
            buttonMainMenuSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuSettings.FlatStyle = FlatStyle.Flat;
            buttonMainMenuSettings.Image = (Image)resources.GetObject("buttonMainMenuSettings.Image");
            buttonMainMenuSettings.Location = new Point(28, 12);
            buttonMainMenuSettings.Name = "buttonMainMenuSettings";
            buttonMainMenuSettings.Size = new Size(91, 88);
            buttonMainMenuSettings.TabIndex = 4;
            buttonMainMenuSettings.UseVisualStyleBackColor = false;
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
            buttonMainMenuAchievements.Anchor = AnchorStyles.None;
            buttonMainMenuAchievements.BackColor = Color.Transparent;
            buttonMainMenuAchievements.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMainMenuAchievements.FlatAppearance.BorderSize = 0;
            buttonMainMenuAchievements.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMainMenuAchievements.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMainMenuAchievements.FlatStyle = FlatStyle.Flat;
            buttonMainMenuAchievements.Font = new Font("Cascadia Code", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonMainMenuAchievements.ForeColor = Color.FromArgb(106, 37, 0);
            buttonMainMenuAchievements.Image = (Image)resources.GetObject("buttonMainMenuAchievements.Image");
            buttonMainMenuAchievements.Location = new Point(52, 316);
            buttonMainMenuAchievements.Name = "buttonMainMenuAchievements";
            buttonMainMenuAchievements.Size = new Size(281, 68);
            buttonMainMenuAchievements.TabIndex = 6;
            buttonMainMenuAchievements.Text = "Достижения";
            buttonMainMenuAchievements.UseVisualStyleBackColor = false;
            buttonMainMenuAchievements.Click += buttonMainMenuAchievements_Click;
            // 
            // panelMainMenu
            // 
            panelMainMenu.Anchor = AnchorStyles.None;
            panelMainMenu.BackgroundImage = (Image)resources.GetObject("panelMainMenu.BackgroundImage");
            panelMainMenu.BackgroundImageLayout = ImageLayout.Zoom;
            panelMainMenu.Controls.Add(buttonMainMenuAchievements);
            panelMainMenu.Controls.Add(buttonMainMenuStart);
            panelMainMenu.Controls.Add(buttonMainMenuStatistics);
            panelMainMenu.Controls.Add(buttonMainMenuTextbook);
            panelMainMenu.Location = new Point(339, 169);
            panelMainMenu.Name = "panelMainMenu";
            panelMainMenu.Size = new Size(391, 427);
            panelMainMenu.TabIndex = 7;
            // 
            // labelMainMenuClose
            // 
            labelMainMenuClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMainMenuClose.AutoSize = true;
            labelMainMenuClose.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelMainMenuClose.Location = new Point(1010, 0);
            labelMainMenuClose.Name = "labelMainMenuClose";
            labelMainMenuClose.Size = new Size(55, 56);
            labelMainMenuClose.TabIndex = 20;
            labelMainMenuClose.Text = "X";
            labelMainMenuClose.Click += labelMainMenuClose_Click;
            // 
            // labelMainMenuHelp
            // 
            labelMainMenuHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMainMenuHelp.AutoSize = true;
            labelMainMenuHelp.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelMainMenuHelp.Location = new Point(950, 0);
            labelMainMenuHelp.Name = "labelMainMenuHelp";
            labelMainMenuHelp.Size = new Size(48, 56);
            labelMainMenuHelp.TabIndex = 19;
            labelMainMenuHelp.Text = "?";
            // 
            // MainMenu
            // 
            AcceptButton = buttonMainMenuStart;
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelMainMenuClose);
            Controls.Add(labelMainMenuHelp);
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
            MouseDown += MainMenu_MouseDown;
            MouseMove += MainMenu_MouseMove;
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
        private Label labelMainMenuClose;
        private Label labelMainMenuHelp;
    }
}
