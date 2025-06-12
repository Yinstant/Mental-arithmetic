namespace MentalArithmApp1
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            labelSettingsPageHeading = new Label();
            buttonSettingsPageToMenu = new Button();
            radioButtonScreenSizeFixed = new RadioButton();
            radioButtonScreenSizeFull = new RadioButton();
            radioButtonScreenSizeAdaptive = new RadioButton();
            buttonSettingsSet = new Button();
            groupBoxScreenSize = new GroupBox();
            labelSettingsPageHelp = new Label();
            groupBoxTopPanel = new GroupBox();
            radioButtonTopPanelNo = new RadioButton();
            radioButtonTopPanelYes = new RadioButton();
            labelSettingsPageClose = new Label();
            buttonSettingsPageToBack = new Button();
            groupBoxScreenSize.SuspendLayout();
            groupBoxTopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelSettingsPageHeading
            // 
            labelSettingsPageHeading.Anchor = AnchorStyles.Top;
            labelSettingsPageHeading.AutoSize = true;
            labelSettingsPageHeading.BackColor = Color.Transparent;
            labelSettingsPageHeading.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSettingsPageHeading.ForeColor = Color.FromArgb(147, 15, 255);
            labelSettingsPageHeading.Location = new Point(388, 40);
            labelSettingsPageHeading.Name = "labelSettingsPageHeading";
            labelSettingsPageHeading.Size = new Size(267, 56);
            labelSettingsPageHeading.TabIndex = 0;
            labelSettingsPageHeading.Text = "Настройки";
            // 
            // buttonSettingsPageToMenu
            // 
            buttonSettingsPageToMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSettingsPageToMenu.FlatAppearance.BorderSize = 0;
            buttonSettingsPageToMenu.FlatStyle = FlatStyle.Flat;
            buttonSettingsPageToMenu.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonSettingsPageToMenu.ForeColor = Color.FromArgb(106, 37, 0);
            buttonSettingsPageToMenu.Image = (Image)resources.GetObject("buttonSettingsPageToMenu.Image");
            buttonSettingsPageToMenu.Location = new Point(837, 513);
            buttonSettingsPageToMenu.Name = "buttonSettingsPageToMenu";
            buttonSettingsPageToMenu.Size = new Size(217, 122);
            buttonSettingsPageToMenu.TabIndex = 7;
            buttonSettingsPageToMenu.Text = "В главное меню";
            buttonSettingsPageToMenu.UseVisualStyleBackColor = true;
            buttonSettingsPageToMenu.Click += buttonSettingsPageToMenu_Click;
            // 
            // radioButtonScreenSizeFixed
            // 
            radioButtonScreenSizeFixed.AutoSize = true;
            radioButtonScreenSizeFixed.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            radioButtonScreenSizeFixed.ForeColor = Color.FromArgb(106, 37, 0);
            radioButtonScreenSizeFixed.Location = new Point(6, 43);
            radioButtonScreenSizeFixed.Name = "radioButtonScreenSizeFixed";
            radioButtonScreenSizeFixed.Size = new Size(231, 37);
            radioButtonScreenSizeFixed.TabIndex = 9;
            radioButtonScreenSizeFixed.TabStop = true;
            radioButtonScreenSizeFixed.Text = "Фиксированный";
            radioButtonScreenSizeFixed.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSizeFull
            // 
            radioButtonScreenSizeFull.AutoSize = true;
            radioButtonScreenSizeFull.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            radioButtonScreenSizeFull.ForeColor = Color.FromArgb(106, 37, 0);
            radioButtonScreenSizeFull.Location = new Point(6, 88);
            radioButtonScreenSizeFull.Name = "radioButtonScreenSizeFull";
            radioButtonScreenSizeFull.Size = new Size(231, 37);
            radioButtonScreenSizeFull.TabIndex = 10;
            radioButtonScreenSizeFull.TabStop = true;
            radioButtonScreenSizeFull.Text = "Полноэкранный";
            radioButtonScreenSizeFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSizeAdaptive
            // 
            radioButtonScreenSizeAdaptive.AutoSize = true;
            radioButtonScreenSizeAdaptive.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            radioButtonScreenSizeAdaptive.ForeColor = Color.FromArgb(106, 37, 0);
            radioButtonScreenSizeAdaptive.Location = new Point(6, 135);
            radioButtonScreenSizeAdaptive.Name = "radioButtonScreenSizeAdaptive";
            radioButtonScreenSizeAdaptive.Size = new Size(186, 37);
            radioButtonScreenSizeAdaptive.TabIndex = 11;
            radioButtonScreenSizeAdaptive.TabStop = true;
            radioButtonScreenSizeAdaptive.Text = "Адаптивный";
            radioButtonScreenSizeAdaptive.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsSet
            // 
            buttonSettingsSet.Anchor = AnchorStyles.Bottom;
            buttonSettingsSet.BackColor = Color.Transparent;
            buttonSettingsSet.FlatStyle = FlatStyle.Flat;
            buttonSettingsSet.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonSettingsSet.Image = (Image)resources.GetObject("buttonSettingsSet.Image");
            buttonSettingsSet.Location = new Point(430, 479);
            buttonSettingsSet.Name = "buttonSettingsSet";
            buttonSettingsSet.Size = new Size(210, 156);
            buttonSettingsSet.TabIndex = 12;
            buttonSettingsSet.Text = "Применить настройки";
            buttonSettingsSet.UseVisualStyleBackColor = false;
            buttonSettingsSet.Click += buttonSettingsSet_Click;
            // 
            // groupBoxScreenSize
            // 
            groupBoxScreenSize.Anchor = AnchorStyles.None;
            groupBoxScreenSize.BackColor = Color.Transparent;
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeFixed);
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeFull);
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeAdaptive);
            groupBoxScreenSize.FlatStyle = FlatStyle.Flat;
            groupBoxScreenSize.Font = new Font("Arial Black", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBoxScreenSize.ForeColor = Color.FromArgb(255, 0, 98);
            groupBoxScreenSize.Location = new Point(52, 140);
            groupBoxScreenSize.Name = "groupBoxScreenSize";
            groupBoxScreenSize.Size = new Size(296, 184);
            groupBoxScreenSize.TabIndex = 13;
            groupBoxScreenSize.TabStop = false;
            groupBoxScreenSize.Text = "Размер экрана";
            // 
            // labelSettingsPageHelp
            // 
            labelSettingsPageHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSettingsPageHelp.AutoSize = true;
            labelSettingsPageHelp.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSettingsPageHelp.Location = new Point(950, 0);
            labelSettingsPageHelp.Name = "labelSettingsPageHelp";
            labelSettingsPageHelp.Size = new Size(48, 56);
            labelSettingsPageHelp.TabIndex = 14;
            labelSettingsPageHelp.Text = "?";
            labelSettingsPageHelp.Click += labelSettingsPageHelp_Click;
            // 
            // groupBoxTopPanel
            // 
            groupBoxTopPanel.Anchor = AnchorStyles.None;
            groupBoxTopPanel.BackColor = Color.Transparent;
            groupBoxTopPanel.Controls.Add(radioButtonTopPanelNo);
            groupBoxTopPanel.Controls.Add(radioButtonTopPanelYes);
            groupBoxTopPanel.Font = new Font("Arial Black", 25F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBoxTopPanel.ForeColor = Color.FromArgb(255, 0, 98);
            groupBoxTopPanel.Location = new Point(354, 140);
            groupBoxTopPanel.Name = "groupBoxTopPanel";
            groupBoxTopPanel.Size = new Size(467, 166);
            groupBoxTopPanel.TabIndex = 15;
            groupBoxTopPanel.TabStop = false;
            groupBoxTopPanel.Text = "Отображение верхней панели";
            // 
            // radioButtonTopPanelNo
            // 
            radioButtonTopPanelNo.AutoSize = true;
            radioButtonTopPanelNo.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            radioButtonTopPanelNo.ForeColor = Color.FromArgb(106, 37, 0);
            radioButtonTopPanelNo.Location = new Point(25, 105);
            radioButtonTopPanelNo.Name = "radioButtonTopPanelNo";
            radioButtonTopPanelNo.Size = new Size(261, 37);
            radioButtonTopPanelNo.TabIndex = 1;
            radioButtonTopPanelNo.TabStop = true;
            radioButtonTopPanelNo.Text = "Не отображается";
            radioButtonTopPanelNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTopPanelYes
            // 
            radioButtonTopPanelYes.AutoSize = true;
            radioButtonTopPanelYes.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            radioButtonTopPanelYes.ForeColor = Color.FromArgb(106, 37, 0);
            radioButtonTopPanelYes.Location = new Point(25, 50);
            radioButtonTopPanelYes.Name = "radioButtonTopPanelYes";
            radioButtonTopPanelYes.Size = new Size(216, 37);
            radioButtonTopPanelYes.TabIndex = 0;
            radioButtonTopPanelYes.TabStop = true;
            radioButtonTopPanelYes.Text = "Отображается";
            radioButtonTopPanelYes.UseVisualStyleBackColor = true;
            // 
            // labelSettingsPageClose
            // 
            labelSettingsPageClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSettingsPageClose.AutoSize = true;
            labelSettingsPageClose.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSettingsPageClose.Location = new Point(1010, 0);
            labelSettingsPageClose.Name = "labelSettingsPageClose";
            labelSettingsPageClose.Size = new Size(55, 56);
            labelSettingsPageClose.TabIndex = 16;
            labelSettingsPageClose.Text = "X";
            labelSettingsPageClose.Click += labelSettingsPageClose_Click;
            // 
            // buttonSettingsPageToBack
            // 
            buttonSettingsPageToBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSettingsPageToBack.BackColor = Color.Transparent;
            buttonSettingsPageToBack.FlatAppearance.BorderSize = 0;
            buttonSettingsPageToBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSettingsPageToBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSettingsPageToBack.FlatStyle = FlatStyle.Flat;
            buttonSettingsPageToBack.Image = (Image)resources.GetObject("buttonSettingsPageToBack.Image");
            buttonSettingsPageToBack.Location = new Point(58, 496);
            buttonSettingsPageToBack.Name = "buttonSettingsPageToBack";
            buttonSettingsPageToBack.Size = new Size(160, 139);
            buttonSettingsPageToBack.TabIndex = 17;
            buttonSettingsPageToBack.UseVisualStyleBackColor = false;
            buttonSettingsPageToBack.Click += buttonSettingsPageToBack_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonSettingsPageToBack);
            Controls.Add(labelSettingsPageClose);
            Controls.Add(groupBoxTopPanel);
            Controls.Add(labelSettingsPageHelp);
            Controls.Add(buttonSettingsSet);
            Controls.Add(buttonSettingsPageToMenu);
            Controls.Add(labelSettingsPageHeading);
            Controls.Add(groupBoxScreenSize);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "SettingsPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            FormClosed += SettingsPage_FormClosed;
            MouseDown += SettingsPage_MouseDown;
            MouseMove += SettingsPage_MouseMove;
            groupBoxScreenSize.ResumeLayout(false);
            groupBoxScreenSize.PerformLayout();
            groupBoxTopPanel.ResumeLayout(false);
            groupBoxTopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSettingsPageHeading;
        private Button buttonSettingsPageToMenu;
        private RadioButton radioButtonScreenSizeFixed;
        private RadioButton radioButtonScreenSizeFull;
        private RadioButton radioButtonScreenSizeAdaptive;
        private Button buttonSettingsSet;
        private GroupBox groupBoxScreenSize;
        private Label labelSettingsPageHelp;
        private GroupBox groupBoxTopPanel;
        private RadioButton radioButtonTopPanelNo;
        private RadioButton radioButtonTopPanelYes;
        private Label labelSettingsPageClose;
        private Button buttonSettingsPageToBack;
    }
}